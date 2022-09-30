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
            this.btnAddAdress = new System.Windows.Forms.Button();
            this.lsbDisplayAdressbook = new System.Windows.Forms.ListBox();
            this.dgvDisplayAdressbook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAdressbook)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAdressType
            // 
            this.cbxAdressType.FormattingEnabled = true;
            this.cbxAdressType.Location = new System.Drawing.Point(14, 31);
            this.cbxAdressType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxAdressType.Name = "cbxAdressType";
            this.cbxAdressType.Size = new System.Drawing.Size(138, 28);
            this.cbxAdressType.TabIndex = 0;
            this.cbxAdressType.SelectedIndexChanged += new System.EventHandler(this.cbxAdressType_SelectedIndexChanged);
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(14, 87);
            this.txtFirma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(369, 27);
            this.txtFirma.TabIndex = 1;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(14, 193);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(369, 27);
            this.txtVorname.TabIndex = 2;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(14, 291);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(369, 27);
            this.txtNachname.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(14, 137);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(369, 27);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(14, 347);
            this.txtPLZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(369, 27);
            this.txtPLZ.TabIndex = 5;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(14, 247);
            this.txtOrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(369, 27);
            this.txtOrt.TabIndex = 6;
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Location = new System.Drawing.Point(14, 421);
            this.btnAddAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(86, 31);
            this.btnAddAdress.TabIndex = 7;
            this.btnAddAdress.Text = "Save";
            this.btnAddAdress.UseVisualStyleBackColor = true;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAddAdressClick);
            // 
            // lsbDisplayAdressbook
            // 
            this.lsbDisplayAdressbook.FormattingEnabled = true;
            this.lsbDisplayAdressbook.ItemHeight = 20;
            this.lsbDisplayAdressbook.Location = new System.Drawing.Point(390, 267);
            this.lsbDisplayAdressbook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbDisplayAdressbook.Name = "lsbDisplayAdressbook";
            this.lsbDisplayAdressbook.Size = new System.Drawing.Size(261, 184);
            this.lsbDisplayAdressbook.TabIndex = 8;
            // 
            // dgvDisplayAdressbook
            // 
            this.dgvDisplayAdressbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAdressbook.Location = new System.Drawing.Point(389, 87);
            this.dgvDisplayAdressbook.Name = "dgvDisplayAdressbook";
            this.dgvDisplayAdressbook.RowHeadersWidth = 51;
            this.dgvDisplayAdressbook.RowTemplate.Height = 29;
            this.dgvDisplayAdressbook.Size = new System.Drawing.Size(262, 173);
            this.dgvDisplayAdressbook.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 481);
            this.Controls.Add(this.dgvDisplayAdressbook);
            this.Controls.Add(this.lsbDisplayAdressbook);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtPLZ);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.cbxAdressType);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Adressverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAdressbook)).EndInit();
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
        private Button btnAddAdress;
        private ListBox lsbDisplayAdressbook;
        private DataGridView dgvDisplayAdressbook;
    }
}