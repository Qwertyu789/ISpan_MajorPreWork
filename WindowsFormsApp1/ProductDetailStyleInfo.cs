using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ProductDetailStyleInfo
    {
        string _style = "";
        int _qty;
        decimal _unitprice;
        byte[] _pic;

        public string style { get { return _style; } set { _style = value; } }
        public int styleqty { get { return _qty; } set { _qty = value; } }
        public byte[] stylepic { get { return _pic; } set { _pic = value; } }
        public decimal styleunitprice { get { return _unitprice; } set { _unitprice = value; } }
    }
}
