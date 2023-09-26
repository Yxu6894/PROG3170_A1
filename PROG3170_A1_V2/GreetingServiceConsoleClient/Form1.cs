using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreetingServiceConsoleClient.GreetingServiceReference;

namespace GreetingServiceConsoleClient
{
    public partial class Form1 : Form
    {

        private IGreetingService client;
        public Form1()
        {
            InitializeComponent();

            client = new GreetingServiceClient();

            PopulateTimeOfDay();
            PopulateLanguages();
            PopulateTones();
        }

        private void PopulateTimeOfDay()
        {
            var times = client.GetAllTimesOfDay();
            cmbTimeOfDay.DataSource = times;
        }

        private void PopulateLanguages()
        {
            var languages = client.GetSupportedLanguages();
            cmbLanguage.DataSource = languages;
        }

        private void PopulateTones()
        {
            // Since tones are static, we'll just add them directly.
            cmbTone.Items.Add("Formal");
            cmbTone.Items.Add("Casual");
            cmbTone.SelectedIndex = 0; // Default to "Formal"
        }
        private void btnGenerateGreeting_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new GreetingRequest
                {
                    TimeOfDay = cmbTimeOfDay.SelectedItem.ToString(),
                    Language = cmbLanguage.SelectedItem.ToString(),
                    Tone = cmbTone.SelectedItem.ToString()
                };

                var response = client.Greet(request);
                lblGreeting.Text = response.Greeting;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
