using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
            load();
        }
        ProductDetailStyleInfo pds = new ProductDetailStyleInfo();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbStyle.Text)) pds.style = tbStyle.Text;
            else { MessageBox.Show("請輸入規格名稱"); return; };
            bool isQty = int.TryParse(tbQty.Text,out _qty);
            if (isQty&&_qty>=0) pds.styleqty = _qty;
            else { MessageBox.Show("請輸入大於等於0的數字"); return; };
            bool isPrice = decimal.TryParse(tbUnitPrice.Text, out _unitprice);
            if (isPrice) pds.styleunitprice = _unitprice;
            else { MessageBox.Show("請輸入正確價格格式"); return; };
            if (_pic != null) pds.stylepic = _pic;
            else { MessageBox.Show("請上傳商品照片"); return; };     
            //Form1 lForm1 = (Form1)this.Owner
            Sells fForm = (Sells)this.Owner;
            fForm.listpd.Add(pds);
            MessageBox.Show("新增成功", "結果", MessageBoxButtons.OK);
            this.Close();
        }
        string _style = "";
        int _qty;
        decimal _unitprice;
        byte[] _pic;
        bool loaddata = false;
        private void load()
        {
            if (loaddata)
            {
                tbStyle.Text = _style;
                tbQty.Text = _qty.ToString();
                tbUnitPrice.Text = _unitprice.ToString();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(_pic);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                _pic = ms.GetBuffer();
            }
            else return;

        }
    }
}
