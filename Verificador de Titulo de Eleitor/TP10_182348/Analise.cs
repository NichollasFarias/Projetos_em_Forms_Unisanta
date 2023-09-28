using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP10_182348
{
    class Analise
    {
        public static Boolean ValidaTE(string TE)
        {
            int Soma1 = 0, Soma2 = 0;
            int Resto1 = 0, Resto2 = 0;
            string Verificador01 = TE.Substring(10, 1), Verificador02 = TE.Substring(11, 1); 


            TE = TE.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "").Trim();

            if (TE.Length != 12)
            {
                MessageBox.Show("Ta faltando algo");
            }

            for (int i = 0; i < 8; i++)
            {
                Soma1 += (int.Parse(TE.Substring(i,1))) * (i + 2);
            }
            Resto1 = Soma1 % 11;

            for (int i = 8; i < 11; i++)
            {
                Soma2 += (int.Parse(TE.Substring(i,1))) * (i - 1);
            }
            Resto2 = Soma2 % 11;

            if (Resto2 == 0)
            {
                if (TE.Substring(8, 1) == "0" && TE.Substring(10, 1) == "1" || TE.Substring(9, 1) == "2")
                {
                    Resto2 = 1;
                }
                else
                {
                    Resto2 = 0;
                }
            }


            if (Resto1.ToString() == Verificador01 && Resto2.ToString() == Verificador02)
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
