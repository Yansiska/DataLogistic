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
    public partial class REPORT : Form
    {
        public REPORT()
        {
            InitializeComponent();
        }

        private void btnDisplayIncome_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void REPORT_Load(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            MenuLogistic frm = new MenuLogistic();
            frm.Show();
            this.Hide();
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

        public void DisplayWarehouse()
        {
            dgWarehouse.Rows.Clear();
            var lines = File.ReadAllLines("tbIncoming_Goods.txt");
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    var cellarry = cellValues.Split('~');
                    if (cellarry.Length == dgWarehouse.Columns.Count)
                        dgWarehouse.Rows.Add(cellarry);
                }

            }
        }




        private void btnDisplayOutcome_Click(object sender, EventArgs e)
        {
            DisplayDataOut();
        }

        private void dgLogistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgLogistic.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgLogistic.Rows[e.RowIndex].Cells[1].Value.ToString();
            dgLogistic.Rows[e.RowIndex].Cells[2].Value.ToString();
            dgLogistic.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
