using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calendar.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            calendar1.CalendarDate = new DateTime(2023, 10, 20, 15, 30, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;
            var ce = new CustomEvent
                {
                    IgnoreTimeComponent = false,
                    EventText = "Dinner",
                    Date = new DateTime(2023, 10, 20, 15, 30, 0),
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("Verdana", 12, FontStyle.Regular),
                    Enabled = true,
                    EventColor = Color.FromArgb(120, 255, 120),
                    EventTextColor = Color.Black,
                    ThisDayForwardOnly=true
                };
            calendar1.AddEvent(ce);
        }

       

        private void calendar1_Load(object sender, EventArgs e)
        {
            
        }

        private void createContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contact = new ContactForm();
            contact.Show();
            
        }

        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            EventDetails details = new EventDetails();
            details.Show();
        }
        

        private void showContactsButton_Click(object sender, EventArgs e)
        {
            Contacts.Items.Clear();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-API-Key", "QXBpS2V5TWlkZGxld2FyZQ==");
            client.BaseAddress = new Uri("https://localhost:44301/api/v3/");
            HttpResponseMessage response = client.GetAsync("contacts").Result;

            var emp = response.Content.ReadAsStringAsync().Result;
            
            List<CONTACT> c = JsonConvert.DeserializeObject<List<CONTACT>>(emp);
            foreach (CONTACT contact in c) {
                Contacts.Items.Add(contact.Name+" "+contact.ContactID);
            }
            

        }

        private async void deleteContactButton_Click(object sender, EventArgs e)
        {
            var id=0;
            id = int.Parse(idContact.Text);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-API-Key", "QXBpS2V5TWlkZGxld2FyZQ==");
            client.BaseAddress = new Uri("https://localhost:44301/api/v3/");
            
            try
            {
                // Senden Sie die HTTP DELETE-Anfrage
                HttpResponseMessage response = await client.DeleteAsync($"contacts/{id}");

                // Überprüfen Sie die Antwort und verarbeiten Sie sie entsprechend
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ressource erfolgreich gelöscht.");
                }
                else
                {
                    MessageBox.Show($"Fehler beim Löschen der Ressource. Statuscode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler bei der HTTP-Anfrage: {ex.Message}");
            }
        }

        private async void showContact_Click(object sender, EventArgs e)
        {
            var id = 0;
            id = int.Parse(idContact.Text);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-API-Key", "QXBpS2V5TWlkZGxld2FyZQ==");
            client.BaseAddress = new Uri("https://localhost:44301/api/v3/");

            try
            {
                // Senden Sie die HTTP DELETE-Anfrage
                HttpResponseMessage response = await client.GetAsync($"contacts/{id}");

                // Überprüfen Sie die Antwort und verarbeiten Sie sie entsprechend
                if (response.IsSuccessStatusCode)
                {
                    var emp = response.Content.ReadAsStringAsync().Result;

                    CONTACT c = JsonConvert.DeserializeObject<CONTACT>(emp);
                    MessageBox.Show(c.ToString());
                }
                else
                {
                    MessageBox.Show($"Kontakt nicht gefunden. Statuscode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Fehler bei der HTTP-Anfrage: {ex.Message}");
            }
        }

    
    }
}