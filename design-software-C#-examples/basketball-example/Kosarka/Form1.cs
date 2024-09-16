using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosarka
{
    public partial class Form1 : Form
    {
        private FKosarka fdb = new FKosarka();
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            ConnectionDB cdb = new ConnectionDB();
            dodajUtakmiceDataGridView();
        }

        public void dodajUtakmiceDataGridView()
        {
            utakmiceGrid.Rows.Clear();
            List<Utakmica> utakmice = fdb.SveUtakmice();

            foreach(Utakmica u in utakmice)
            {
                DataGridViewRow row = (DataGridViewRow)utakmiceGrid.Rows[0].Clone();
                row.Tag = u;
                row.Cells[0].Value = u.pocetak;
                row.Cells[1].Value = u.domacin;
                row.Cells[2].Value = u.gost;
                row.Cells[3].Value = u.rezultat;

                utakmiceGrid.Rows.Add(row);
            }

        }

        private void UtakmicaTim()
        {
            
            Utakmica u = (Utakmica)utakmiceGrid.SelectedRows[0].Tag as Utakmica;
            Tim t = new Tim(u.idEkipeDomacina, u.idEkipeGosta, u.domacin, u.gost);

            timBox.Items.Clear();
            
            timBox.Items.Add(t.doamcin.ToString());
            timBox.Items.Add(t.gost.ToString());
            
            timBox.SelectedIndex = 0;

            ucitajIgraceTima();
        }

        private void ucitajIgraceTima(int idTIma)
        {
            igracBox.Items.Clear();

            Tim t = (Tim)timBox.SelectedItem;
            Utakmica u = (Utakmica)utakmiceGrid.SelectedRows[0].Tag as Utakmica;
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UcitajUtakmicu_Click(object sender, EventArgs e)
        {
            UtakmicaTim();
        }
    }
}
