using System;
using System.Collections.Generic;
using System.Diagnostics;
using SuperMarketAPI.Models;
using SuperMarketAPI.Data;
using System.Linq;

namespace SuperMarketAPI.ViewModels
{
    internal class ViewModel
    {
        private Word word;
        private List<Word> words = new List<Word>();
        private List<DataGridItem> dataGridItems = new List<DataGridItem>();
        private List<Seller> sellers = new List<Seller>();


        public ViewModel(List<Word> words, List<Seller>sellers)
        {
            List<DataGridItem> itemsList = new List<DataGridItem>();

            foreach (var word in words)
            {
                this.word = word;
                this.words.Add(word);

            }

            if (sellers.Count != 0)
            {

                foreach (var seller in sellers)
                {
                    itemsList.Add(new DataGridItem(seller));
                    this.sellers.Add(seller);
                }
            }

        }




        public List<Word> Words { get { return words; } }
        public List<Seller> Sellers { get { return sellers;} }

    }
}
