using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogisticData
{
    public partial class OutcomeGoods : Form
    {
        public OutcomeGoods()
        {
            InitializeComponent();
        }

        private void OutcomeGoods_Load(object sender, EventArgs e)
        {
           DisplayDataOut();
            DisplayData();
        }

        private void dgLogistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgLogistic.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgLogistic.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnit.Text = dgLogistic.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateEntry.Text = dgLogistic.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        public void DisplayData()
        {
            dgLogistic.Rows.Clear();
            var lines = File.ReadAllLines("tbIncoming_Goods.txt");
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    var cellarry = cellValues.Split('~');
                    if (cellarry.Length == dgLogistic.Columns.Count)
                        dgLogistic.Rows.Add(cellarry);
                }

            }
        }

        public void remaining_stock()
        {
            if ((txtUnit.Text == "") || (txtOutcome.Text == ""))
            {
                txtSisa.Text = "";
            }


            else if ((int.Parse(txtUnit.Text)<0) || (int.Parse(txtOutcome.Text)<0))
            {
               txtSisa.Text = "0";
            }

            else if (int.Parse(txtOutcome.Text) > int.Parse(txtUnit.Text))
            {
                txtSisa.Text = "Invalid Input !";
            }

            else
            {
                txtSisa.Text = Convert.ToString(int.Parse(txtUnit.Text) - int.Parse(txtOutcome.Text));
            }
        }

        private void txtOutcome_TextChanged(object sender, EventArgs e)
        {
            remaining_stock();
        }

        private void btnSaveOut_Click(object sender, EventArgs e)
        {
            if (txtSisa.Text == "Invalid Input !")
            {
                MessageBox.Show("Data Invalid !");
            }

            else
            {
                FileStream fs = new FileStream("tbOutcomes_Goods.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txtCode.Text + "~" + txtOutcome.Text + "~" + dateTimeOut.Text+ "~" + txtSisa.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("Data has been saved");
                DisplayDataOut();
                DisplayData();
            }
        }

        public void DisplayDataOut()
        {
            dgOutCome.Rows.Clear();
            var lines = File.ReadAllLines("tbOutcomes_Goods.txt");
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    var cellarry = cellValues.Split('~');
                    if (cellarry.Length == dgOutCome.Columns.Count)
                        dgOutCome.Rows.Add(cellarry);
                }

            }
        }

        private void btnExitOut_Click(object sender, EventArgs e)
        {
            MenuLogistic frm = new MenuLogistic();
            frm.Show();
            this.Hide();
        }

        private void dgOutCome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgOutCome.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOutcome.Text = dgOutCome.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimeOut.Text = dgOutCome.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSisa.Text = dgOutCome.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btndispOut_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
