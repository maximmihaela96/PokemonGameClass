using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameClass
{
    internal class Pokemon
    {
        public string namn;
        public string type;
        public int totalForms;
        public int currentForm;

        public  Pokemon(string namn, string type, int totalForms)
        {
            this.namn = namn;
            this.type = type;
            this.totalForms = totalForms;

            Console.WriteLine(namn + " " + type);
        }

    }
}
