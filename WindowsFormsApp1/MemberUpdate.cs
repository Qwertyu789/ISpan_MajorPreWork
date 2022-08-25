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
    public partial class MemberUpdate : Form
    {
        public string _Acc { get; set; }

        iSpanProjectEntities1 ispan = new iSpanProjectEntities1();
        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            
        }
        private void preload()
        {
            var memberid = from mem in ispan.MemberAccounts.AsEnumerable()
                           orderby mem.MemberAcc == _Acc
                           select new
                           {
                               Uid = mem.MemberID,
                               Name = mem.Name,
                               Password = mem.MemberPw,
                               Nickname = mem.NickName,
                               TworNot = mem.TWorNOT,
                               Region = mem.RegionID,
                               Phone = mem.Phone,                               
                               Address=mem.Address,
                               Birthday = mem.Birthday
                           };
        }
    }
}
