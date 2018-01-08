using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConClases
{
    class ChangeString
    {
        List<Letras> ListaLetras = new List<Letras>();
    

        public string build(string sCadena)
        {
            string sCadenaRespuesta = "";
            int iLongitud = 0;
            iLongitud = sCadena.Length;
            string sCar = "";
            string sDev = "";

            LlenarLetras();


            for (int i = 0; i < iLongitud; i++)
            {
                sCar = sCadena.Substring(i, 1);
                sDev = sCar;


                if (char.IsUpper(Convert.ToChar(sCar)))
                {
                    sDev = ConvertidorLetras(sCar).ToUpper();
                }

                if (char.IsLower(Convert.ToChar(sCar)))
                {
                    sDev = ConvertidorLetras(sCar).ToLower();
                }
                sCadenaRespuesta += sDev;

            }


            return sCadenaRespuesta;


        }


        public string ConvertidorLetras(string sCar)
        {
            string sRespuesta = "";
            sCar = sCar.ToUpper();

            foreach (Letras item in ListaLetras)
            {
                if (item.Letra == sCar)
                {
                    sRespuesta = item.Equivalente;
                }
            }

            return sRespuesta;

        }





        public void  LlenarLetras()
        {
            ConstruirLetras("A", "B");
            ConstruirLetras("B", "C");
            ConstruirLetras("C", "D");
            ConstruirLetras("D", "E");
            ConstruirLetras("E", "F");
            ConstruirLetras("F", "G");

            ConstruirLetras("G", "H");
            ConstruirLetras("H", "I");
            ConstruirLetras("I", "J");
            ConstruirLetras("J", "K");
            ConstruirLetras("K", "L");
            ConstruirLetras("L", "M");

            ConstruirLetras("M", "N");
            ConstruirLetras("N", "Ñ");
            ConstruirLetras("Ñ", "O");
            ConstruirLetras("O", "P");
            ConstruirLetras("P", "Q");
            ConstruirLetras("Q", "R");

            ConstruirLetras("R", "S");
            ConstruirLetras("S", "T");
            ConstruirLetras("T", "U");
            ConstruirLetras("U", "V");
            ConstruirLetras("V", "W");
            ConstruirLetras("W", "X");

            ConstruirLetras("X", "Y");
            ConstruirLetras("Y", "Z");
            ConstruirLetras("Z", "A");
        
        }



        public  void ConstruirLetras(string sLetra, string sEquivalente)
        {
            Letras oLetra = new Letras();
            oLetra.Letra = sLetra;
            oLetra.Equivalente = sEquivalente;
            ListaLetras.Add(oLetra);
          
        }

    

        public class Letras
        {
            public string Letra { set; get; }
            public string Equivalente { set; get; }
        }

   


    }
}
