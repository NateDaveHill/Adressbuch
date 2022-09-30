using System.ComponentModel;
using Adressverwaltung;

namespace MainWindow
{
    public partial class MainWindow : Form
    {
        private Adressbuch adressbuch;
        public BindingList<Adressdaten> AdressdatenList { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Adressbuch.AdressTypeEnum)))
            {
                cbxAdressType.Items.Add(item);
            }

            Refresh();
        }

        private void Refresh()
        {
            lsbDisplayAdressbook.DataSource = AdressdatenList;
            dgvDisplayAdressbook.DataSource = AdressdatenList;
        }

        private void cbxAdressType_SelectedIndexChanged(object sender, EventArgs e)
        { 
            adressbuch = new Adressbuch(cbxAdressType.SelectedItem.GetType());
        }

        private void btnAddAdressClick(object sender, EventArgs e)
        {
            AdressdatenList.Add(new Adressdaten()
            {
                Type = cbxAdressType.SelectedItem.ToString(),
                Firma = txtFirma.Text,
                Vorname = txtVorname.Text,
                Nachname = txtNachname.Text,
                Adresse = txtAdresse.Text,
                PLZ = txtPLZ.Text,
                Ort = txtOrt.Text
            });

            txtFirma.Clear();
            txtVorname.Clear();
            txtNachname.Clear();
            txtAdresse.Clear();
            txtPLZ.Clear();
            txtOrt.Clear();
            Refresh();
        }


    }
}