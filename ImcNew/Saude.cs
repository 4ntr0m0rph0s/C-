using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcNew
{
   
    class Saude
    {
        private Pessoa Pessoa;
        private double Peso;
        private double Altura;
      

        public Saude(double Altura,double peso,Pessoa Pessoa)
        {
            this.Altura = Altura;
            this.Peso = peso;
            this.Pessoa = Pessoa;
        }

        public Pessoa pessoa
        {
            get {return pessoa;}
            set {Pessoa = pessoa;}
        }

        public float peso
        {
            get{return peso;}
            set{peso = peso;}
        }

        public float altura
        {
            get{return altura;}
            set{altura = altura;}
        }
    }
}
