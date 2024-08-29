using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int resul = 0;
            if(String.IsNullOrEmpty(txtBox1.Text) || String.IsNullOrEmpty(txtBox2.Text))
            {
                MessageBox.Show("No se puede");
            }
            else
            {
                resul = Convert.ToInt32(txtBox1.Text) + Convert.ToInt32(txtBox2.Text);
                txtBox3.Text = Convert.ToString(resul);
            }
            limpiar();
        }
        public void limpiar()
        {
            txtBox1.Text = "0";
            txtBox2.Text = "0";
            txtBox1.Focus ();
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_Click(object sender, EventArgs e)
        {

        }
    }
}
