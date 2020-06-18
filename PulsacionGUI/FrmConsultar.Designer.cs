namespace PulsacionGUI
{
    partial class FrmConsultar
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNumeroPersonas = new System.Windows.Forms.Button();
            this.btnTotalPulsaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltarGenero = new System.Windows.Forms.ComboBox();
            this.dtgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGenerarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(537, 54);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNumeroPersonas
            // 
            this.btnNumeroPersonas.Location = new System.Drawing.Point(12, 364);
            this.btnNumeroPersonas.Name = "btnNumeroPersonas";
            this.btnNumeroPersonas.Size = new System.Drawing.Size(132, 23);
            this.btnNumeroPersonas.TabIndex = 2;
            this.btnNumeroPersonas.Text = "Numero de personas";
            this.btnNumeroPersonas.UseVisualStyleBackColor = true;
            this.btnNumeroPersonas.Click += new System.EventHandler(this.btnNumeroPersonas_Click);
            // 
            // btnTotalPulsaciones
            // 
            this.btnTotalPulsaciones.Location = new System.Drawing.Point(150, 364);
            this.btnTotalPulsaciones.Name = "btnTotalPulsaciones";
            this.btnTotalPulsaciones.Size = new System.Drawing.Size(107, 23);
            this.btnTotalPulsaciones.TabIndex = 3;
            this.btnTotalPulsaciones.Text = "Total pulsaciones";
            this.btnTotalPulsaciones.UseVisualStyleBackColor = true;
            this.btnTotalPulsaciones.Click += new System.EventHandler(this.btnTotalPulsaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtar por genero";
            // 
            // cmbFiltarGenero
            // 
            this.cmbFiltarGenero.DropDownWidth = 80;
            this.cmbFiltarGenero.FormattingEnabled = true;
            this.cmbFiltarGenero.Items.AddRange(new object[] {
            "SELECCIONE",
            "F",
            "M"});
            this.cmbFiltarGenero.Location = new System.Drawing.Point(121, 56);
            this.cmbFiltarGenero.Name = "cmbFiltarGenero";
            this.cmbFiltarGenero.Size = new System.Drawing.Size(97, 21);
            this.cmbFiltarGenero.TabIndex = 5;
            this.cmbFiltarGenero.Tag = "";
            this.cmbFiltarGenero.Text = "SELECCIONE";
            this.cmbFiltarGenero.SelectedIndexChanged += new System.EventHandler(this.cmbFiltarGenero_SelectedIndexChanged);
            // 
            // dtgvPersonas
            // 
            this.dtgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPersonas.Location = new System.Drawing.Point(12, 83);
            this.dtgvPersonas.Name = "dtgvPersonas";
            this.dtgvPersonas.ReadOnly = true;
            this.dtgvPersonas.RowHeadersVisible = false;
            this.dtgvPersonas.Size = new System.Drawing.Size(600, 275);
            this.dtgvPersonas.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(456, 54);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGenerarArchivo
            // 
            this.btnGenerarArchivo.Location = new System.Drawing.Point(375, 54);
            this.btnGenerarArchivo.Name = "btnGenerarArchivo";
            this.btnGenerarArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarArchivo.TabIndex = 8;
            this.btnGenerarArchivo.Text = "Generar";
            this.btnGenerarArchivo.UseVisualStyleBackColor = true;
            this.btnGenerarArchivo.Click += new System.EventHandler(this.btnGenerarArchivo_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnGenerarArchivo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtgvPersonas);
            this.Controls.Add(this.cmbFiltarGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTotalPulsaciones);
            this.Controls.Add(this.btnNumeroPersonas);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNumeroPersonas;
        private System.Windows.Forms.Button btnTotalPulsaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltarGenero;
        private System.Windows.Forms.DataGridView dtgvPersonas;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGenerarArchivo;
    }
}