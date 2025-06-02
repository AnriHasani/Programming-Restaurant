using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Restaurant
{
    public partial class Details : Form
    {
        private Table currentTable; // Store the current table information

        public Details(Table table)
        {
            InitializeComponent();
            currentTable = table; // Set the current table
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // Populate fields with current reservation details
            label_table.Text = $"Table {currentTable.id}"; // Display the table number
            if (currentTable.isReserved)
            {
                details_name.Text = currentTable.reservation.firstName;
                details_surname.Text = currentTable.reservation.lastName;
                details_time.Value = DateTime.Parse(currentTable.reservation.dateTime);
                details_number.SelectedItem = currentTable.reservation.peopleCount.ToString();
            }
            else
            {
                // If not reserved, clear fields for new entry
                details_name.Clear();
                details_surname.Clear();
                details_time.Value = DateTime.Now; // Set to current time
                details_number.SelectedItem = "1"; // Default to 1 person
            }
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            // Create reservation data from the fields
            var reservationData = new
            {
                tableId = currentTable.id,
                username = "john", // Replace with actual username
                firstName = details_name.Text,
                lastName = details_surname.Text,
                dateTime = details_time.Value.ToString("yyyy-MM-ddTHH:mm:ss"),
                peopleCount = int.Parse(details_number.SelectedItem.ToString())
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
                        MessageBox.Show("Reservation saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the details form
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to save reservation: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the reservation:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the details form when the back button is clicked
        }
        private void label5_Click(object sender, EventArgs e)
        {
            // Optional: Implement behavior for header label click
        }

        private void label_table_Click(object sender, EventArgs e)
        {
            // Optional: Could be used to show more info about the table
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live validation or formatting for first name
        }

        private void details_surname_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live validation or formatting for surname
        }

        private void details_time_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Restrict to valid reservation times
        }

        private void details_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Suggest available tables or validate person count
        }

    }
}
