using Adressverwaltung;

namespace MainWindow
{
    partial class MainWindow
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
            this.cbxAdressType = new System.Windows.Forms.ComboBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxAdressType
            // 
            this.cbxAdressType.FormattingEnabled = true;
            this.cbxAdressType.Items.AddRange(new object[] {
            Adressverwaltung.Adressbuch.AdressTypeEnum.Kunden,
            Adressverwaltung.Adressbuch.AdressTypeEnum.Lieferanten,
            Adressverwaltung.Adressbuch.AdressTypeEnum.Privat});
            this.cbxAdressType.Location = new System.Drawing.Point(12, 23);
            this.cbxAdressType.Name = "cbxAdressType";
            this.cbxAdressType.Size = new System.Drawing.Size(121, 23);
            this.cbxAdressType.TabIndex = 0;
            this.cbxAdressType.SelectedIndexChanged += new System.EventHandler(this.cbxAdressType_SelectedIndexChanged);
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(12, 65);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(323, 23);
            this.txtFirma.TabIndex = 1;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(12, 145);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(323, 23);
            this.txtVorname.TabIndex = 2;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(12, 218);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(323, 23);
            this.txtNachname.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(12, 103);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(323, 23);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(12, 260);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(323, 23);
            this.txtPLZ.TabIndex = 5;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(12, 185);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(323, 23);
            this.txtOrt.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtPLZ);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.cbxAdressType);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxAdressType;
        private TextBox txtFirma;
        private TextBox txtVorname;
        private TextBox txtNachname;
        private TextBox txtAdresse;
        private TextBox txtPLZ;
        private TextBox txtOrt;
    }
}