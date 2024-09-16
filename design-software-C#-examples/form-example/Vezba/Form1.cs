using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba
{
    public partial class Form1 : Form
    {
        private IFestivali db;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            ucitajBazu();
            radioButton2.Enabled = false;
        }

        public void init()
        {
            DajSveGodine();
            


        }

        private void ucitajBazu()
        {
            string baza = "";
            if (radioButton1.Checked)
                baza = "sql";
            if(radioButton2.Checked)
                baza = "nosql";

            db = FactoryConnection.Festval(baza);
            init();
        }

        private void DajSveGodine()
        {
            BoxGodine.Items.Clear();
            List<int> godine = db.DajGodine();

            foreach (int i in godine)
            {
                BoxGodine.Items.Add(i);
            }

            BoxGodine.SelectedIndex= 0;
            DajFestivaleTeGodine();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton1.Enabled = false;
            ucitajBazu();
        }

        private void DajFestivaleTeGodine()
        {
            festivaliBox.Items.Clear();

            int godina = (int)BoxGodine.SelectedItem;
            List <Festival> festivali = db.dajSveFestivaleTeGodine(godina);

            foreach(Festival f in festivali)
            {
                festivaliBox.Items.Add(f.naziv);
            }

            festivaliBox.SelectedIndex = 0;
            DajFestivaleNaDan();
        }

        private void DajFestivaleNaDan()
        {
            daniBox.Items.Clear();
            int godina = (int)BoxGodine.SelectedItem;
            Festival f = (Festival)festivaliBox.SelectedItem;

            List<int> dani = db.dajSveDane(godina, f);

            foreach(int d in dani)
            {
                daniBox.Items.Add(d);
            }

            daniBox.SelectedItem = 0;
            DajSvePosetioce();
        }

        private void DajSvePosetioce()
        {
            int godina = (int)BoxGodine.SelectedItem;
            Festival f = (Festival)(festivaliBox.SelectedItem);
            int dan = (int)daniBox.SelectedItem;

            List<Posetilac> posetilac = db.dajSvePosetioce(godina, f, dan);

            posetiociDataGrid.Rows.Clear();
            DataGridViewRow row = (DataGridViewRow)posetiociDataGrid.Rows[0].Clone();
            row.Tag = posetilac;
            foreach(Posetilac p in posetilac)
            {
                row.Cells[0].Value = p.ime;
                posetiociDataGrid.Rows.Add(row);
            }

        }


        private void PoseteFestivalima()
        {
            
            Posetilac pos = posetiociDataGrid.SelectedRows[0].Tag as Posetilac;
            int idPosetioca = (int)pos.idPosetioca;

            List<PoseteFestivalima> posete = db.dajSveFestivaleZaPosetioca(idPosetioca);
            
            foreach (PoseteFestivalima p in posete)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Tag = posete;

                row.Cells[0].Value = p.naziv;
                row.Cells[1].Value = p.godina;
                row.Cells[2].Value = p.dan;
                row.Cells[2].Value = p.cena;

                dataGridView1.Rows.Add(row);
            }
        }

        private void DajGodineFestivali()
        {
            List<int> godina = db.DajGodine();

            godinaBoxKarta.Items.Clear();

            foreach(int i in godina)
            {
                godinaBoxKarta.Items.Add(i);

            }
            DajFestivalKarta();
        }

        private void DajFestivalKarta()
        {
            int godina = (int)BoxGodine.SelectedIndex;
            List<Festival> festivali = db.dajSveFestivaleTeGodine(godina);

            festivalBoxKarta.Items.Clear();

            foreach(Festival f in festivali)
            {
                festivalBoxKarta.Items.Add(f.naziv.ToString());
            }
            DajPosetilacKarta();
            DajDaneKarta();
        }

        private void DajPosetilacKarta()
        {
            int godina = (int)godinaBoxKarta.SelectedIndex;
            int dan = (int)daniBoxKarta.SelectedIndex;
            Festival f = (Festival)festivalBoxKarta.SelectedItem;

            posetilacBoxKarta.Items.Clear();
            List<Posetilac> posetioci = db.dajSvePosetioce(godina, f , dan);

            foreach(Posetilac p in posetioci)
            {
                posetilacBoxKarta.Items.Add(p.ime);
            }
            DajDaneKarta();
        }

        private void DajDaneKarta()
        {
            int godina = (int)godinaBoxKarta.SelectedIndex;
            Festival f = (Festival)festivalBoxKarta.SelectedItem;
            List<int> dani = db.dajSveDane(godina, f);

            foreach(int d in dani)
            {
                daniBoxKarta.Items.Add(d);
            }
        }

        public void UpisCene()
        {
            unosCene.Text = string.Empty;
            int godina = (int)godinaBoxKarta.SelectedIndex;
            Festival f = (Festival)festivalBoxKarta.SelectedItem;
            Posetilac p = (Posetilac)posetilacBoxKarta.SelectedItem;
            int dan = (int)daniBoxKarta.SelectedIndex;
            int cena = int.Parse(unosCene.Text);
            db.cena(godina, f, p, dan, cena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
