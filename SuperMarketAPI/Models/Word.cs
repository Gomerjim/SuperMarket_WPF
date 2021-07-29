using System;
using System.Collections.Generic;

namespace SuperMarketAPI.Models
{
    public class Word
    {
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string name;

        public Word(string name)
        {
            this.name = name;
        }

    }
}
