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
    public partial class DataLogstic : Form
    {
        public DataLogstic()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tbIncoming_Goods.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtCode.Text + "~" + txtName.Text + "~" + txtUnit.Text + "~" + dateEntry.Value);
            sw.Flush();
            sw.Close();
            fs.Close();

            FileStream fsr = new FileStream("tbRemaining_Goods.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swr = new StreamWriter(fsr);
            swr.WriteLine(txtCode.Text + "~" + txtName.Text + "~" + txtUnit.Text + "~" + dateEntry.Value);
            swr.Flush();
            swr.Close();
            fsr.Close();
            MessageBox.Show("Data has been saved");
            DisplayData();
            Reset();

            autoCode();
        }

        private void DataLogstic_Load(object sender, EventArgs e)
        {

            readsearch();
            DisplayData();
            autoCode();
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DeleteData()
        {
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines("tbIncoming_Goods.txt");
            string lama = txtCode.Text;
            foreach (string line in file)
            {
                if (line.Contains(lama))
                {
                    temp = line.Remove(0);
                    continue;
                }
                newFile.Append(line + "\r\n");
            }
            File.WriteAllText("tbIncoming_Goods.txt", newFile.ToString());
            MessageBox.Show("Data deleted succesfully");
            //Reset();
            DisplayData();
        }

        private void toolDeletee_Click(object sender, EventArgs e)
        {
            DeleteData();
            Reset();
        }

        private void dgLogistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgLogistic.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgLogistic.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUnit.Text = dgLogistic.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateEntry.Text = dgLogistic.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        public void UpdateData()
        {
            string[] file = File.ReadAllLines("tbIncoming_Goods.txt");
            string code = txtCode.Text;
            List<string> updateLines = new List<string>();
            foreach (string line in file)
            {
                string[] infos = line.Split('~');
                if (infos[0] == txtCode.Text)
                {
                    infos[1] = txtName.Text;
                    infos[2] = txtUnit.Text;
                    infos[3] = dateEntry.Text;
                }
                updateLines.Add(string.Join("~", infos));
            }
            File.WriteAllLines("tbIncoming_Goods.txt", updateLines);
            MessageBox.Show("Data Updated Successfully");
            DisplayData();
        }

        private void toolUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            Reset();
        }


        public void autoCode()
        {
            var lines = File.ReadAllLines("tbIncoming_Goods.txt");
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    string[] code = cellValues.Split('~');
                    int value = Convert.ToInt32(code[0].Substring(1));
                    value++;
                    txtCode.Text = "C00" + value;
                }
            }
            else
            {
                txtCode.Text = "C001";
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MenuLogistic frm = new MenuLogistic();
            frm.Show();
            this.Hide();
        }

        public void Reset()
        {
            txtName.Clear();
            txtUnit.Clear();
            dateEntry.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            readsearch();
        }
        private void readsearch()
        {
            String line = "";
            int row = 0;

            FileStream F = new FileStream("tbIncoming_Goods.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            if (cbSearch.SelectedIndex == 0)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elemen = line.Split('~');

                    if (elemen[0].Contains(txtSearch.Text))
                    {
                        dgLogistic.Rows.Add();
                        dgLogistic.Rows.Clear();
                        for (int i = 0; i <= elemen.Length - 1; i++)
                        {
                            dgLogistic[i, row].Value = elemen[i];
                        }
                        row++;
                    }
                }
            }

            else if (cbSearch.SelectedIndex == 1)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elemen = line.Split('~');

                    if (elemen[1].Contains(txtSearch.Text))
                    {
                        dgLogistic.Rows.Add();
                        dgLogistic.Rows.Clear();
                        for (int i = 0; i <= elemen.Length - 1; i++)
                        {
                            dgLogistic[i, row].Value = elemen[i];
                        }
                        row++;
                    }
                }
            }

            else if (cbSearch.SelectedIndex == 2)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elemen = line.Split('~');

                    if (elemen[2].Contains(txtSearch.Text))
                    {
                        dgLogistic.Rows.Add();
                        dgLogistic.Rows.Clear();
                        for (int i = 0; i <= elemen.Length - 1; i++)
                        {
                            dgLogistic[i, row].Value = elemen[i];
                        }
                        row++;
                    }
                }
            }
            else if (cbSearch.SelectedIndex == 3)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] elemen = line.Split('~');

                    if (elemen[3].Contains(txtSearch.Text))
                    {
                        dgLogistic.Rows.Add();
                        dgLogistic.Rows.Clear();
                        for (int i = 0; i <= elemen.Length - 1; i++)
                        {
                            dgLogistic[i, row].Value = elemen[i];
                        }
                        row++;
                    }
                }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
