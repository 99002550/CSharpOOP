using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public string ItemName { set; get; }
        public int ItemCode { set; get; }
        public double TotalBillValue { set; get; }
        public Dictionary<int, double> ItemPrice { set; get; }
        public GourmetShop(int iCode,
        string iName, Dictionary<int, double> iPrice)
        {
            this.ItemCode = iCode;
            this.ItemName = iName;
            this.ItemPrice = iPrice;
        }
        
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}
