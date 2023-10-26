using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calendar.NET
{
    public partial class ContactForm : Form
    {



        public ContactForm()
        {
            InitializeComponent();
        }

        

        private void Contact_Load(object sender, EventArgs e)
        {

        }

      



        private async void createButton_Click(object sender, EventArgs e)
        {

             



            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-API-Key", "QXBpS2V5TWlkZGxld2FyZQ==");
            client.BaseAddress = new Uri("https://localhost:44301/api/v3/");
            var priv = 0;
            if (privateContact.Checked)
            {
                priv = 1;
            }
            var content = new CONTACT();
            
            content.Name = name.Text;
            content.Street = street.Text;
            content.City = city.Text;
            content.Email = email.Text;
            content.Company = company.Text;
            content.Telephone = long.Parse(telephone.Text);
            content.Note = note.Text ;
            content.PostalCode = int.Parse(postalCode.Text);
            content.ContactType = priv;
            content.ToJson();
            
            string json = JsonConvert.SerializeObject(content, Formatting.Indented);

            
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PostAsync("contacts", httpContent);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show("Contact successfully created");
            this.Close();






        }

        
    }
}
