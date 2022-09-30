using System.ComponentModel;
using Adressverwaltung;

namespace MainWindow
{
    public partial class MainWindow : Form
    {
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
        private void cbxAdressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adressbuch adressbuch = new Adressbuch(cbxAdressType.SelectedItem.GetType());
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

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = AdressdatenList.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Adressdaten test = (Adressdaten)dgvDisplayAdressbook.CurrentRow.DataBoundItem;
            AdressdatenList.Remove(test);
        }
        private void Refresh()
        {
            dgvDisplayAdressbook.DataSource = AdressdatenList;
        }
    }
}