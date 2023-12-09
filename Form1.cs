using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Meniu";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dbButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReceptie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReceptie formReceptie= new FormReceptie();
            formReceptie.ShowDialog();
            this.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaborator formLaborator= new FormLaborator();
            formLaborator.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPsihiatrie formPsihiatrie = new FormPsihiatrie();
            formPsihiatrie.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTerapiePsihologica formTerapPsihol = new FormTerapiePsihologica();
            formTerapPsihol.ShowDialog();
            this.Show();
        }
    }
}
