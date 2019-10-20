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
    public partial class GenerarReporteUsuario : Form
    {
        public GenerarReporteUsuario()
        {
            InitializeComponent();
        }

  

        private void TxtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtIdUsuario.Text, @"^\d+$") == false)
            {
                txtIdUsuario.Text = "";
            }
            if (txtIdUsuario.Text == "")
            {
                this.usuariosTableAdapter.FillDGVporIdUsuario(this.usuariosDataSet1.Usuarios, 0);

            }
            else if (usuariosTableAdapter.ExisteUsuarioConIdUsuario(Convert.ToDecimal(txtIdUsuario.Text)) > 0)
            {
                this.usuariosTableAdapter.FillDGVporIdUsuario(this.usuariosDataSet1.Usuarios, Convert.ToDecimal(txtIdUsuario.Text));
            }
            else
            {
                this.usuariosTableAdapter.FillDGVporIdUsuario(this.usuariosDataSet1.Usuarios, 0);

            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Id de Usuario");
            }
            else
            {
                VariablesGlobales.Globales.idUsuario = Convert.ToDecimal(txtIdUsuario.Text);
                new Usuarios.FormReporteDeUsuarios().Show();
            }
        }
    }
}
