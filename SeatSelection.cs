using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Restaurant
{
    public partial class SeatSelection : Form
    {
        private PictureBox selectedTable = null; // To keep track of the selected table
        private List<Table> tables; // List to hold table data
        private bool isDeleteMode = false;


        public SeatSelection()
        {
            InitializeComponent();
        }

        private async void SeatSelection_Load(object sender, EventArgs e)
        {
            await LoadTableDataAsync(); // Load table data when the form loads
            UpdateTableUI(); // Update the UI based on the loaded data
        }

        private async Task LoadTableDataAsync()
        {
            string url = "http://5.61.35.109:5000/reservations"; // Your endpoint to fetch reservation data

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        tables = JsonConvert.DeserializeObject<List<Table>>(json);
                    }
                    else
                    {
                        MessageBox.Show("Failed to load table data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading table data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTableUI()
        {
            foreach (var table in tables)
            {
                PictureBox tablePictureBox = Controls.Find($"table_{table.id}", true)[0] as PictureBox;
                if (tablePictureBox != null)
                {
                    tablePictureBox.BackColor = table.isReserved ? Color.Red : SystemColors.Control; // Change color based on reservation status
                }
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                int tableId = int.Parse(selectedTable.Name.Replace("table_", ""));
                var table = tables.Find(t => t.id == tableId);
                if (table != null && table.isReserved)
                {
                    MessageBox.Show($"Details for Table {tableId}:\n" +
                                    $"Reserved By: {table.reservedBy}\n" +
                                    $"Name: {table.reservation.firstName} {table.reservation.lastName}\n" +
                                    $"Date & Time: {table.reservation.dateTime}\n" +
                                    $"People Count: {table.reservation.peopleCount}",
                                    "Table Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Table {tableId} is not reserved.", "Table Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a table first.", "No Table Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void table_Click(object sender, EventArgs e)
        {
            PictureBox clickedTable = sender as PictureBox;
            int tableId = int.Parse(clickedTable.Name.Replace("table_", ""));
            Table table = tables.Find(t => t.id == tableId);

            if (table == null)
                return;

            // If in delete mode
            if (isDeleteMode)
            {
                isDeleteMode = false; // Exit delete mode after one attempt

                if (!table.isReserved)
                {
                    MessageBox.Show($"Table {tableId} is not reserved.", "Not Reserved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string adminUsername = "admin"; // Replace with actual admin username
                string url = $"http://5.61.35.109:5000/reservation/{tableId}?adminUser={adminUsername}";

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.DeleteAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Reservation for Table {tableId} canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to cancel: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                await LoadTableDataAsync();
                UpdateTableUI();
                return;
            }

            // Regular table click (Details form)
            if (selectedTable != null)
                selectedTable.BackColor = SystemColors.Control;

            selectedTable = clickedTable;
            selectedTable.BackColor = Color.LightGreen;

            Details detailsForm = new Details(table);
            detailsForm.ShowDialog(); // Open details form
            await LoadTableDataAsync(); // Refresh UI after details
            UpdateTableUI();
        }



        private async void btn_Create_Reservation_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                string tableId = selectedTable.Name; // Assuming table names are like "table_1", "table_2", etc.
                string username = "john"; // Replace with actual username from your context
                string firstName = "John"; // Replace with actual first name
                string lastName = "Doe"; // Replace with actual last name
                string dateTime = DateTime.Now.AddHours(1).ToString("yyyy-MM-ddTHH:mm:ss"); // Example date/time
                int peopleCount = 4; // Example people count

                var reservationData = new
                {
                    tableId = int.Parse(tableId.Replace("table_", "")), // Extract table number
                    username = username,
                    firstName = firstName,
                    lastName = lastName,
                    dateTime = dateTime,
                    peopleCount = peopleCount
                };

                string url = "http://5.61.35.109:5000/reserve"; // Your reservation endpoint

                try
                {
                    string json = JsonConvert.SerializeObject(reservationData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Table reserved successfully!", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadTableDataAsync(); // Reload table data to update UI
                            UpdateTableUI(); // Update the UI based on the new data
                        }
                        else
                        {
                            string errorMessage = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Reservation failed: {errorMessage}", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while making the reservation:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a table to reserve.", "No Table Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Reservation_Click(object sender, EventArgs e)
        {
            isDeleteMode = true;
            MessageBox.Show("Click on a reserved table to cancel its reservation.", "Delete Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

    public class Table
    {
        public int id { get; set; }
        public bool isReserved { get; set; }
        public string reservedBy { get; set; }
        public Reservation reservation { get; set; }

       

    }

    public class Reservation
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateTime { get; set; }
        public int peopleCount { get; set; }
    }
}
