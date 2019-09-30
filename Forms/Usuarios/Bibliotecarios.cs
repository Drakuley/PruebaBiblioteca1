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
    public partial class Bibliotecarios : Form
    {
        private DataGridViewTextBoxColumn Turno;
        private Label label6;
        private DataGridViewTextBoxColumn NombreBibliotecario;
        private DataGridViewTextBoxColumn idBibliotecario;
        private TextBox txtIdBibliotecario;
        private Label label5;
        private ComboBox cbTurno;
        private Label label4;
        private TextBox txtContraseña;
        private Label direccion;
        private DataGridView dgvBibliotecarios;
        private DataGridViewTextBoxColumn Contraseña;
        private Label Nombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtNombreBibliotecario;

        public Bibliotecarios()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreBibliotecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBibliotecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdBibliotecario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.dgvBibliotecarios = new System.Windows.Forms.DataGridView();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombreBibliotecario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Bibliotecarios";
            // 
            // NombreBibliotecario
            // 
            this.NombreBibliotecario.HeaderText = "Nombre";
            this.NombreBibliotecario.Name = "NombreBibliotecario";
            // 
            // idBibliotecario
            // 
            this.idBibliotecario.HeaderText = "ID Bibliotecario";
            this.idBibliotecario.Name = "idBibliotecario";
            // 
            // txtIdBibliotecario
            // 
            this.txtIdBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBibliotecario.Location = new System.Drawing.Point(721, 40);
            this.txtIdBibliotecario.Name = "txtIdBibliotecario";
            this.txtIdBibliotecario.Size = new System.Drawing.Size(151, 22);
            this.txtIdBibliotecario.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(640, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID:";
            // 
            // cbTurno
            // 
            this.cbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Location = new System.Drawing.Point(721, 120);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(151, 24);
            this.cbTurno.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(640, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Turno:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(721, 92);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(151, 22);
            this.txtContraseña.TabIndex = 35;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.SystemColors.Control;
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.ForeColor = System.Drawing.Color.Black;
            this.direccion.Location = new System.Drawing.Point(640, 97);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(80, 16);
            this.direccion.TabIndex = 34;
            this.direccion.Text = "Contraseña:";
            // 
            // dgvBibliotecarios
            // 
            this.dgvBibliotecarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBibliotecarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBibliotecario,
            this.NombreBibliotecario,
            this.Contraseña,
            this.Turno});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBibliotecarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBibliotecarios.Location = new System.Drawing.Point(6, 40);
            this.dgvBibliotecarios.Name = "dgvBibliotecarios";
            this.dgvBibliotecarios.Size = new System.Drawing.Size(615, 410);
            this.dgvBibliotecarios.TabIndex = 33;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(640, 69);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 16);
            this.Nombre.TabIndex = 32;
            this.Nombre.Text = "Nombre:";
            // 
            // txtNombreBibliotecario
            // 
            this.txtNombreBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBibliotecario.Location = new System.Drawing.Point(721, 66);
            this.txtNombreBibliotecario.Name = "txtNombreBibliotecario";
            this.txtNombreBibliotecario.Size = new System.Drawing.Size(151, 22);
            this.txtNombreBibliotecario.TabIndex = 31;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(716, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(797, 426);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Bibliotecarios
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdBibliotecario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.dgvBibliotecarios);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombreBibliotecario);
            this.Name = "Bibliotecarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
