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
    public partial class Sells : Form
    {
        private List<byte[]> imgsaver = new List<byte[]>();
        private Image tempimg;
        public string _ac = "";
        int _memid, _typeid, _regionid, _shipperid,_product;
        private ProductIcon _selectedUC;
        bool _isnew = true;
        private iSpanProjectEntities5 dbispan = new iSpanProjectEntities5();
        public Sells()
        {
            InitializeComponent();
            loading();
        }
        private void loading()
        {
            var regions = from r in dbispan.RegionList
                          orderby r.RegionID ascending
                          select r.Region;
            var shipper = from s in dbispan.Shipper
                          orderby s.ShipperID ascending
                          select s.ShipperName;
            var types = from t in dbispan.SmallType
                        orderby t.SmallTypeID ascending
                        select t.SmallTypeName;
            foreach (var items in regions.ToList())
            {
                cbProductRegion.Items.Add(items);
            }
            foreach (var items in shipper.ToList())
            {
                cbProductShipper.Items.Add(items);
            }
            foreach (var items in types.ToList())
            {
                cbProductType.Items.Add(items);
            }

        }

        private void refresh()
        {
            dgProductList.DataSource = null;
            dgProductList.DataSource = dbispan.Product.ToList();
            imgsaver.Clear();
        }
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string imgtitle = "";
            byte[] byteimg;
            ProductIcon picon = new ProductIcon();
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tempimg = Image.FromFile(this.openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                tempimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteimg = ms.GetBuffer();
                imgtitle = (this.flowLayoutPanel1.Controls.Count + 1).ToString();
                picon.img = byteimg;
                imgsaver.Add(byteimg);
                picon.Click += new EventHandler(picture_click);

                this.flowLayoutPanel1.Controls.Add(picon);
            }
        }
        void picture_click(object sender, EventArgs e)
        {
            if (_selectedUC != null)
                _selectedUC.BorderStyle = BorderStyle.None;
            _selectedUC = (ProductIcon)sender;
            _selectedUC.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = this.flowLayoutPanel1.Controls.IndexOf(_selectedUC);
            if (this.flowLayoutPanel1.Controls.Contains(_selectedUC))
            {
                this.flowLayoutPanel1.Controls.Remove(_selectedUC);
                imgsaver.RemoveAt(idx);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_isnew)
            {
                idcheck();
                Product p = new Product
                {
                    ProductName = tbProductName.Text,
                    SmallTypeID = _typeid,
                    MemberID = _memid,
                    RegionID = _regionid,
                    AdFee = decimal.Parse(tbProduectAdFee.Text),
                    Description = tbProductDescription.Text,
                    ShipperID = _shipperid,
                };
                MessageBox.Show(p.ProductID.ToString());
                for (int i = 0; i< imgsaver.Count;i++) {
                    ProductPic pp = new ProductPic
                    {
                        ProductID = p.ProductID,
                        picture = imgsaver[i]
                    };
                }                
            }
        }
        private void idcheck()
        {
            if (cbProductRegion.Text==""  || cbProductShipper.Text=="" || cbProductType.Text=="") return;
            var typeid = from t in dbispan.SmallType
                         where t.SmallTypeName == cbProductType.Text
                         select t.SmallTypeID;
            var regionid = from r in dbispan.RegionList
                           where r.Region == cbProductRegion.Text
                           select r.RegionID;
            var shipperid = from s in dbispan.Shipper
                            where s.ShipperName == cbProductShipper.Text
                            select s.ShipperID;
            _typeid = typeid.ToList()[0];
            _regionid =regionid.ToList()[0];
            _shipperid = shipperid.ToList()[0];            
        }
    }
}
