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
            
                VariablesGlobales.Globales.idBibliotecario = Convert.ToDecimal(cbNombreBibliotecario.SelectedValue);
                VariablesGlobales.Globales.fechaFinal = dtpFechaFinal.Text;
                VariablesGlobales.Globales.fechaInicial = dtpFechaInicial.Text;
                new FormReporteDeBibliotecarios().Show();

        }


        private void GenerarReporteDeBibliotecarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Forms.FrmBibliotecarios().Show();
        }

        private void GenerarReporteDeBibliotecarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecariosDataSet1.Bibliotecarios' Puede moverla o quitarla según sea necesario.
            this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);

        }
    }
}
