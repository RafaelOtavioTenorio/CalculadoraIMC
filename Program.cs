using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // imc = peso / altura²
            double peso, altura, imc;
            Console.WriteLine("--- Calculadora IMC ---");
            peso:
            Console.WriteLine("Digite o peso em Kg:");
            valorPeso:
            try
            {               
                peso = Convert.ToDouble(Console.ReadLine());
                if(peso <= 0 ) 
                {
                    Console.WriteLine("Valor inválido, digite um valor maior que 0.");
                    goto valorPeso;
                }
            } 
            catch(FormatException) 
            {
                goto valorPeso;
            }                      
            Console.WriteLine("Digite a altura em metros:");
            valorAltura:
            try
            {
                altura = Convert.ToDouble(Console.ReadLine());
                if (altura <= 0)
                {
                    Console.WriteLine("Valor inválido, digite um valor maior que 0.");
                    goto valorAltura;
                }
            }
            catch(FormatException)
            {
                goto valorAltura;
            }
            
            Console.WriteLine("IMC = {0}", imc = peso / (altura * altura));            
            Console.WriteLine("Cálculo concluído com sucesso, deseja calcular novamente? s/n");
            var restart = Console.Read();
            if (restart == 's')
            {
                goto peso;
            }
        }
    }
}
