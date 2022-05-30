using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter ajouter = new Ajouter();
            Ajouter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supprimer supprimer = new Supprimer();
            Supprimer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifier modifier = new Modifier();
            Modifier.Show();
        }

        private void Occupation_lit_Click(object sender, EventArgs e)
        {

        }
    }
}
