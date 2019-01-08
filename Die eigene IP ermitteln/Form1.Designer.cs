namespace Die_eigene_IP_ermitteln
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ip_aktual = new System.Windows.Forms.Button();
            this.lbl_anzge = new System.Windows.Forms.Label();
            this.btn_Kopie_ablge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ip_aktual
            // 
            this.btn_ip_aktual.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ip_aktual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ip_aktual.Location = new System.Drawing.Point(12, 12);
            this.btn_ip_aktual.Name = "btn_ip_aktual";
            this.btn_ip_aktual.Size = new System.Drawing.Size(150, 35);
            this.btn_ip_aktual.TabIndex = 0;
            this.btn_ip_aktual.Text = "IP Aktualisieren";
            this.btn_ip_aktual.UseVisualStyleBackColor = true;
            this.btn_ip_aktual.Click += new System.EventHandler(this.Btn_ip_aktual_Click);
            // 
            // lbl_anzge
            // 
            this.lbl_anzge.AutoSize = true;
            this.lbl_anzge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anzge.Location = new System.Drawing.Point(185, 19);
            this.lbl_anzge.Name = "lbl_anzge";
            this.lbl_anzge.Size = new System.Drawing.Size(100, 20);
            this.lbl_anzge.TabIndex = 1;
            this.lbl_anzge.Text = "IP-Anzeige";
            // 
            // btn_Kopie_ablge
            // 
            this.btn_Kopie_ablge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Kopie_ablge.Enabled = false;
            this.btn_Kopie_ablge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kopie_ablge.Location = new System.Drawing.Point(12, 63);
            this.btn_Kopie_ablge.Name = "btn_Kopie_ablge";
            this.btn_Kopie_ablge.Size = new System.Drawing.Size(242, 35);
            this.btn_Kopie_ablge.TabIndex = 3;
            this.btn_Kopie_ablge.Text = "IP Kopieren->ZwAblge. ";
            this.btn_Kopie_ablge.UseVisualStyleBackColor = true;
            this.btn_Kopie_ablge.Click += new System.EventHandler(this.Btn_Kopie_ablge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 124);
            this.Controls.Add(this.btn_Kopie_ablge);
            this.Controls.Add(this.lbl_anzge);
            this.Controls.Add(this.btn_ip_aktual);
            this.Name = "Form1";
            this.Text = "Meine IP ist ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ip_aktual;
        private System.Windows.Forms.Label lbl_anzge;
        private System.Windows.Forms.Button btn_Kopie_ablge;
    }
}

