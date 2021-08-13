using System;
using System.Collections.Generic;
using System.Diagnostics;
using SuperMarketAPI.Data;
using System.Linq;
using System.Windows;

namespace SuperMarketAPI.ViewModels
{
    internal class ViewModel
    {
        public List<User> Users { get; set; }
        public double ListViewSize { get; set; }

        public ViewModel()
        {

            using (var db = new SuperContext())
            {
                db.Database.EnsureCreated();

                Users = db.Users.ToList();

            }
        }


    }
}
