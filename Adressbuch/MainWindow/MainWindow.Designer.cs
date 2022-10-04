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
            this.dgvDisplayAdressbook = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeachBar = new System.Windows.Forms.TextBox();
            this.lblSuche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAdressbook)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAdressType
            // 
            this.cbxAdressType.FormattingEnabled = true;
            this.cbxAdressType.Location = new System.Drawing.Point(503, 25);
            this.cbxAdressType.Name = "cbxAdressType";
            this.cbxAdressType.Size = new System.Drawing.Size(311, 23);
            this.cbxAdressType.TabIndex = 0;
            this.cbxAdressType.SelectedIndexChanged += new System.EventHandler(this.cbxAdressType_SelectedIndexChanged);
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(16, 24);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(479, 23);
            this.txtFirma.TabIndex = 1;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(16, 65);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(479, 23);
            this.txtVorname.TabIndex = 2;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(16, 106);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(479, 23);
            this.txtNachname.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(16, 148);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(479, 23);
            this.txtAdresse.TabIndex = 4;
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(16, 229);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(479, 23);
            this.txtPLZ.TabIndex = 5;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(16, 189);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(479, 23);
            this.txtOrt.TabIndex = 6;
            // 
            // btnAddAdress
            // 
            this.btnAddAdress.Location = new System.Drawing.Point(503, 106);
            this.btnAddAdress.Name = "btnAddAdress";
            this.btnAddAdress.Size = new System.Drawing.Size(311, 23);
            this.btnAddAdress.TabIndex = 7;
            this.btnAddAdress.Text = "Save";
            this.btnAddAdress.UseVisualStyleBackColor = true;
            this.btnAddAdress.Click += new System.EventHandler(this.btnAddAdressClick);
            // 
            // dgvDisplayAdressbook
            // 
            this.dgvDisplayAdressbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAdressbook.Location = new System.Drawing.Point(16, 267);
            this.dgvDisplayAdressbook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplayAdressbook.Name = "dgvDisplayAdressbook";
            this.dgvDisplayAdressbook.RowHeadersWidth = 51;
            this.dgvDisplayAdressbook.RowTemplate.Height = 29;
            this.dgvDisplayAdressbook.Size = new System.Drawing.Size(798, 215);
            this.dgvDisplayAdressbook.TabIndex = 9;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(508, 189);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(110, 23);
            this.txtCount.TabIndex = 10;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(508, 229);
            this.btnCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(305, 22);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(311, 22);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adressbuchtyp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "PLZ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nachname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Vorname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Zähler:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSeachBar
            // 
            this.txtSeachBar.Location = new System.Drawing.Point(503, 69);
            this.txtSeachBar.Name = "txtSeachBar";
            this.txtSeachBar.Size = new System.Drawing.Size(315, 23);
            this.txtSeachBar.TabIndex = 21;
            this.txtSeachBar.TextChanged += new System.EventHandler(this.txtSeachBar_TextChanged);
            // 
            // lblSuche
            // 
            this.lblSuche.AutoSize = true;
            this.lblSuche.Location = new System.Drawing.Point(503, 51);
            this.lblSuche.Name = "lblSuche";
            this.lblSuche.Size = new System.Drawing.Size(39, 15);
            this.lblSuche.TabIndex = 22;
            this.lblSuche.Text = "Suche";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 498);
            this.Controls.Add(this.lblSuche);
            this.Controls.Add(this.txtSeachBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.dgvDisplayAdressbook);
            this.Controls.Add(this.btnAddAdress);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtPLZ);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.cbxAdressType);
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
        private DataGridView dgvDisplayAdressbook;
        private TextBox txtCount;
        private Button btnCount;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSeachBar;
        private Label lblSuche;
    }
}