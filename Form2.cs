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
    public delegate void AddNVDelegate(string NVID, string FullName, string luongCB);

    public partial class Form2 : Form
    {
        public AddNVDelegate OnAddNV;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string maNV, string fullName, string luongCB) : this()
        {
            txtMSNV.Text = maNV;
            txtTen.Text = fullName;
            txtLuong.Text = luongCB;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string maNV = txtMSNV.Text;
            string fullName = txtTen.Text;
            string luongCB = txtLuong.Text;

            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(luongCB))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            OnAddNV?.Invoke(maNV, fullName, luongCB);
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
