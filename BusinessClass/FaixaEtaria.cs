using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessClass
{
    public class FaixaEtaria
    {
        public bool FaixaRisco(int idade)
        {
            return idade > 17 && idade <= 35;
        }
    }
}
