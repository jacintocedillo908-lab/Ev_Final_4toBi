using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Jacinto" && TextContraseña.Text == "11")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            else
            {
                MessageBox.Show("Sus datos son invalidos por favor intente de nuevo");
            }
        }
    }
}
