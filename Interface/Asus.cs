using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAbstrak2693.Interface
{
    public class Asus : ILaptop
    {
        public  void menyala()
        {
            Console.WriteLine("klik tombol power");
            Console.WriteLine("harus memiliki daya");
        }
    }
}
