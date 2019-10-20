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

namespace PruebaBiblioteca1.Forms.Usuarios
{
    public partial class GenerarReporteDeBibliotecarios : Form
    {
        public GenerarReporteDeBibliotecarios()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (txtIdBibliotecario.Text == "")//|| txtFechaFinal.Text == "" || txtFechaInicial.Text == "")
            {
                MessageBox.Show("Ingrese ID Bibliotecario");
            }
            else
            {
                VariablesGlobales.Globales.idBibliotecario = Convert.ToDecimal(txtIdBibliotecario.Text);
                VariablesGlobales.Globales.fechaFinal = dtpFechaFinal.Text;
                VariablesGlobales.Globales.fechaInicial = dtpFechaInicial.Text;
                new FormReporteDeBibliotecarios().Show();
            }
        }

        private void TxtIdBibliotecario_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtIdBibliotecario.Text, @"^\d+$") == false)
            {
                txtIdBibliotecario.Text = "";
            }
        }
    }
}
