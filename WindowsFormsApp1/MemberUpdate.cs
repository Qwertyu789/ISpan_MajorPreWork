using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MajorHW;
using WindowsFormsApp1;

namespace MajorHW
{
    public partial class MemberUpdate : Form
    {
        public string _ac = "";
        byte[] img;
        iSpanProjectEntities5 iSpan = new iSpanProjectEntities5();

        public MemberUpdate()
        {
            InitializeComponent();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var change = from mem in this.iSpan.MemberAccount
                         where mem.MemberAcc == _ac
                         select mem;
            var mem2 = change.ToList()[0];
            var rgMem = from r2 in iSpan.RegionList
                        where r2.Region == cobRegion.Text
                        select r2;
            mem2.MemberPw = tbPW.Text;
            mem2.Phone = tbPhone.Text;
            mem2.Email = tbEmail.Text;
            mem2.TWorNOT = cbTaiwan.Checked;
            if (!cbTaiwan.Checked) mem2.RegionID = 0;
            else mem2.RegionID = rgMem.ToList()[0].RegionID;
            mem2.Address = tbAddress.Text;
            mem2.Name = tbName.Text;
            mem2.NickName = tbNickname.Text;
            mem2.Birthday = dpBirthday.Value;
            mem2.MemPic = img;
            this.iSpan.SaveChanges();
            MessageBox.Show("修改成功", "修改結果", MessageBoxButtons.OK);
            MemLoad();

        }
        private void MemLoad()
        {
            var member = from mem in iSpan.MemberAccount
                         where mem.MemberAcc == _ac
                         select new
                         {
                             Account = mem.MemberAcc,
                             Uid = mem.MemberID,
                             Name = mem.Name,
                             Password = mem.MemberPw,
                             Nickname = mem.NickName,
                             Emil = mem.Email,
                             TworNot = mem.TWorNOT,
                             Region = mem.RegionID,
                             Phone = mem.Phone,
                             Address = mem.Address,
                             Birthday = mem.Birthday,
                             Picture = mem.MemPic
                         };
            var mem2 = member.ToList()[0];
            var rgMem = from r2 in iSpan.RegionList
                        where r2.RegionID == mem2.Region
                        select r2;

            lbUID1.Text = mem2.Uid.ToString();
            lbAC2.Text = mem2.Account;
            tbName.Text = mem2.Name;
            tbPW.Text = mem2.Password;
            tbPhone.Text = mem2.Phone;
            tbNickname.Text = mem2.Nickname;
            tbEmail.Text = mem2.Emil;
            cbTaiwan.Checked = mem2.TworNot;
            img = mem2.Picture;
            cobRegion.Text = rgMem.ToList()[0].Region;
            tbAddress.Text = mem2.Address;
            dpBirthday.Value = mem2.Birthday;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
            this.pictureBox1.Image = Image.FromStream(ms);
        }

        private void cbTaiwan_CheckedChanged(object sender, EventArgs e)
        {
            var change = from mem in this.iSpan.MemberAccount
                         where mem.MemberAcc == _ac
                         select mem;
            int rgid = change.ToList()[0].RegionID;
            var rgMem = from r2 in iSpan.RegionList
                        where r2.RegionID==rgid
                        select r2;
            if (cbTaiwan.Checked == true)
            {
                cobRegion.Enabled = true;
                cobRegion.Text = rgMem.ToList()[0].Region;
                if (cobRegion.Text == "海外" && rgid == 0) cobRegion.Text = "台北市";
            }
            else
            {
                cobRegion.Enabled = false;
                cobRegion.Text = "海外";
            }
        }

        private void cbRegionLoad()
        {
            cobRegion.Items.Clear();
            var region = from r in iSpan.RegionList
                         where r.RegionID > 0
                         orderby r.RegionID ascending
                         select r.Region;
            foreach (string item in region.Distinct())
            {
                cobRegion.Items.Add(item);
            }
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {
            cbRegionLoad();
            MemLoad();
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
            }            
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            img = ms.GetBuffer();
        }
    }
}
