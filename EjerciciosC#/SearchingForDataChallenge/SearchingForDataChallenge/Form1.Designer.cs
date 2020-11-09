namespace SearchingForDataChallenge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusquedaLabel = new System.Windows.Forms.Label();
            this.txtBusquedaLabelBox = new System.Windows.Forms.TextBox();
            this.ResultadosBox = new System.Windows.Forms.ListBox();
            this.LabelResultados = new System.Windows.Forms.Label();
            this.BuscarButt = new System.Windows.Forms.Button();
            this.TelefonButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBusquedaLabel
            // 
            this.txtBusquedaLabel.AutoSize = true;
            this.txtBusquedaLabel.Location = new System.Drawing.Point(434, 33);
            this.txtBusquedaLabel.Name = "txtBusquedaLabel";
            this.txtBusquedaLabel.Size = new System.Drawing.Size(95, 32);
            this.txtBusquedaLabel.TabIndex = 0;
            this.txtBusquedaLabel.Text = "Buscar: ";
            // 
            // txtBusquedaLabelBox
            // 
            this.txtBusquedaLabelBox.Location = new System.Drawing.Point(535, 33);
            this.txtBusquedaLabelBox.Name = "txtBusquedaLabelBox";
            this.txtBusquedaLabelBox.Size = new System.Drawing.Size(376, 39);
            this.txtBusquedaLabelBox.TabIndex = 1;
            this.txtBusquedaLabelBox.TextChanged += new System.EventHandler(this.cambiText);
            // 
            // ResultadosBox
            // 
            this.ResultadosBox.FormattingEnabled = true;
            this.ResultadosBox.ItemHeight = 32;
            this.ResultadosBox.Location = new System.Drawing.Point(12, 128);
            this.ResultadosBox.Name = "ResultadosBox";
            this.ResultadosBox.Size = new System.Drawing.Size(1250, 260);
            this.ResultadosBox.TabIndex = 2;
            // 
            // LabelResultados
            // 
            this.LabelResultados.AutoSize = true;
            this.LabelResultados.Location = new System.Drawing.Point(12, 93);
            this.LabelResultados.Name = "LabelResultados";
            this.LabelResultados.Size = new System.Drawing.Size(140, 32);
            this.LabelResultados.TabIndex = 0;
            this.LabelResultados.Text = "Resultados: ";
            // 
            // BuscarButt
            // 
            this.BuscarButt.Location = new System.Drawing.Point(410, 394);
            this.BuscarButt.Name = "BuscarButt";
            this.BuscarButt.Size = new System.Drawing.Size(138, 41);
            this.BuscarButt.TabIndex = 3;
            this.BuscarButt.Text = "Buscar";
            this.BuscarButt.UseVisualStyleBackColor = true;
            this.BuscarButt.Click += new System.EventHandler(this.BuscarButt_Click);
            // 
            // TelefonButt
            // 
            this.TelefonButt.Location = new System.Drawing.Point(589, 394);
            this.TelefonButt.Name = "TelefonButt";
            this.TelefonButt.Size = new System.Drawing.Size(322, 41);
            this.TelefonButt.TabIndex = 3;
            this.TelefonButt.Text = "Buscar Numero de Telefono";
            this.TelefonButt.UseVisualStyleBackColor = true;
            this.TelefonButt.Click += new System.EventHandler(this.TelefonButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 468);
            this.Controls.Add(this.TelefonButt);
            this.Controls.Add(this.BuscarButt);
            this.Controls.Add(this.LabelResultados);
            this.Controls.Add(this.ResultadosBox);
            this.Controls.Add(this.txtBusquedaLabelBox);
            this.Controls.Add(this.txtBusquedaLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Buscador de solucion de datos ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtBusquedaLabel;
        private System.Windows.Forms.TextBox txtBusquedaLabelBox;
        private System.Windows.Forms.ListBox ResultadosBox;
        private System.Windows.Forms.Label LabelResultados;
        private System.Windows.Forms.Button BuscarButt;
        private System.Windows.Forms.Button TelefonButt;
    }
}

