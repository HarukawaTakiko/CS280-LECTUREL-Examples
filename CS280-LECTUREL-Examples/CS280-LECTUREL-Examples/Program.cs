﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_LECTUREL_Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            pokemon pokemon = new pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            Console.WriteLine("身高:{0},體重{1}",
                pokemon.Height, pokemon.Weight);)
        }
    }
}