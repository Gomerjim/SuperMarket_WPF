using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAPI.Data
{
    public class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }

        //Navigation property
        public ICollection<Product> Products { get; set; }

    }
}
