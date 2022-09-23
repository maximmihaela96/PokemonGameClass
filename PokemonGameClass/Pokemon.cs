﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameClass
{
    internal class Pokemon
    {
        private readonly string namn;
        private readonly string type;
        private  int currentForm = 1;
        private readonly int totalForms;

        public  Pokemon(string namn, string type, int totalForms)
        {
            this.namn = namn;
            this.type = type;
            this.totalForms = totalForms;

           // Console.WriteLine(namn + " " + type);
        }

        public string GetNamn()
        {
            return namn;
        }
        public string GetType()
        {
            return type;
        }
        public int GetCurrentForm()
        {
            return currentForm;
        }

        public int GetTotalForm()
        {
            return totalForms;  
        }

        public void Evolv()
        {
            currentForm++;
            
        }

    }
}
