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
        iSpanProjectEntities5 newdb = new iSpanProjectEntities5();
        public BuildData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pb1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

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
            RegionList rg0 = new RegionList
            {
                RegionID = 0,
                Region = "海外"
            };
            RegionList rg1 = new RegionList
            {
                RegionID = 1,
                Region = "台北市"
            };
            RegionList rg2 = new RegionList
            {
                RegionID = 2,
                Region = "新北市"
            };
            newdb.RegionList.Add(rg0);
            newdb.RegionList.Add(rg1);
            newdb.RegionList.Add(rg2);
            newdb.SaveChanges();
        }

        private void btnProductprev_Click(object sender, EventArgs e)
        {
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
                BigTypeID=1                
            };
            newdb.Shipper.Add(sp0);
            newdb.BigType.Add(bg0);
            newdb.SmallType.Add(sm0);
            newdb.SaveChanges();
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
    }
}
