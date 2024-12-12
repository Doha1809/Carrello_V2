using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrello_V
{
    internal class ProdottoElettrico : Prodotto
    {
        private double sconto;
        public ProdottoElettrico(string id, string marca, string modello, double prezzo) : base(id, marca, modello, prezzo)
        {
            sconto=0.90;
        }
       public override double Modifica_prezzo()
        {
            return Prezzo * sconto;
        }
    }
}
