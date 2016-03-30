using MagazinCommon.model;
using MagazinDeElectronice.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinDeElectronice.ui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Boolean isAscending=true;

        private void refreshProduse()
        {
            string categorie = categoriiDataGridView.CurrentCell.Value.ToString();
            var produse = controller.getProduseFilteredByCategorie(categorie);
            if (isAscending == true)
            {
                produse.Sort(new Comparison<Produs>(ascending));
            }
            else
            {
                produse.Sort(new Comparison<Produs>(descending));
            }
            produseDataGridView.Rows.Clear();
            foreach (var produs in produse)
                produseDataGridView.Rows.Add(produs.Id, produs.Name, produs.Quantity,produs.Pret);
        }

        private int ascending(Produs p1, Produs p2)
        {
            return p1.Pret.CompareTo(p2.Pret);
        }

        private int descending(Produs p1, Produs p2)
        {
            return p2.Pret.CompareTo(p1.Pret);
        }


        private void adaugaButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> errorList = Validator.valideazaComanda(cantitateTextBox.Text, produseDataGridView.SelectedRows.Count);
                if (errorList.Count != 0)
                {
                    string errors = "";
                    foreach (string error in errorList)
                        errors += error;
                    throw new Exception(errors);
                }

                string idProdus = produseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                var nume = produseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                int cantitateComandata = Int32.Parse(cantitateTextBox.Text);
                int pret = Int32.Parse(produseDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                int total = pret * cantitateComandata;
                int cantitateExistenta= Int32.Parse(produseDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                if (cantitateExistenta<cantitateComandata)
                {
                    throw new Exception("nu exista atatea produse");
                }
                int totalCurent = Int32.Parse(totalTextBox.Text);
                totalCurent += total;

                totalTextBox.Text =totalCurent.ToString();
                //bool found= false;
                //foreach (DataGridViewRow row in cosDataGridView.Rows)
                //{
                //    if (row.Cells[0].Value != null)
                //    {
                //        //int id_produsGasit = Int32.Parse(row.Cells[0].Value.ToString());
                //        if (idProdus == row.Cells[3].Value= totalCurent.ToString())
                //        {
                //            row.Cells[0].Value
                //            found = true;
                //        }

                //    }

                //}


                //if(found==false)
                    cosDataGridView.Rows.Add(idProdus,nume, cantitateComandata, pret,total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //try
            //{
            //    List<string> errorList=Validator.valideazaComanda(cantitateTextBox.Text, produseDataGridView.SelectedRows.Count);
            //    if (errorList.Count != 0)
            //    {
            //        string errors = "";
            //        foreach (string error in errorList)
            //            errors+=error;
            //        MessageBox.Show(errors);
            //    }

            //    else
            //    {
            //        int id_produs = Int32.Parse(produseDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            //        int cantitate=Int32.Parse(cantitateTextBox.Text);
            //        if (controller.comanda(id_produs, cantitate))
            //        {
            //            refreshProduse();
            //        }
            //        else
            //            MessageBox.Show("Nu se poate efectua comanda.");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void categoriiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshProduse();
            if (produseDataGridView.RowCount == 1)
                MessageBox.Show("Nu exista produse");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isAscending = false;
            refreshProduse();
        }

        private void crescatorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAscending = true;
            refreshProduse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cosDataGridView.Rows)
            {
                if (row.Cells[2].Value != null&& row.Cells[0].Value != null)
                {
                    int cantitate = Int32.Parse(row.Cells[2].Value.ToString());
                    int id_produs = Int32.Parse(row.Cells[0].Value.ToString());
                    controller.comanda(id_produs, cantitate);
                    
                }
                
            }
            cosDataGridView.Rows.Clear();
            cosDataGridView.Refresh();
            totalTextBox.Text = "0";
            refreshProduse();

        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
