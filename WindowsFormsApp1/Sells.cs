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
        public string _ac { get; set; }
        private int _memid, _typeid, _regionid, _shipperid, _product;
        private ProductIcon _selectedUC;
        bool _isnew = true;
        private iSpanProjectEntities5 dbispan = new iSpanProjectEntities5();
        public List<ProductDetailStyleInfo> listpd = new List<ProductDetailStyleInfo>();

        public Sells()
        {
            InitializeComponent();
        }
        //基本載入 combobox
        private void loadingdata()
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
            cbProductRegion.Text = cbProductRegion.Items[0].ToString();
            cbProductShipper.Text = cbProductShipper.Items[0].ToString();
            cbProductType.Text = cbProductType.Items[0].ToString();
            var ac = from mem in this.dbispan.MemberAccount
                     where mem.MemberAcc == _ac
                     select mem.MemberID;
            _memid = ac.First();
        }

        private void reset()
        {
            //顯示用區域清空
            dgProductList.DataSource = null;            
            dgProductDetail.DataSource = null;
            flowLayoutPanel1.Controls.Clear();
            //清空temp用list
            imgsaver.Clear();
            listpd.Clear();
            //填入內容清空
            cbProductType.Items.Clear();
            cbProductShipper.Items.Clear();
            cbProductRegion.Items.Clear();
            tbProductName.Text = "";
            tbProduectAdFee.Text = "";
            tbProductDescription.Text = "";

            btnEditProductDetail.Enabled = false;
            btnDelProductDetail.Enabled = false;
            dgProductList.DataSource = dbispan.Product.ToList();
            loadingdata();
        }
        //重置/另開商品頁面
        private void restart()
        {
            //驗證區重置
            _isnew = true;

            reset();
        }
        //上傳照片
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            byte[] byteimg;
            ProductIcon picon = new ProductIcon();
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tempimg = Image.FromFile(this.openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                tempimg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteimg = ms.GetBuffer();
                picon.img = byteimg;
                imgsaver.Add(byteimg);
                picon.Click += new EventHandler(picture_click);
                this.flowLayoutPanel1.Controls.Add(picon);
            }
        }
        //新增規格
        private void btnAddProductDetail_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails();
            pd.Owner = this;
            pd.ShowDialog();
            dgProductDetail.DataSource = null;
            dgProductDetail.DataSource = listpd;
        }
        //頁面初次進入時預載
        private void Sells_Load(object sender, EventArgs e)
        {
            restart();
        }
        //讀取商品列表
        private void dgProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset();
            btnEditProductDetail.Enabled = true;
            btnDelProductDetail.Enabled = true ;
            _isnew = false;
            int pid = Convert.ToInt32(dgProductList.CurrentRow.Cells[0].Value);
            var product = from p in dbispan.Product
                          where p.ProductID == pid
                          select p;            
            tbProductName.Text = product.First().ProductName;
            tbProduectAdFee.Text = product.First().AdFee.ToString();
            tbProductDescription.Text = product.First().Description;
            infocheck(product.First().RegionID,product.First().ShipperID,product.First().SmallTypeID);

            //照片區處理
            var img = from i in dbispan.ProductPic
                      where i.ProductID == pid
                      orderby i.PicID ascending
                      select i.picture;
            foreach(var p in img)
            {
                ProductIcon picon = new ProductIcon();
                imgsaver.Add(p);
                picon.img = p;
                picon.Click += new EventHandler(picture_click);
                this.flowLayoutPanel1.Controls.Add(picon);
            }
            
            //商品規格區處理
            var pstyle = from p in dbispan.ProductDetail
                         where p.ProductID == pid
                         orderby p.ProductDetailID ascending
                         select new {ID=p.ProductDetailID,Style = p.Style,Qty=p.Quantity,Pic =p.Pic,UnitPrice=p.UnitPrice };
            foreach(var psd in pstyle.ToList())
            {
                ProductDetailStyleInfo pd = new ProductDetailStyleInfo
                {
                    styleID = psd.ID,
                    styleName = psd.Style,
                    styleQty = psd.Qty,
                    stylePic = psd.Pic,
                    styleUnitprice = psd.UnitPrice
                };                
                listpd.Add(pd);
            }
            dgProductDetail.DataSource = listpd;
        }

        //選取照片
        void picture_click(object sender, EventArgs e)
        {
            if (_selectedUC != null)
                _selectedUC.BorderStyle = BorderStyle.None;
            _selectedUC = (ProductIcon)sender;
            _selectedUC.BorderStyle = BorderStyle.FixedSingle;
        }
        //修改規格
        private void btnEditProductDetail_Click(object sender, EventArgs e)
        {
            int pdid = Convert.ToInt32(dgProductDetail.CurrentRow.Index);
            ProductDetails pd = new ProductDetails();
            pd.loaddata = true;
            pd.pdid = pdid;
            pd.pds = listpd[pdid];
            pd.Owner = this;
            pd.ShowDialog();
            dgProductDetail.DataSource = null;
            dgProductDetail.DataSource = listpd;
        }

        //刪除照片
        private void button2_Click(object sender, EventArgs e)
        {
            int idx = this.flowLayoutPanel1.Controls.IndexOf(_selectedUC);
            if (this.flowLayoutPanel1.Controls.Contains(_selectedUC))
            {
                this.flowLayoutPanel1.Controls.Remove(_selectedUC);
                imgsaver.RemoveAt(idx);
            }
        }
        //新增
        private void button3_Click(object sender, EventArgs e)
        {
            if (_isnew)
            {
                idcheck();
                //新增Product資料
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
                dbispan.Product.Add(p);
                dbispan.SaveChanges();
                //新增Product資料照片進ProductPic
                var pid = from i in dbispan.Product
                          orderby p.ProductID descending
                          select p.ProductID;
                for (int i = 0; i < imgsaver.Count; i++)
                {
                    ProductPic pp = new ProductPic
                    {
                        ProductID = pid.ToList()[0],
                        picture = imgsaver[i]
                    };
                    dbispan.ProductPic.Add(pp);
                }
                //新增規格
                for(int i = 0; i < listpd.Count; i++)
                {
                    ProductDetail pd = new ProductDetail
                    {
                        ProductID = pid.ToList()[0],
                        Style = listpd[i].styleName,
                        Quantity = listpd[i].styleQty,
                        UnitPrice = listpd[i].styleUnitprice,
                        Pic = listpd[i].stylePic
                    };
                    dbispan.ProductDetail.Add(pd);
                }
                dbispan.SaveChanges();
            }
            MessageBox.Show("新增成功");
            restart();
        }
        private void idcheck()
        {
            if (cbProductRegion.Text == "" || cbProductShipper.Text == "" || cbProductType.Text == "" ||tbProductName.Text==""||tbProductDescription.Text==""||tbProduectAdFee.Text=="")
            {
                MessageBox.Show("不可有欄位為空！");
                return;
            }
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
            _regionid = regionid.ToList()[0];
            _shipperid = shipperid.ToList()[0];
        }
        private void infocheck(int i,int j,int k)
        {
            var regions = from r in dbispan.RegionList
                          where r.RegionID ==i
                          select r.Region;
            var shipper = from s in dbispan.Shipper
                          where s.ShipperID ==j
                          select s.ShipperName;
            var types = from t in dbispan.SmallType
                        where t.SmallTypeID == k
                        select t.SmallTypeName;            
            cbProductRegion.Text = regions.First();
            cbProductShipper.Text = shipper.First();
            cbProductType.Text = types.First();
        }
    }
}
