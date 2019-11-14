namespace PruebaBiblioteca1.Forms.Autores
{
    partial class FrmAutores
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
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresDataSet1 = new PruebaBiblioteca1.AutoresDataSet1();
            this.txtAutoresRegistrados = new System.Windows.Forms.Label();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autoresTableAdapter = new PruebaBiblioteca1.AutoresDataSet1TableAdapters.AutoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.AutoGenerateColumns = false;
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutores.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.nombreAutorDataGridViewTextBoxColumn});
            this.dgvAutores.DataSource = this.autoresBindingSource;
            this.dgvAutores.Location = new System.Drawing.Point(-3, -4);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(495, 340);
            this.dgvAutores.TabIndex = 0;
            this.dgvAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutores_CellContentClick);
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            // 
            // nombreAutorDataGridViewTextBoxColumn
            // 
            this.nombreAutorDataGridViewTextBoxColumn.DataPropertyName = "nombreAutor";
            this.nombreAutorDataGridViewTextBoxColumn.HeaderText = "nombreAutor";
            this.nombreAutorDataGridViewTextBoxColumn.Name = "nombreAutorDataGridViewTextBoxColumn";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.autoresDataSet1BindingSource;
            // 
            // autoresDataSet1BindingSource
            // 
            this.autoresDataSet1BindingSource.DataSource = this.autoresDataSet1;
            this.autoresDataSet1BindingSource.Position = 0;
            // 
            // autoresDataSet1
            // 
            this.autoresDataSet1.DataSetName = "AutoresDataSet1";
            this.autoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAutoresRegistrados
            // 
            this.txtAutoresRegistrados.AutoSize = true;
            this.txtAutoresRegistrados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoresRegistrados.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAutoresRegistrados.Location = new System.Drawing.Point(48, 13);
            this.txtAutoresRegistrados.Name = "txtAutoresRegistrados";
            this.txtAutoresRegistrados.Size = new System.Drawing.Size(192, 23);
            this.txtAutoresRegistrados.TabIndex = 1;
            this.txtAutoresRegistrados.Text = "Registro de Autores ";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdAutor.Location = new System.Drawing.Point(81, 78);
            this.txtIdAutor.MaxLength = 5;
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(186, 22);
            this.txtIdAutor.TabIndex = 2;
            this.txtIdAutor.TextChanged += new System.EventHandler(this.TxtIdAutor_TextChanged);
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombreAutor.Location = new System.Drawing.Point(81, 120);
            this.txtNombreAutor.MaxLength = 50;
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(186, 22);
            this.txtNombreAutor.TabIndex = 3;
            this.txtNombreAutor.TextChanged += new System.EventHandler(this.TxtNombreAutor_TextChanged);
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdAutor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdAutor.Location = new System.Drawing.Point(12, 84);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(31, 16);
            this.lblIdAutor.TabIndex = 4;
            this.lblIdAutor.Text = "ID :";
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreAutor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreAutor.Location = new System.Drawing.Point(12, 126);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(71, 16);
            this.lblNombreAutor.TabIndex = 5;
            this.lblNombreAutor.Text = "Nombre :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.txtAutoresRegistrados);
            this.panel1.Controls.Add(this.lblNombreAutor);
            this.panel1.Controls.Add(this.lblIdAutor);
            this.panel1.Controls.Add(this.txtNombreAutor);
            this.panel1.Controls.Add(this.txtIdAutor);
            this.panel1.Location = new System.Drawing.Point(494, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 373);
            this.panel1.TabIndex = 37;
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
            this.btnEliminar.Location = new System.Drawing.Point(29, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(228, 36);
            this.btnEliminar.TabIndex = 62;
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
            this.btnAceptar.Location = new System.Drawing.Point(29, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(228, 36);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(491, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 63;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAutores);
            this.Name = "FrmAutores";
            this.Text = "Autores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAutores_FormClosed);
            this.Load += new System.EventHandler(this.Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Label txtAutoresRegistrados;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Label lblIdAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource autoresDataSet1BindingSource;
        private AutoresDataSet1 autoresDataSet1;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private AutoresDataSet1TableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAutorDataGridViewTextBoxColumn;
    }
}