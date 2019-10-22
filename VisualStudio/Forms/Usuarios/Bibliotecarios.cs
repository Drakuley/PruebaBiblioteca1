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
    public partial class FrmBibliotecarios : Form
    {
        private TextBox txtIdBibliotecario;
        private ComboBox cbTurno;
        private Label label4;
        private TextBox txtContraseña;
        private Label direccion;
        private DataGridView dgvBibliotecarios;
        private Label Nombre;
        private TextBox txtConfirmarContraseña;
        private Label label1;
        private Panel panel1;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnAceptar;
        private Label txtAutoresRegistrados;
        private Panel panel2;
        private BibliotecariosDataSet1 bibliotecariosDataSet1;
        private BindingSource bibliotecariosBindingSource;
        private IContainer components;
        private BibliotecariosDataSet1TableAdapters.BibliotecariosTableAdapter bibliotecariosTableAdapter;
        private DataGridViewTextBoxColumn idBibliotecarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreBibliotecarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private TextBox txtNombreBibliotecario;

        public FrmBibliotecarios()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdBibliotecario = new System.Windows.Forms.TextBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.dgvBibliotecarios = new System.Windows.Forms.DataGridView();
            this.idBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliotecariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecariosDataSet1 = new PruebaBiblioteca1.BibliotecariosDataSet1();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombreBibliotecario = new System.Windows.Forms.TextBox();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAutoresRegistrados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bibliotecariosTableAdapter = new PruebaBiblioteca1.BibliotecariosDataSet1TableAdapters.BibliotecariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdBibliotecario
            // 
            this.txtIdBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBibliotecario.Location = new System.Drawing.Point(335, 342);
            this.txtIdBibliotecario.Name = "txtIdBibliotecario";
            this.txtIdBibliotecario.Size = new System.Drawing.Size(10, 22);
            this.txtIdBibliotecario.TabIndex = 39;
            this.txtIdBibliotecario.Visible = false;
            this.txtIdBibliotecario.TextChanged += new System.EventHandler(this.TxtIdBibliotecario_TextChanged);
            // 
            // cbTurno
            // 
            this.cbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.cbTurno.Location = new System.Drawing.Point(176, 123);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(170, 24);
            this.cbTurno.TabIndex = 37;
            this.cbTurno.Text = "Matutino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Turno:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(176, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(170, 22);
            this.txtContraseña.TabIndex = 35;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.direccion.ForeColor = System.Drawing.Color.White;
            this.direccion.Location = new System.Drawing.Point(3, 72);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(91, 16);
            this.direccion.TabIndex = 34;
            this.direccion.Text = "Contraseña:";
            // 
            // dgvBibliotecarios
            // 
            this.dgvBibliotecarios.AutoGenerateColumns = false;
            this.dgvBibliotecarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBibliotecarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvBibliotecarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBibliotecarioDataGridViewTextBoxColumn,
            this.nombreBibliotecarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.dgvBibliotecarios.DataSource = this.bibliotecariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBibliotecarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBibliotecarios.Location = new System.Drawing.Point(0, 1);
            this.dgvBibliotecarios.Name = "dgvBibliotecarios";
            this.dgvBibliotecarios.Size = new System.Drawing.Size(600, 460);
            this.dgvBibliotecarios.TabIndex = 33;
            // 
            // idBibliotecarioDataGridViewTextBoxColumn
            // 
            this.idBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "idBibliotecario";
            this.idBibliotecarioDataGridViewTextBoxColumn.HeaderText = "Id Bibliotecario";
            this.idBibliotecarioDataGridViewTextBoxColumn.Name = "idBibliotecarioDataGridViewTextBoxColumn";
            // 
            // nombreBibliotecarioDataGridViewTextBoxColumn
            // 
            this.nombreBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "nombreBibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.HeaderText = "Nombre Bibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.Name = "nombreBibliotecarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.Visible = false;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // bibliotecariosBindingSource
            // 
            this.bibliotecariosBindingSource.DataMember = "Bibliotecarios";
            this.bibliotecariosBindingSource.DataSource = this.bibliotecariosDataSet1;
            // 
            // bibliotecariosDataSet1
            // 
            this.bibliotecariosDataSet1.DataSetName = "BibliotecariosDataSet1";
            this.bibliotecariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(3, 44);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 16);
            this.Nombre.TabIndex = 32;
            this.Nombre.Text = "Nombre:";
            // 
            // txtNombreBibliotecario
            // 
            this.txtNombreBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBibliotecario.Location = new System.Drawing.Point(176, 39);
            this.txtNombreBibliotecario.Name = "txtNombreBibliotecario";
            this.txtNombreBibliotecario.Size = new System.Drawing.Size(170, 22);
            this.txtNombreBibliotecario.TabIndex = 31;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(176, 95);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '•';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(170, 22);
            this.txtConfirmarContraseña.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Confirmar Contraseña:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.txtConfirmarContraseña);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.cbTurno);
            this.panel1.Controls.Add(this.txtIdBibliotecario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAutoresRegistrados);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.direccion);
            this.panel1.Controls.Add(this.txtNombreBibliotecario);
            this.panel1.Location = new System.Drawing.Point(607, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 469);
            this.panel1.TabIndex = 59;
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
            this.btnReporte.Location = new System.Drawing.Point(10, 412);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(335, 36);
            this.btnReporte.TabIndex = 61;
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
            this.btnEliminar.Location = new System.Drawing.Point(182, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 36);
            this.btnEliminar.TabIndex = 60;
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
            this.btnAceptar.Location = new System.Drawing.Point(10, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(166, 36);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtAutoresRegistrados
            // 
            this.txtAutoresRegistrados.AutoSize = true;
            this.txtAutoresRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoresRegistrados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAutoresRegistrados.Location = new System.Drawing.Point(52, 8);
            this.txtAutoresRegistrados.Name = "txtAutoresRegistrados";
            this.txtAutoresRegistrados.Size = new System.Drawing.Size(248, 24);
            this.txtAutoresRegistrados.TabIndex = 38;
            this.txtAutoresRegistrados.Text = "Registro de Bibliotecarios";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(600, -43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 64;
            // 
            // bibliotecariosTableAdapter
            // 
            this.bibliotecariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBibliotecarios
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBibliotecarios);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBibliotecarios";
            this.Text = "Bibliotecarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBibliotecarios_FormClosed);
            this.Load += new System.EventHandler(this.FrmBibliotecarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void FrmBibliotecarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecariosDataSet1.Bibliotecarios' Puede moverla o quitarla según sea necesario.
            this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
            cbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TxtIdBibliotecario_TextChanged(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtIdBibliotecario.Text, @"^\d+$") == false)
            //{
            //    //MessageBox.Show("Ingrese ID númerico");
            //    txtIdBibliotecario.Text = "";
            //}
            if (txtIdBibliotecario.Text == "")
            {
                this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
                txtIdBibliotecario.Text = "";
                txtNombreBibliotecario.Text = "";
                txtContraseña.Text = "";
                txtConfirmarContraseña.Text = "";
                cbTurno.Text = "";

                txtIdBibliotecario.Focus();
                btnAceptar.Text = "Aceptar";

            }
            else if (bibliotecariosTableAdapter.ExisteBibliotecarioConIdBibliotecario(Convert.ToDecimal(txtIdBibliotecario.Text)) > 0)
            {
                this.bibliotecariosTableAdapter.FillDGVporIdBibliotecario(this.bibliotecariosDataSet1.Bibliotecarios, Convert.ToDecimal(txtIdBibliotecario.Text));
                btnAceptar.Text = "Modificar";
                txtNombreBibliotecario.Text = dgvBibliotecarios.CurrentRow.Cells[1].Value.ToString();
                cbTurno.Text = dgvBibliotecarios.CurrentRow.Cells[2].FormattedValue.ToString();
            }
            else
            {
                btnAceptar.Text = "Registrar";
                txtIdBibliotecario.Text = "";
                txtNombreBibliotecario.Text = "";
                txtContraseña.Text = "";
                txtConfirmarContraseña.Text = "";
                cbTurno.Text = "";
                this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Modificar")
            {
                if (txtIdBibliotecario.Text == "" || txtNombreBibliotecario.Text == "" || txtContraseña.Text == "" || txtConfirmarContraseña.Text == "" || cbTurno.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    if (txtContraseña.Text == txtConfirmarContraseña.Text)
                    {
                        bibliotecariosTableAdapter.UpdateQueryBibliotecarios(Convert.ToDecimal(txtIdBibliotecario.Text), txtNombreBibliotecario.Text, txtConfirmarContraseña.Text, cbTurno.Text, Convert.ToDecimal(txtIdBibliotecario.Text));
                        this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
                        txtIdBibliotecario.Text = "";
                        txtNombreBibliotecario.Text = "";
                        txtContraseña.Text = "";
                        txtConfirmarContraseña.Text = "";
                        cbTurno.Text = "";

                        txtIdBibliotecario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }

            }
            else
            {
                if (txtNombreBibliotecario.Text == "" || txtContraseña.Text == "" || txtConfirmarContraseña.Text == "" || cbTurno.Text == "")
                {
                    MessageBox.Show("Faltan Campos por llenar");
                }
                else
                {
                    //if (bibliotecariosTableAdapter.ExisteBibliotecarioConIdBibliotecario(Convert.ToDecimal(txtIdBibliotecario.Text)) > 0 || txtIdBibliotecario.Text == "")
                    //{
                    //    MessageBox.Show("El bibliotecario que quieres registrar ya existe en la Base de Datos");
                    //}
                    //else
                    //{
                        if (txtContraseña.Text == txtConfirmarContraseña.Text)
                        {
                            decimal nuevoIdBibliotecario = Convert.ToDecimal(bibliotecariosTableAdapter.NuevoIdDeBibliotecarioQuery());
                            bibliotecariosTableAdapter.InsertQueryBibliotecarios(nuevoIdBibliotecario, txtNombreBibliotecario.Text, txtConfirmarContraseña.Text, cbTurno.Text);
                            this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
                            //txtIdBibliotecario.Text = "";
                            txtNombreBibliotecario.Text = "";
                            txtContraseña.Text = "";
                            txtConfirmarContraseña.Text = "";
                            cbTurno.Text = "";

                            txtIdBibliotecario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden");
                        }
                    //}
                }


            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdBibliotecario.Text == "")
            {
                MessageBox.Show("Ingresa el Id del bibliotecario que deseas eliminar");
            }
            else
            {
                if (bibliotecariosTableAdapter.ExisteBibliotecarioConIdBibliotecario(Convert.ToDecimal(txtIdBibliotecario.Text)) > 0)
                {
                    bibliotecariosTableAdapter.DeleteQueryBibliotecarios(Convert.ToDecimal(txtIdBibliotecario.Text));
                    this.bibliotecariosTableAdapter.Fill(this.bibliotecariosDataSet1.Bibliotecarios);
                    txtIdBibliotecario.Text = "";
                    txtNombreBibliotecario.Text = "";
                    txtContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    cbTurno.Text = "";

                    txtIdBibliotecario.Focus();
                }
                else
                {
                    MessageBox.Show("El bibliotecario que quieres eliminar no existe en la Base de Datos");
                }
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            new Usuarios.GenerarReporteDeBibliotecarios().Show();
            this.Hide();
        }

        private void FrmBibliotecarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmMenú().Show();
        }
    }
}
