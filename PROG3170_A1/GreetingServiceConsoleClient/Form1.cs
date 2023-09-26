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

        private void btnGenerateGreeting_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new GreetingRequest
                {
                    TimeOfDay = cmbTimeOfDay.SelectedItem.ToString(),
                    Language = cmbLanguage.SelectedItem.ToString()
                };

                var response = client.Greet(request);
                lblGreeting.Text = response.Greeting;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
