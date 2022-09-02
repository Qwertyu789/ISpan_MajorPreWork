using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MajorHW
{
    public partial class BuildData : Form
    {
        iSpanProjectEntities newdb = new iSpanProjectEntities();
        byte[] bytes;
        public BuildData()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //RegionList rg0 = new RegionList
            //{
            //    RegionID = 0,
            //    Region = "海外"
            //};
            //RegionList rg1 = new RegionList
            //{
            //    RegionID = 1,
            //    Region = "台北市"
            //};
            //RegionList rg2 = new RegionList
            //{
            //    RegionID = 2,
            //    Region = "新北市"
            //};
            //newdb.RegionList.Add(rg0);
            //newdb.RegionList.Add(rg1);
            //newdb.RegionList.Add(rg2);
            //newdb.SaveChanges();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pb1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytes = ms.GetBuffer();

            MemberAccount ADDmemprofile = new MemberAccount
            {
                MemberAcc = "aaaa"
            ,
                MemberPw = "123"
            ,
                TWorNOT = true
            ,
                RegionID = 1
            ,
                Phone = "0987987987"
            ,
                Email = "aaaa@gmail.com"
            ,
                BackUpEmail = "aaaa2@gmail.com"
            ,
                Address = "台北市101"
            ,
                NickName = "aaaa"
            ,
                Name = "王大A"
            ,
                Birthday = DateTime.Now
            ,
                Bio = "我是可憐的碼農"
            ,
                MemPic = bytes
            };

            this.newdb.MemberAccount.Add(ADDmemprofile);

            MemberAccount ADDmemprofile2 = new MemberAccount
            {
                MemberAcc = "bbbb"
            ,
                MemberPw = "123"
            ,
                TWorNOT = true
            ,
                RegionID = 1
            ,
                Phone = "0987987987"
            ,
                Email = "aaaa@gmail.com"
            ,
                BackUpEmail = "aaaa2@gmail.com"
            ,
                Address = "台北市101"
            ,
                NickName = "aaaa"
            ,
                Name = "王大A"
            ,
                Birthday = DateTime.Now
            ,
                Bio = "我是可憐的碼農"
            ,
                MemPic = bytes
            };
            this.newdb.MemberAccount.Add(ADDmemprofile2);
            this.newdb.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pb1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            var qm = from m in newdb.MemberAccount
                     where m.MemberAcc == "aaaa"
                     select m.MemberID;
            Shipper sp0 = new Shipper
            {
                ShipperID = 1,
                ShipperName = "通盈",
                Phone = "2623-8780"
            };
            BigType bg0 = new BigType
            {
                BigTypeID = 1,
                BigTypeName = "大佬的周邊"
            };
            SmallType sm0 = new SmallType
            {
                SmallTypeID = 1,
                SmallTypeName = "大佬的狗",
                BigTypeID = 1
            };
            newdb.Shipper.Add(sp0);
            newdb.BigType.Add(bg0);
            newdb.SmallType.Add(sm0);
            newdb.SaveChanges();
            Product p = new Product
            {
                ProductName = "大佬組長的肉棒",
                SmallTypeID = 1,
                MemberID = Convert.ToInt32(qm),
                RegionID = 1,
                AdFee = 0,
                Description = "大老肉棒又香又好吃",
                ShipperID = 1
            };
            var pid = newdb.Product.Select(i=>i.ProductID).ToList().FirstOrDefault();
            newdb.Product.Add(p);
            newdb.SaveChanges();
            ProductPic pp = new ProductPic
            {
                ProductID = pid,
                picture = bytes
            };
            ProductDetail pd = new ProductDetail
            {
                ProductID = pid,
                Style = "日本大肉棒",
                Quantity = 114514,
                UnitPrice = 888,
                Pic = bytes
            };
            newdb.ProductPic.Add(pp);
            newdb.ProductDetail.Add(pd);
            newdb.SaveChanges();
        }

        private void btnProductprev_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.newdb.MemberAccount.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.newdb.Product.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //帳號類 ID1
            FAQType newfaqt1 = new FAQType
            {
                FAQTypeName = "新進大補帖！"
            };
            newdb.FAQType.Add(newfaqt1);
            newdb.SaveChanges();
            //新進會員
            FAQ fqt1fq1 = new FAQ
            {
                FAQTypeID=1,
                Question="[LV.1] 蝦到爆？這是什麼？",
                Answer= "「你是新警察對吧？老警察才不會點進幫助中心的呢！」\r\n" +
                "　　蝦到爆是一個電子商務平台，您可以在此發掘您心儀的品牌，悠游蝦到爆上無數間大大小小的商家所提供最高品質的享受！\r\n\r\n" +
                "　　除了購物，您也能化作商務高手，進入蝦到爆裡開拓出自己的一片沃土，蝦到爆會提供各式成為賣家的詳盡說明，還請移步至我們更深入的賣家指南。"
            };
            FAQ fqt1fq2 = new FAQ
            {
                FAQTypeID = 1,
                Question = "[LV.2] 那我要怎麼開始？是不是已經太晚加入了？",
                Answer = "「人生永遠沒有太晚的開始。」\r\n" +
                "　　蝦到爆為了每位\r\n\r\n" +
                "　　除了購物，您也能化作商務高手，進入蝦到爆裡開拓出自己的一片沃土，蝦到爆會提供各式成為賣家的詳盡說明，還請移步至我們更深入的賣家指南。"
            };
            newdb.FAQ.Add(fqt1fq1);
            newdb.FAQ.Add(fqt1fq2);
            newdb.SaveChanges();
            FAQType newfaqt2 = new FAQType
            {
                FAQTypeName = "賣家指南！"
            };
            FAQ fat2fq1 = new FAQ
            {
                FAQTypeID = 2,
                Question = "我有個夢想，就是成立一間最大的蝦到爆賣場！那我該怎麼開始？",
                Answer = "讚哦！現在就點開個人商品區，跟著我們淺顯易懂的按鈕標示一步一步來完成第一次的上架吧！"
            };

        }
    }
}
