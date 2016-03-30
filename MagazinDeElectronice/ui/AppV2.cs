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
    public partial class AppV2 : Form
    {
        public AppV2()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazin_electroniceDataSet.produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.FillBy(this.magazin_electroniceDataSet.produse);
            // TODO: This line of code loads data into the 'magazin_electroniceDataSet.categorii' table. You can move, or remove it, as needed.
            this.categoriiTableAdapter.Fill(this.magazin_electroniceDataSet.categorii);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.RowCount==1)
                MessageBox.Show("Nu exista produse");
        }

        private void comandaButton_Click(object sender, EventArgs e)
        {
            //if (dataGridView2.SelectedRows.Count == 1)
            //{
            //    int id_produs = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            //    int cantitate;
            //    Boolean cantitateIsNumber = Int32.TryParse(cantitateTextBox.Text, out cantitate);
            //    if (!cantitateIsNumber)
            //        MessageBox.Show("Cantitatea trebuie sa fie numar");
            //    if (controller.comanda(id_produs, cantitate))
            //    {
            //        this.produseTableAdapter.FillBy(this.magazin_electroniceDataSet.produse);
            //    }
            //    else
            //        MessageBox.Show("Nu se poate efectua comanda.");


            //}
            //else
            //{
            //    MessageBox.Show("Selecteaza doar un produs!");
            //}
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                                int id_produs = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                                int cantitate;
                                Boolean cantitateIsNumber = Int32.TryParse(cantitateTextBox.Text, out cantitate);
                                if (!cantitateIsNumber)
                                    MessageBox.Show("Cantitatea trebuie sa fie numar");
                            if (controller.comanda(id_produs, cantitate))
                            {
                                    this.produseTableAdapter.FillBy(this.magazin_electroniceDataSet.produse);
                            }
                            else
                                    MessageBox.Show("Nu se poate efectua comanda.");


                 }
                 else
                 {
                       MessageBox.Show("Selecteaza doar un produs!");
                 }

            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            

        }


    }
}
