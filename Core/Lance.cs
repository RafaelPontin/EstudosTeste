using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosTeste.Core
{
    public class Lance
    {
        public Interessada Cliente { get; }
        public double Valor { get; }

        public Lance(Interessada cliente, double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor do lance deve ser igual ou maior que zero.");
            }
            Cliente = cliente;
            Valor = valor;
        }
    }
}
