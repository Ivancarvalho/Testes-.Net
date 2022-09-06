﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 100; // 8 bits, intervalo de 0 a 255
            //ushort num2; // 16 bits, de 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;

            //int numero = 'C';

            //Console.WriteLine(numero);
            //Console.ReadKey();
            #endregion

            #region Conversão Explícita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Método Parse
            //string txtnumero = "1985";

            //int numero = int.Parse(txtnumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");

            //float num3 = float.Parse("457,75");

            //Console.WriteLine(num3);
            //Console.ReadKey();
            #endregion

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');

            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
