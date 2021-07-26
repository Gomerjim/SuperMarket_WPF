using System;
using System.Diagnostics;
using SuperMarketAPI.Models;

namespace SuperMarketAPI.ViewModels
{
    internal class WordViewModel
    {
        public WordViewModel(string[] listOFWords)
        {
            _word = new Word(listOFWords);
        }

        private readonly Word _word;

        public Word Word
        {
            get { return _word; }
        }

    }
}
