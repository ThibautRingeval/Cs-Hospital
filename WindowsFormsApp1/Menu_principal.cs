using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using ClassLibrary2;

namespace WindowsFormsApp1
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            // Appel à l'API Liste des roles
            string url = "http://127.0.0.1:8000/api/employers";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();
            Console.WriteLine("test");
            Console.WriteLine(data);

            Employers employers = JsonConvert.DeserializeObject<Employers>(data);
            this.ListboxEmployers.DataSource = employers.ListEmployers;



        }


        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter ajouter = new Ajouter();
            ajouter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supprimer supprimer = new Supprimer((Employer)this.ListboxEmployers.SelectedItem);
            supprimer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier modifier = new Modifier();
            modifier.Show();
        }

        private void Occupation_lit_Click(object sender, EventArgs e)
        {

        }

        private void ListboxEmployers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Lits lits = new Lits();
            lits.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Vaccin vaccin = new Vaccin();
            vaccin.Show();
        }
    }
}
