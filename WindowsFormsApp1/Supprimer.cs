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
    public partial class Supprimer : Form
    {
        private Employer employer;

        public Supprimer(Employer employer)
        {
            InitializeComponent();
            this.employer = employer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(employer.id);
            string URL = $"http://localhost:8000/api/employers/{employer.id}";
            WebRequest request = WebRequest.Create(URL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
