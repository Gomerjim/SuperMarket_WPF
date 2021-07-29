using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketAPI.Data;

namespace SuperMarketAPI.Models
{
    internal class DataGridItem
    {
        private Seller seller;
    
        public Seller Seller
        {
            get { return seller; }
            set { seller = value; } 
        }

        public DataGridItem(Seller seller)
        {
            this.seller = seller;

        }
    }
}
