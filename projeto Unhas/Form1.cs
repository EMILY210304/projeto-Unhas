using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Unhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)

        {
            string name = txbEmail.Text;
            string enrollment = txbSenha.Text;


            string message = "Nome:" + name +
                "\nMatrícula:" + enrollment;
            
            MessageBox.Show(
                "Agora você está na nossa plataforma!" ,
                "Olá seja bem vindo(a)!!",
                MessageBoxButtons.OK,
              MessageBoxIcon.Information
                 );
        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
