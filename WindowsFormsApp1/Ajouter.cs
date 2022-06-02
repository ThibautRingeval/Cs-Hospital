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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
            // Appel à l'API Liste des roles
            string url = "http://127.0.0.1:8000/api/services";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            WebResponse webResponse = request.GetResponse();

            var webStream = webResponse.GetResponseStream();
            string data = new StreamReader(webStream).ReadToEnd();
            Console.WriteLine("test");
            Console.WriteLine(data);

            Services services = JsonConvert.DeserializeObject<Services>(data);
            this.Service_Cb.DataSource = services.ListServices;
        }

        private void Ajout_btn_Click(object sender, EventArgs e)
        {
            List<string> roll = new List<string>();
            roll.Add((string)this.Role_cb.SelectedItem);
            Service service = (Service)(this.Service_Cb.SelectedItem);

            Employer employer = new Employer($"/api/services/{service.id}", this.Mail_Tb.Text, roll , this.Password_tb.Text, this.Function_tb.Text, this.Numsec_tb.Text , this.Name_Tb.Text, this.Surname_Tb.Text, this.Num_Tb.Text);
            string url = "http://127.0.0.1:8000/api/employers";
            var request = WebRequest.Create(url);
            request.Method = "POST";

            var json = JsonConvert.SerializeObject(employer);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);
            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            var respStream = response.GetResponseStream();
        }

        private void Name_Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Service_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Role_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//int idService, string email, List<string> roles, string password, string fonction, string num_secu_social, string nom, string prenom, string telephone
    }
}
