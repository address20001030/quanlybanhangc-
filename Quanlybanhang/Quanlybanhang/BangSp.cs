using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class BangSp : Form
    {
        public BangSp()
        {
            InitializeComponent();
        }

        private void BangSp_Load(object sender, EventArgs e)
        {
            SP ob = new SP();
            ob.Hienthi(list_Sp,"select * from Sanpham");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SP ob = new SP(txt_masp.Text,txt_tensp.Text,float.Parse(txt_sl.Text),float.Parse(txt_dongia.Text));
            if (ob.KT_check(txt_masp.Text) == true)
            {
                MessageBox.Show("Trùng khóa chính");
            }
            else {
                ob.insert(ob);
                BangSp_Load(sender, e);
            }
        }
    }
}
