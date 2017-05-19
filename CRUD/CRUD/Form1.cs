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
            Autor autor = new Autor();
            String today = DateTime.Today.ToString("dd-MM-yyyy");
            label4.Text = today;
            autor.setLabelDate2(today);
        }

        private void kliencieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autor autorForm = new Autor();
            autorForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
