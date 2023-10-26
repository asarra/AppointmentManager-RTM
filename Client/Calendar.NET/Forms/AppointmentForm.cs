using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Calendar.NET.Forms
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Create_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-API-Key", "QXBpS2V5TWlkZGxld2FyZQ==");
            client.BaseAddress = new Uri("https://localhost:44301/api/v3/");
            var content = new APPOINTMENT();
            var reminder = new Reminder();
            content.Topic = Topic.Text;
            content.City = City.Text;
            content.StartTime = Start.Value.ToString("yyyy-MM-dd HH:mm:ss");
            content.EndTime = End.Value.ToString("yyyy-MM-dd HH:mm:ss");
            content.ContactID = long.Parse(ContactId.Text);
            content.Repetition = int.Parse(Repetition.Text);
            content.Note = Note.Text;
            reminder.Time = content.StartTime;
            reminder.ReminderID = 12;
            
            content.ToJson();

            string json = JsonConvert.SerializeObject(content, Formatting.Indented);


            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PostAsync("appointments", httpContent);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show("Appointment successfully created");
            this.Close();
        }
    }
}
