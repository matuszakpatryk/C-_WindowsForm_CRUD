using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            String today = DateTime.Today.ToString("dd-MM-yyyy");
            //label4.Text = today;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pmatuszakDataSet.sprzedaz' . Możesz go przenieść lub usunąć.
            this.sprzedazTableAdapter.Fill(this.pmatuszakDataSet.sprzedaz);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pmatuszakDataSet.produkt' . Możesz go przenieść lub usunąć.
            this.produktTableAdapter.Fill(this.pmatuszakDataSet.produkt);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pmatuszakDataSet.pracownik' . Możesz go przenieść lub usunąć.
            this.pracownikTableAdapter.Fill(this.pmatuszakDataSet.pracownik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pmatuszakDataSet.klient' . Możesz go przenieść lub usunąć.
            this.klientTableAdapter.Fill(this.pmatuszakDataSet.klient);

        }

        private void btnTak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
    }
}
