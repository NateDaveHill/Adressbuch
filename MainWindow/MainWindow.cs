using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Adressverwaltung;

namespace MainWindow
{
    public partial class MainWindow : Form
    {
        // Instanz von AdressdatenListe erstellen
        public BindingList<Adressdaten> AdressdatenList { get; set; } = new();


        public MainWindow()
        {
            InitializeComponent();

            // Durch jeden Eintrag in meinem Enum iterieren und die Combobox befüllen

            foreach (var item in Enum.GetValues(typeof(Adressbuch.AdressTypeEnum)))
            {
                cbxAdressType.Items.Add(item);
            }

            // Muster Einträge hard-coden

            AdressdatenList.Add(new Adressdaten()
            {
                Type = Adressbuch.AdressTypeEnum.Privat.ToString(),
                Firma = "MusterFirma",
                Vorname = "Max",
                Nachname = "Mustermann",
                Adresse = "Musterstraße 5",
                PLZ = "1234",
                Ort = "Musterort"
            });
            AdressdatenList.Add(new Adressdaten()
            {
                Type = Adressbuch.AdressTypeEnum.Lieferanten.ToString(),
                Firma = "MusterFirma2",
                Vorname = "Martin",
                Nachname = "Muster",
                Adresse = "Musterstraße 6",
                PLZ = "1234",
                Ort = "Musterort"
            });
            AdressdatenList.Add(new Adressdaten()
            {
                Type = Adressbuch.AdressTypeEnum.Kunden.ToString(),
                Firma = "MusterFirma3",
                Vorname = "Martina",
                Nachname = "Musterfrau",
                Adresse = "Musterstraße 7",
                PLZ = "1234",
                Ort = "Musterort"
            });

            Refresh();
        }

        // Hier wird die Auswahl von der Combobox in den Konstruktor von meinem adressbuch objekt weiter gegeben.
        private void cbxAdressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adressbuch adressbuch = new Adressbuch(cbxAdressType.SelectedItem.GetType());
        }

        // Methode für das befüllen von der AdressdatenListe und das bereinigen von den Textboxen.
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

        //Diese Methode zählt alle Einträge in meiner Liste
        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = AdressdatenList.Count.ToString();
        }

        //Methode für die Löschung von Dateneinträgen meiner Liste
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Adressdaten delEntry = (Adressdaten)dgvDisplayAdressbook.CurrentRow.DataBoundItem;
            AdressdatenList.Remove(delEntry);
        }

        //Das neuladen von meinem DataGridView
        private void Refresh()
        {
            dgvDisplayAdressbook.DataSource = AdressdatenList;
        }

        //Die Logik für mein Suchfeld
        private void txtSeachBar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSeachBar.Text))
            {
                Refresh();
            }
            else
            {
                var searchedEntryList = AdressdatenList.Where(x =>
                        x.Vorname == txtSeachBar.Text || x.Nachname == txtSeachBar.Text || x.Firma == txtSeachBar.Text || x.Type == txtSeachBar.Text)
                    .ToList();

                dgvDisplayAdressbook.DataSource = searchedEntryList;
            }
        }
    }
}