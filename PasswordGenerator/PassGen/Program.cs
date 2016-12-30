﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator;

namespace AghasPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var coder = new Coder(80);
            Console.WriteLine(coder.Code);

            var pass = new Password();
            Console.WriteLine(pass.ToString());
            Console.WriteLine(pass.ToString().Length);

            var p1 = new Password(PasswordOptions.OnlyLowerCase, 16);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.ToString().Length);

            var p2 = new Password(25);
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.ToString().Length);

            var p3 = new Password("askd;fasfshdfksj 'l323;kj;adsfjk;");
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p3.ToString().Length);

            var p4 = new Password(PasswordOptions.OnlyAlphabet);
            Console.WriteLine(p4.ToString());
            Console.WriteLine(p4.ToString().Length);

            Console.ReadKey();
        }
    }
}
