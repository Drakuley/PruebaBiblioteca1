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
    public partial class FrmUsuarios : Form
    {

        private Label label6;
        private TextBox txtIdUsuario;
        private Label label5;
        private ComboBox cbGeneroUsuario;
        private Label label4;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label direccion;
        private DataGridView dgvUsuarios;
        private Label Nombre;
        private Panel panel1;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnAceptar;
        private Panel panel2;
        private UsuariosDataSet1 usuariosDataSet1;
        private BindingSource usuariosBindingSource;
        private IContainer components;
        private UsuariosDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private TextBox txtNombreUsuario;

        public FrmUsuarios()
        {
           InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGeneroUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataSet1 = new PruebaBiblioteca1.UsuariosDataSet1();
            this.usuariosTableAdapter = new PruebaBiblioteca1.UsuariosDataSet1TableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = " Registro de Usuarios";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(102, 57);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtIdUsuario.TabIndex = 42;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.TxtIdUsuario_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID:";
            // 
            // cbGeneroUsuario
            // 
            this.cbGeneroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroUsuario.FormattingEnabled = true;
            this.cbGeneroUsuario.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbGeneroUsuario.Location = new System.Drawing.Point(102, 192);
            this.cbGeneroUsuario.Name = "cbGeneroUsuario";
            this.cbGeneroUsuario.Size = new System.Drawing.Size(171, 24);
            this.cbGeneroUsuario.TabIndex = 40;
            this.cbGeneroUsuario.Text = "Masculino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(102, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 22);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(102, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 22);
            this.txtDireccion.TabIndex = 36;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.ForeColor = System.Drawing.Color.White;
            this.direccion.Location = new System.Drawing.Point(14, 129);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(78, 16);
            this.direccion.TabIndex = 35;
            this.direccion.Text = "Dirección:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuariosBindingSource;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(616, 460);
            this.dgvUsuarios.TabIndex = 34;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(14, 94);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 16);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(102, 91);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtNombreUsuario.TabIndex = 32;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.TxtNombreUsuario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbGeneroUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.direccion);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Location = new System.Drawing.Point(622, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 460);
            this.panel1.TabIndex = 47;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporte.AutoSize = true;
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(17, 410);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(256, 36);
            this.btnReporte.TabIndex = 67;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(153, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 36);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(17, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 36);
            this.btnAceptar.TabIndex = 65;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(615, -43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 48;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.usuariosDataSet1;
            // 
            // usuariosDataSet1
            // 
            this.usuariosDataSet1.DataSetName = "UsuariosDataSet1";
            this.usuariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUsuarios
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
            cbGeneroUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void TxtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtIdUsuario.Text, @"^\d+$") == false)
            {
                //MessageBox.Show("Ingrese ID númerico");
                txtIdUsuario.Text = "";
            }
            if (txtIdUsuario.Text == "")
            {
                this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
                txtIdUsuario.Text = "";
                txtNombreUsuario.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                cbGeneroUsuario.Text = "";

                txtIdUsuario.Focus();
                btnAceptar.Text = "Aceptar";

            }
            else if (usuariosTableAdapter.ExisteUsuarioConIdUsuario(Convert.ToDecimal(txtIdUsuario.Text)) > 0)
            {
                this.usuariosTableAdapter.FillDGVporIdUsuario(this.usuariosDataSet1.Usuarios, Convert.ToDecimal(txtIdUsuario.Text));
                btnAceptar.Text = "Modificar";
                txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[2].FormattedValue.ToString();
                txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[3].FormattedValue.ToString();
                cbGeneroUsuario.Text = dgvUsuarios.CurrentRow.Cells[4].FormattedValue.ToString();

            }
            else
            {
                btnAceptar.Text = "Registrar";
                //NUEVA lIMEA
                txtNombreUsuario.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                cbGeneroUsuario.Text = "";
                this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Modificar")
            {
                if (txtIdUsuario.Text == "" || txtNombreUsuario.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || cbGeneroUsuario.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    usuariosTableAdapter.UpdateQueryUsuarios(Convert.ToDecimal(txtIdUsuario.Text), txtNombreUsuario.Text, txtDireccion.Text, txtTelefono.Text, cbGeneroUsuario.Text, Convert.ToDecimal(txtIdUsuario.Text));
                    this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
                    txtIdUsuario.Text = "";
                    txtNombreUsuario.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    cbGeneroUsuario.Text = "";

                    txtIdUsuario.Focus();
                }

            }
            else
            {
                if (txtNombreUsuario.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || cbGeneroUsuario.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    decimal nuevoIdUsuario = Convert.ToDecimal(usuariosTableAdapter.NuevoIdDeUsuarioQuery());
                    usuariosTableAdapter.InsertQueryUsuarios(nuevoIdUsuario, txtNombreUsuario.Text, txtDireccion.Text, txtTelefono.Text, cbGeneroUsuario.Text);
                    this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
                    txtIdUsuario.Text = "";
                    txtNombreUsuario.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    cbGeneroUsuario.Text = "";

                    txtIdUsuario.Focus();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {
                MessageBox.Show("Ingresa el Id del usuario que deseas eliminar");
            }
            else
            {
                if (usuariosTableAdapter.ExisteUsuarioConIdUsuario(Convert.ToDecimal(txtIdUsuario.Text)) > 0)
                {
                    usuariosTableAdapter.DeleteQueryUsuarios(Convert.ToDecimal(txtIdUsuario.Text));
                    this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
                    txtIdUsuario.Text = "";
                    txtNombreUsuario.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                    cbGeneroUsuario.Text = "";

                    txtIdUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("El usuario que quieres eliminar no existe en la Base de Datos");
                }
            }
        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                this.usuariosTableAdapter.Fill(this.usuariosDataSet1.Usuarios);
            }
            else
            { 
                usuariosTableAdapter.FillDGVporNombreDeUsuario(this.usuariosDataSet1.Usuarios, txtNombreUsuario.Text);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            new Usuarios.GenerarReporteUsuario().Show();
        }
    }
}
