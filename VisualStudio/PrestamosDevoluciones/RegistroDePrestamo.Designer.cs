namespace Biblioteca4
{
    partial class RegistroDePrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.cbFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNumeroAdquisicion = new System.Windows.Forms.TextBox();
            this.txtBibliotecario = new System.Windows.Forms.TextBox();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prestamosDevoluciones = new Biblioteca4.PrestamosDevoluciones();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblTresPrestamos = new System.Windows.Forms.Label();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.txtFechaDev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(414, 429);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(210, 28);
            this.btnRegistrar.TabIndex = 47;
            this.btnRegistrar.Text = "Registrar Prestamo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuario.AutoSize = true;
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnUsuario.Enabled = false;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(476, 344);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(124, 28);
            this.btnUsuario.TabIndex = 46;
            this.btnUsuario.Text = "Registrar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibro.AutoSize = true;
            this.btnLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnLibro.Enabled = false;
            this.btnLibro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(476, 202);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(124, 28);
            this.btnLibro.TabIndex = 45;
            this.btnLibro.Text = "Registrar Libro";
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.BtnLibro_Click);
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblPrestamos.Location = new System.Drawing.Point(228, 17);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(167, 22);
            this.lblPrestamos.TabIndex = 44;
            this.lblPrestamos.Text = "Registro Prestamos";
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Enabled = false;
            this.txtFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFechaPrestamo.Location = new System.Drawing.Point(468, 69);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(135, 22);
            this.txtFechaPrestamo.TabIndex = 43;
            // 
            // cbFechaDevolucion
            // 
            this.cbFechaDevolucion.Location = new System.Drawing.Point(214, 380);
            this.cbFechaDevolucion.Name = "cbFechaDevolucion";
            this.cbFechaDevolucion.Size = new System.Drawing.Size(205, 20);
            this.cbFechaDevolucion.TabIndex = 42;
            this.cbFechaDevolucion.ValueChanged += new System.EventHandler(this.CbFechaDevolucion_ValueChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(256, 322);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(135, 22);
            this.txtNombreUsuario.TabIndex = 41;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdUsuario.Location = new System.Drawing.Point(256, 285);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(135, 22);
            this.txtIdUsuario.TabIndex = 40;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(214, 244);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 22);
            this.txtUsuario.TabIndex = 39;
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTitulo.Location = new System.Drawing.Point(256, 183);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(135, 22);
            this.txtTitulo.TabIndex = 38;
            // 
            // txtNumeroAdquisicion
            // 
            this.txtNumeroAdquisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumeroAdquisicion.Location = new System.Drawing.Point(214, 144);
            this.txtNumeroAdquisicion.Name = "txtNumeroAdquisicion";
            this.txtNumeroAdquisicion.Size = new System.Drawing.Size(205, 22);
            this.txtNumeroAdquisicion.TabIndex = 37;
            this.txtNumeroAdquisicion.TextChanged += new System.EventHandler(this.TxtNumeroAdquisicion_TextChanged);
            // 
            // txtBibliotecario
            // 
            this.txtBibliotecario.Enabled = false;
            this.txtBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBibliotecario.Location = new System.Drawing.Point(199, 68);
            this.txtBibliotecario.Name = "txtBibliotecario";
            this.txtBibliotecario.Size = new System.Drawing.Size(135, 22);
            this.txtBibliotecario.TabIndex = 36;
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Enabled = false;
            this.txtIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdPrestamo.Location = new System.Drawing.Point(43, 65);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(48, 22);
            this.txtIdPrestamo.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(32, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha a Devolver";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(92, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nombre de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(97, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(32, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID o Nombre de Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(97, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(32, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Número de Adquisición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(341, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(97, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bibliotecario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            //this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.Red;
            this.lblDisponible.Location = new System.Drawing.Point(238, 206);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(180, 19);
            this.lblDisponible.TabIndex = 48;
            this.lblDisponible.Text = "* Libro prestado * ";
            this.lblDisponible.Visible = false;
            // 
            // lblTresPrestamos
            // 
            this.lblTresPrestamos.AutoSize = true;
            this.lblTresPrestamos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTresPrestamos.ForeColor = System.Drawing.Color.Red;
            this.lblTresPrestamos.Location = new System.Drawing.Point(194, 345);
            this.lblTresPrestamos.Name = "lblTresPrestamos";
            this.lblTresPrestamos.Size = new System.Drawing.Size(261, 19);
            this.lblTresPrestamos.TabIndex = 49;
            this.lblTresPrestamos.Text = "* Usuario con 3 prestamos * ";
            this.lblTresPrestamos.Visible = false;
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoPrestamo.AutoSize = true;
            this.btnNuevoPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnNuevoPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPrestamo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(185, 429);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(210, 28);
            this.btnNuevoPrestamo.TabIndex = 50;
            this.btnNuevoPrestamo.Text = "Nuevo Prestamo";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = false;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.BtnNuevoPrestamo_Click);
            // 
            // txtFechaDev
            // 
            this.txtFechaDev.Location = new System.Drawing.Point(444, 382);
            this.txtFechaDev.Name = "txtFechaDev";
            this.txtFechaDev.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDev.TabIndex = 51;
            // 
            // RegistroDePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 466);
            this.Controls.Add(this.txtFechaDev);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Controls.Add(this.lblTresPrestamos);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.cbFechaDevolucion);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumeroAdquisicion);
            this.Controls.Add(this.txtBibliotecario);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroDePrestamo";
            this.Text = "RegistroDePrestamo";
            this.Load += new System.EventHandler(this.RegistroDePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.DateTimePicker cbFechaDevolucion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNumeroAdquisicion;
        private System.Windows.Forms.TextBox txtBibliotecario;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PrestamosDevoluciones prestamosDevoluciones;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private PrestamosDevolucionesTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private PrestamosDevolucionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblTresPrestamos;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.TextBox txtFechaDev;
    }
}