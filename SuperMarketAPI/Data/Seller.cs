using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAPI.Data
{
    public class Seller
    {
        public int UserId { get; set; }
        public string SellerName { get; set; }
        public int SellerAge { get; set; }
        public int SellerPhone { get; set; }
        public string SellerPass { get; set; }

        //Navigation property
        public virtual User User { get; set; }

    }
}
