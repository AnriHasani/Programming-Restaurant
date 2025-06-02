using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Restaurant
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registerSuccess = await RegisterUserAsync(username, password);

            // If registration 400 (user exists), proceed to login anyway
            // If other error, stop.
            //if (!registerSuccess)
            //{
            //    var userExists = MessageBox.Show("User might already exist. Do you want to try login instead?", "Registration Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (userExists != DialogResult.Yes)
            //    {
            //        return;
            //    }
            //}

            bool loginSuccess = await LoginUserAsync(username, password);

            if (loginSuccess)
            {
                SeatSelection SeatSelectionForm = new SeatSelection();
                SeatSelectionForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> RegisterUserAsync(string username, string password)
        {
            var registerData = new
            {
                username = username,
                password = password
            };

            string url = "http://5.61.35.109:5000/register";

            try
            {
                string json = JsonConvert.SerializeObject(registerData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registered successfully.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    // User already exists
                    return false;
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Registration failed: {errorMessage}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> LoginUserAsync(string username, string password)
        {
            var loginData = new
            {
                username = username,
                password = password
            };

            string url = "http://5.61.35.109:5000/login";

            try
            {
                string json = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    // Optionally you can parse the JSON response here if needed
                    return true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    return false;
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Login failed: {errorMessage}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

