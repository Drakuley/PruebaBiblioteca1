﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms.Autores
{
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        private void TxtIdAutor_TextChanged(object sender, EventArgs e)
        {
            if(txtIdAutor.Text == "")
            {
                btnAceptar.Text = "Aceptar";

            }
            else if(autoresTableAdapter.existeAutorConIdAutor(Convert.ToDecimal(txtIdAutor.Text)) > 0)
            {
                
                btnAceptar.Text = "Modificar";
            }
            else
            {
                btnAceptar.Text = "Registrar";
            }
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autoresDataSet1.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(btnAceptar.Text == "Modificar")
            {
                if (txtIdAutor.Text == "" || txtNombreAutor.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    autoresTableAdapter.UpdateQueryAutores(Convert.ToDecimal(txtIdAutor.Text), txtNombreAutor.Text, Convert.ToDecimal(txtIdAutor.Text));
                    this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);
                    txtIdAutor.Text = "";
                    txtNombreAutor.Text = "";

                    txtIdAutor.Focus();
                }
                
            }
            else
            {
                if (txtIdAutor.Text == "" || txtNombreAutor.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    if (autoresTableAdapter.existeAutorConIdAutor(Convert.ToDecimal(txtIdAutor.Text)) > 0 || txtIdAutor.Text == "")
                    {
                        MessageBox.Show("El Autor que quieres registrar ya existe en la Base de Datos");
                    }
                    else
                    {
                        autoresTableAdapter.InsertQueryAutores(Convert.ToDecimal(txtIdAutor.Text), txtNombreAutor.Text);
                        this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);
                        txtIdAutor.Text = "";
                        txtNombreAutor.Text = "";
                        txtIdAutor.Focus();
                    }
                }
                
                
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(txtIdAutor.Text == "" )
            {
                MessageBox.Show("Ingresa el Id del Autor que deseas eliminar");
            }
            else
            {
                if (autoresTableAdapter.existeAutorConIdAutor(Convert.ToDecimal(txtIdAutor.Text)) > 0)
                {
                    autoresTableAdapter.DeleteQueryAutores(Convert.ToDecimal(txtIdAutor.Text));
                    this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);
                    txtIdAutor.Text = "";
                    txtNombreAutor.Text = "";
                    txtIdAutor.Focus();
                }
                else
                {
                    MessageBox.Show("El Autor que quieres eliminar no existe en la Base de Datos");
                }
            }
            
        }

        private void TxtNombreAutor_TextChanged(object sender, EventArgs e)
        {
            if(txtNombreAutor.Text == "")
            {
                this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);

            }
            else
            {
                this.autoresTableAdapter.FillDGVAutoresPorNombreAutor(this.autoresDataSet1.Autores,txtNombreAutor.Text);
            }
        }
    }
}
