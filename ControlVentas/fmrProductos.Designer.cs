namespace ControlVentas
{
    partial class fmrProductos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatos = new ControlVentas.dsDatos();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rpvProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtProductosTableAdapter = new ControlVentas.dsDatosTableAdapters.dtProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProductosBindingSource
            // 
            this.dtProductosBindingSource.DataMember = "dtProductos";
            this.dtProductosBindingSource.DataSource = this.dsDatos;
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "dsDatos";
            this.dsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(253, 17);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(112, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(413, 17);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(112, 20);
            this.dtpFin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(531, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Generar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rpvProductos
            // 
            reportDataSource1.Name = "dsProductos";
            reportDataSource1.Value = this.dtProductosBindingSource;
            this.rpvProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvProductos.LocalReport.ReportEmbeddedResource = "ControlVentas.rptProductos.rdlc";
            this.rpvProductos.Location = new System.Drawing.Point(11, 43);
            this.rpvProductos.Name = "rpvProductos";
            this.rpvProductos.ServerReport.BearerToken = null;
            this.rpvProductos.Size = new System.Drawing.Size(777, 395);
            this.rpvProductos.TabIndex = 5;
            // 
            // dtProductosTableAdapter
            // 
            this.dtProductosTableAdapter.ClearBeforeFill = true;
            // 
            // fmrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.rpvProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "fmrProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Productos";
            this.Load += new System.EventHandler(this.fmrProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rpvProductos;
        private System.Windows.Forms.BindingSource dtProductosBindingSource;
        private dsDatos dsDatos;
        private dsDatosTableAdapters.dtProductosTableAdapter dtProductosTableAdapter;
    }
}