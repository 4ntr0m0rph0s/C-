using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcNew
{
    class Program
    {
        



        static void Main(string[] args)
        {
            double calculo;
            int idade = 0;
            string Email = null;
            string Nome = null;
            long CPF = 0;
            Pessoa pessoa = new Pessoa(Nome, Email, idade, CPF);

            double Altura = 0;
            double Peso = 0;
            Saude Saude = new Saude(Altura, Peso, pessoa);

            Console.WriteLine("-----------------------------------imc---------------------------------------");
            Console.WriteLine("Nome:");
            Nome=Console.ReadLine();
            Console.WriteLine("Email: ");
            Email=Console.ReadLine();
            Console.WriteLine("Idade:");
            idade=int.Parse(Console.ReadLine());
            Console.WriteLine("CPF:");
            CPF=long.Parse(Console.ReadLine());
            Console.WriteLine("Altura:");
            Altura= double.Parse(Console.ReadLine());
            Console.WriteLine("Peso:");
            Peso= double.Parse(Console.ReadLine());

            calculo = Calculo(Altura,Peso);
            

   
        }
        static double Calculo(double Altura, double Peso)
        {
            double imc = (Peso / (Altura * Altura));
            Console.WriteLine("Seu IMC: "+ imc.ToString("F"));

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc == 18.5) || (imc < 24.9))
            {
                Console.WriteLine("Peso normal");
            }
            if ((imc > 25) || (imc < 29.9))

            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) || (imc < 34.9))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
            if ((imc > 35) || (imc <= 39.9))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }

            return imc;
        }

    }
}
