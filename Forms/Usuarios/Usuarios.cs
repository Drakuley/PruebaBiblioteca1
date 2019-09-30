using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms
{
    public partial class Usuarios : Form
    {
        private Button btnGenerarReporteUsuario;
        private Label label6;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtIdUsuario;
        private Label label5;
        private ComboBox cbGeneroUsuario;
        private Label label4;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label direccion;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn DireccionUsuario;
        private DataGridViewTextBoxColumn TelefonoUsuario;
        private DataGridViewTextBoxColumn GeneroUsuario;
        private Label Nombre;
        private TextBox txtNombreUsuario;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnGenerarReporteUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGeneroUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarReporteUsuario
            // 
            this.btnGenerarReporteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteUsuario.Location = new System.Drawing.Point(620, 406);
            this.btnGenerarReporteUsuario.Name = "btnGenerarReporteUsuario";
            this.btnGenerarReporteUsuario.Size = new System.Drawing.Size(260, 48);
            this.btnGenerarReporteUsuario.TabIndex = 46;
            this.btnGenerarReporteUsuario.Text = "Generar Reporte";
            this.btnGenerarReporteUsuario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Usuarios Registrados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(751, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 36);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(620, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 36);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(701, 39);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtIdUsuario.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(635, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID:";
            // 
            // cbGeneroUsuario
            // 
            this.cbGeneroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroUsuario.FormattingEnabled = true;
            this.cbGeneroUsuario.Location = new System.Drawing.Point(701, 143);
            this.cbGeneroUsuario.Name = "cbGeneroUsuario";
            this.cbGeneroUsuario.Size = new System.Drawing.Size(171, 24);
            this.cbGeneroUsuario.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(635, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(635, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(701, 117);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 22);
            this.txtTelefono.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(701, 91);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 22);
            this.txtDireccion.TabIndex = 36;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.SystemColors.Control;
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.ForeColor = System.Drawing.Color.Black;
            this.direccion.Location = new System.Drawing.Point(635, 92);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(68, 16);
            this.direccion.TabIndex = 35;
            this.direccion.Text = "Dirección:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUsuario,
            this.NombreUsuario,
            this.DireccionUsuario,
            this.TelefonoUsuario,
            this.GeneroUsuario});
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 39);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(606, 410);
            this.dgvUsuarios.TabIndex = 34;
            // 
            // IDUsuario
            // 
            this.IDUsuario.HeaderText = "ID Usuario";
            this.IDUsuario.Name = "IDUsuario";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            // 
            // DireccionUsuario
            // 
            this.DireccionUsuario.HeaderText = "Dirección";
            this.DireccionUsuario.Name = "DireccionUsuario";
            // 
            // TelefonoUsuario
            // 
            this.TelefonoUsuario.HeaderText = "Teléfono";
            this.TelefonoUsuario.Name = "TelefonoUsuario";
            // 
            // GeneroUsuario
            // 
            this.GeneroUsuario.HeaderText = "Género";
            this.GeneroUsuario.Name = "GeneroUsuario";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(635, 68);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 16);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(701, 65);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtNombreUsuario.TabIndex = 32;
            // 
            // Usuarios
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnGenerarReporteUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGeneroUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombreUsuario);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
