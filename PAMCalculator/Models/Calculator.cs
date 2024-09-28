using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMCalculator.Models
{
    public class Calculator
    {
        public double PrimeiroTermo{ get; set; }
        public double SegundoTermo{ get; set; }
        public double Resultado{ get; set; }

        public void Somar()
        {
            Resultado = PrimeiroTermo + SegundoTermo;
        }
        public void Subtrair()
        {
            Resultado = PrimeiroTermo - SegundoTermo;
        }
        public void Multiplicar()
        {
            Resultado = PrimeiroTermo * SegundoTermo;
        }
        public void Dividir()
        {
            Resultado = PrimeiroTermo / SegundoTermo;
        }
        public void Elevar()
        {
           
        }
        public void Raiz()
        {
        }
    }
}
