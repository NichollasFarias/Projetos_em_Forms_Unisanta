using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11_182348
{
    class Validacoe
    {
        public static Boolean ValidaCartao(string Num)
        {
            int Soma = 0, Resto;
            int ValidaSoma, Troca = 2;

            Num = Num.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Replace(" ","").Trim();

            for (int i = 0; i < 16; i++)
            {

                ValidaSoma = (int.Parse(Num.Substring(i, 1))) * (Troca);

                if (ValidaSoma > 9)
                {
                    ValidaSoma -= 9;
                }

                Soma += ValidaSoma;

                if (Troca == 2)
                {
                    Troca = 1;
                }
                else
                {
                    Troca = 2;
                }
            }

            Resto = Soma % 10;

            if (Resto == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
