﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasAbstrak2693.Interface;
namespace TugasAbstrak2693
{
    class Program
    {
        static void Main(string[] args)
        {
            ILaptop laptop;
            laptop = new Acer();
            laptop.menyala();
            Console.WriteLine();
            laptop = new Asus();
            laptop.menyala();
            Console.ReadKey();
           
        }
    }
}
