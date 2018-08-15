using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticData
{
    public partial class MenuLogistic : Form
    {
        public MenuLogistic()
        {
            InitializeComponent();
        }

        private void MenuLogistic_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DataLogstic frm = new DataLogstic();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            REPORT frm = new REPORT();
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OutcomeGoods frm = new OutcomeGoods();
            frm.Show();
            this.Hide();
        }
    }
}
