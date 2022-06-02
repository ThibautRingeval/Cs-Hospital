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
    public partial class Vaccin : Form
    {
        public Vaccin()
        {
            InitializeComponent();
            // Appel à l'API Liste des roles
            string url = "http://127.0.0.1:8000/api/Vaccins";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();
            Console.WriteLine("test");
            Console.WriteLine(data);

            Vaccins Vaccins = JsonConvert.DeserializeObject<Vaccins>(data);
            this.ListboxVaccins.DataSource = Vaccins.ListVaccins;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
