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
    public partial class ProductIcon : UserControl
    {
        byte[] imgby;
        public ProductIcon()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        public byte[] img
        {
            get { return imgby; }
            set
            {
                imgby=value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imgby);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

    }
}
