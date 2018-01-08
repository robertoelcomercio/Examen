using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConClases
{
    class OrderRange
    {
        string slNumerosParesOrdenados  = "";
        string slNumerosImparesOrdenados  = "";


        List<Numeros> ListaPares  = new List<Numeros>();
        List<Numeros> ListaImPares  = new List<Numeros>();

        public string build(string sEntrada)
        {
            string sRespuesta = "";
            string sPares = "";
            string sImPares = "";

            FitroNumerico(sEntrada);
            OrdenarPares();
            OrdenarImPares();

            sPares = "[" + slNumerosParesOrdenados + "]";
            sImPares = "[" + slNumerosImparesOrdenados + "]";

            sRespuesta = sPares +" "+ sImPares;

            return sRespuesta;
        }


        public void OrdenarPares ()
        {
            int iConta = 0;
            int i = 0;

            iConta = ListaPares.Count();
            int[] ArrayNum = new int[iConta];

            foreach (var numP in ListaPares)
            {ArrayNum[i] = numP.Numero;i += 1;}

            var ListaOrdenada  = new List<int>();
            ListaOrdenada.AddRange(ArrayNum);

            ListaOrdenada.Sort();

            foreach (var num in ListaOrdenada)
            {
                if (slNumerosParesOrdenados.Length > 0)
                    slNumerosParesOrdenados += "," + num.ToString();
                else slNumerosParesOrdenados =  num.ToString();
            }
               

        }



        public void OrdenarImPares ()
        {
            int iConta = 0;
            int i = 0;

            iConta = ListaImPares.Count();
            int[] ArrayNum = new int[iConta];

            foreach (var numP in ListaImPares)
            { ArrayNum[i] = numP.Numero; i += 1; }

            var ListaOrdenada = new List<int>();
            ListaOrdenada.AddRange(ArrayNum);

            ListaOrdenada.Sort();

            foreach (var num in ListaOrdenada)
            {
                if (slNumerosImparesOrdenados.Length > 0)
                    slNumerosImparesOrdenados += "," + num.ToString();
                else slNumerosImparesOrdenados = num.ToString();
            }


        }



        public void  FitroNumerico (string sCadena)
        {
           
            string sNumero = "";
            string sValorUnitario  = "";
            int iTotalCar = 0;        

            iTotalCar = sCadena.Length;
            bool bNum = false;


            for (int i = 0; i < iTotalCar; i++)
            {
                sValorUnitario = sCadena.Substring(i, 1);

                if (Char.IsNumber(Convert.ToChar(sValorUnitario)))
                {
                    bNum = true ;
                    sNumero += sValorUnitario;
                }
                else
                {
                    if (bNum==true) ClasificadorLista(sNumero);

                    bNum = false;                    
                    sNumero = "";
                }

                //FIN for
            }

            if (bNum==true )
                ClasificadorLista(sNumero); 

        }


        public void ClasificadorLista (string sNumero)
        {
            Numeros  oNumero  = new Numeros ();

            oNumero.Numero = Convert.ToInt32(sNumero);

            if ((Convert.ToInt32(sNumero) % 2) == 0)
            {
                ListaPares.Add(oNumero);
            }
            else
            {
                ListaImPares.Add(oNumero);
            }
        }


        public class Numeros 
        {
            public int Numero  { set; get; }
        }

    }
}
