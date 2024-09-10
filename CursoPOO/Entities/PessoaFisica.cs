using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Entities
{
    class PessoaFisica : Pessoa 
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalculaImposto()
        {
            double imposto;

            if (GastosComSaude > 0)
            {
                if(RendaAnual < 20000.00)
                {
                     imposto = RendaAnual * 0.15 / 2;
                }
                else
                {
                     imposto = RendaAnual * 0.25 / 2;
                  
                }
            }
            else
            {
                if (RendaAnual < 20000.00)
                {
                     imposto = RendaAnual * 0.15;
                    
                }
                else
                {
                     imposto = RendaAnual * 0.25;
                   
                }
            }

            return imposto;
        }

    }
}
