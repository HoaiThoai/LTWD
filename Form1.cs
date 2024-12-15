using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.OnAddNV += (maNV, fullName, luongCB) =>
            {
                dataGridView1.Rows.Add(maNV, fullName, luongCB);
            };
            form2.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maNV = selectedRow.Cells[0].Value.ToString();
                string fullName = selectedRow.Cells[1].Value.ToString();
                string luongCB = selectedRow.Cells[2].Value.ToString();

                // Mở Form2 để sửa
                Form2 form2 = new Form2(maNV, fullName, luongCB);
                form2.OnAddNV += (newMaNV, newFullName, newLuongCB) =>
                {
                    selectedRow.Cells[0].Value = newMaNV;
                    selectedRow.Cells[1].Value = newFullName;
                    selectedRow.Cells[2].Value = newLuongCB;
                };
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long chon mot dong de sua!", "Thong bao");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Vui long chon mot dong de xoa!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
