using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minimo = 10, 
            Media = 50, 
            Maxima = 100,
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            //sbyte num1 = 10;

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Números reais
            //float real1 = 100.75f;
            //double real2 = 12500.45;
            //decimal real3 = 752538.457m;

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0041';
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = @"Ivan Carvalho\n 1990 @@$$??";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implícito Var
            //var valor = 100;
            //valor = 20;
            //valor = "Ivan";
            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj = false;
            //obj = 200;
            //obj = "Ivan";
            #endregion

            #region Constantes
            //const double pi = 3.1415;
            //const string nome = "Ivan";
            #endregion

            #region Enumração
            //Notas notasAlunos = Notas.Minimo;
            #endregion

            Pessoa p1 = new Pessoa();

            p1.altura = 1.83;
            p1.idade = 32;
            p1.nome = "Ivan";

            Pessoa p2 = new Pessoa()
            {
                nome = "Lian",
                idade = 04,
                altura = 0.59
            };

            p1.nome = "Luis";
            
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();
        }
    }
}
