using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAPI.Data
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public double ProdPrice { get; set; }


        public int CatId { get; set; }
        //Navigation Property
        public virtual Category Category { get; set; }

    }
}
