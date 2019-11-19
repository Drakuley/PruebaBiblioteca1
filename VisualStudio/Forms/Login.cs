using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "" || txtIdBibliotecario.Text == "")
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else if (Convert.ToInt32(bibliotecariosTableAdapter1.ExisteBibliotecarioConIdyContraseña(Convert.ToDecimal(txtIdBibliotecario.Text),txtContraseña.Text)) == 1)
            {
                VariablesGlobales.Globales.idBibliotecario = Convert.ToDecimal(txtIdBibliotecario.Text);
                new Biblioteca4.Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Número de bibliotecario y/o contraseña incorrectos");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtIdBibliotecario_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtIdBibliotecario.Text, @"^\d+$") == false)
            {
                //MessageBox.Show("Ingrese ID númerico");
                txtIdBibliotecario.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
