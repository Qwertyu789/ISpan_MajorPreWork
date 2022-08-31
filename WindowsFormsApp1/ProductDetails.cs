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
            
        }
        public ProductDetailStyleInfo pds = new ProductDetailStyleInfo();
        public string _name = "";
        public int _qty;
        public decimal _unitprice;
        public byte[] _pic;
        bool _loaddata = false;
        public bool loaddata { get { return _loaddata; } set { _loaddata = value; } }
        public int pdid { get; set; }
        bool pass = false;
        //回傳
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (_loaddata)
            {
                check_fill();
                if (!pass) return;
                Sells fForm = (Sells)this.Owner;
                fForm.listpd[pdid] = pds;
                MessageBox.Show("修改成功", "結果", MessageBoxButtons.OK);
                this.Close();

            }
            else 
            {
                check_fill();
                if (!pass) return;
                Sells fForm = (Sells)this.Owner;
                fForm.listpd.Add(pds);
                MessageBox.Show("新增成功", "結果", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void load()
        {
            if (_loaddata)
            {
                tbStyle.Text = pds.styleName;
                tbQty.Text = pds.styleQty.ToString();
                tbUnitPrice.Text = pds.styleUnitprice.ToString();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(pds.stylePic);
                this.pictureBox1.Image = Image.FromStream(ms);
                _pic = pds.stylePic;
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
        private void check_fill()
        {
            if (!string.IsNullOrWhiteSpace(tbStyle.Text)) pds.styleName = tbStyle.Text;
            else { MessageBox.Show("請輸入規格名稱"); return; };
            bool isQty = int.TryParse(tbQty.Text, out _qty);
            if (isQty && _qty >= 0) pds.styleQty = _qty;
            else { MessageBox.Show("請輸入大於等於0的數字"); return; };
            bool isPrice = decimal.TryParse(tbUnitPrice.Text, out _unitprice);
            if (isPrice) pds.styleUnitprice = _unitprice;
            else { MessageBox.Show("請輸入正確價格格式"); return; };
            if (_pic != null) pds.stylePic = _pic;
            else { MessageBox.Show("請上傳商品照片"); return; };
            pass = true;
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
