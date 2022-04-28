﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Negyzet
{
    public class Square
    {
        // Tagváltozók
        public double Oldal { get; set; }

        // Konstruktor
        public Square(double oldal)
        {
            this.Oldal = oldal;
        }

        // Átmérő
        public double Atmero()
        {
            return Math.Sqrt(2) * Oldal;
        }

        // Kerulet
        public double Kerulet()
        {
            return 4 * Oldal;
        }

        // Terület
        public double Terulet()
        {
            return Math.Pow(Oldal,2);
        }

        // Oszlop térfogat
        public double Oszlop(double magas)
        {
            if (magas <= 0)
            {
                // Dobunk egy kivételt
                throw new ArgumentException("A magasságnak 0-nál nagyobbnak kell lenni!");
            }
            return Terulet() * magas;
        }


    }
}
