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
        int _styleID;
        
        public int styleID { get { return _styleID; } set { _styleID = value; } }
        public string styleName { get { return _style; } set { _style = value; } }
        public int styleQty { get { return _qty; } set { _qty = value; } }
        public byte[] stylePic { get { return _pic; } set { _pic = value; } }
        public decimal styleUnitprice { get { return _unitprice; } set { _unitprice = value; } }
    }
}
