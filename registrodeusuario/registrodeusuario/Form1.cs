using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrodeusuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridViewListaUsuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TXNOMBRE.Text, TXNOMBRE2.Text, comboNOMBRE.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }
}
        
    

  

