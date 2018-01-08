using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasConClases
{
    class MoneyParts
    {

        string lsSolucion = "";

        public string build(string sMontoSoles )
        {
            string sRespuesta = "";            
            InicioCambio(Convert.ToDouble(sMontoSoles));
            CambioDesc(Convert.ToDouble(sMontoSoles));
            sRespuesta = lsSolucion;

            return sRespuesta;
        }



        public void InicioCambio(double dMontoSoles)
        {
            int h = 0;
            int iContador = 12;

            for (h = 0; h < iContador; h++)
            {
                CambioAsc(dMontoSoles,h);
            }
        }


 

        public void CambioAsc(double dMontoSoles, int iIndiceMoneda)
        {
            string sMontoRespuesta = "";
            string sSolucionParcial = "";
            int h = iIndiceMoneda;
            int i = 0;

            double dComparar = 0;
            double dMontoEstatico = dMontoSoles;


            double[] MonedasExamen = { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };
            double[] MarcadorMonedas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (h = iIndiceMoneda; h < MonedasExamen.Length; h++)
            {
                if (dMontoSoles >MonedasExamen[h])
                {
                    MarcadorMonedas[h] = Math.Truncate(dMontoSoles / MonedasExamen[h]);
                    dMontoSoles = dMontoSoles - (MarcadorMonedas[h] * MonedasExamen[h]);
                }
            }


            for (i = 0; i < MonedasExamen.Length; i++)
            {

                if (MarcadorMonedas[i] > 0)
                {
                    sMontoRespuesta = MontoRespuesta(MarcadorMonedas[i], MonedasExamen[i]);
                    if (sSolucionParcial.Length > 0) sSolucionParcial += "," + sMontoRespuesta;
                    else sSolucionParcial += sMontoRespuesta;
                }


            }

            dComparar = MontoComparar(MarcadorMonedas, MonedasExamen);

            if (dComparar == dMontoEstatico)
            {
                GrabarSolucion(sSolucionParcial);
            }  
        }


        public void CambioDesc(double dMontoSoles)
        {
            string sSolucionParcial = "";
            string sMontoRespuesta  = "";
            int h = 0;
            int i = 0;

            double dComparar = 0;
            double dMontoEstatico = dMontoSoles;

            double[] MonedasExamen = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05 };
            double[] MarcadorMonedas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (h = 0; h < MonedasExamen.Length; h++)
            {
                if (dMontoSoles >= MonedasExamen[h])
                {
                    MarcadorMonedas[h] = Math.Truncate(dMontoSoles / MonedasExamen[h]);
                    dMontoSoles = dMontoSoles - (MarcadorMonedas[h] * MonedasExamen[h]);
                }
            }


            for (i = 0; i < MonedasExamen.Length; i++)
            {
                if (MarcadorMonedas[i] > 0)
                {
                    sMontoRespuesta= MontoRespuesta(MarcadorMonedas[i], MonedasExamen[i]);
                    if (sSolucionParcial.Length > 0) sSolucionParcial += "," + sMontoRespuesta;
                    else sSolucionParcial += sMontoRespuesta;
                }
            }


            dComparar = MontoComparar(MarcadorMonedas, MonedasExamen);

            if (dComparar == dMontoEstatico)
            {
                GrabarSolucion(sSolucionParcial);
            }

        }


        public void GrabarSolucion(string sSolucion)
        {
            if (sSolucion.Length > 0)
            {
                lsSolucion += " [" + sSolucion + "]";
            }

        }


        public string MontoRespuesta(double dCantidad ,double dMoneda)
        {
            string sResultado = "";
            int h = 0;
            int iTotal = 0;

            iTotal = Convert.ToInt16(dCantidad);

            for (h = 0; h < iTotal; h++)
            {
                if (sResultado.Length > 0)
                    sResultado += "," + dMoneda.ToString();
                else sResultado += dMoneda.ToString();
            }

            return sResultado;

        }


        public double MontoComparar(double[] MarcadorMonedas, double[] MonedasExamen)
        {
            double dParcial = 0;
            double dResultado = 0;
            int h = 0;
            int iTotal = 0;
            iTotal = MonedasExamen.Length;


            for (h = 0; h < iTotal; h++)
            {
                dParcial = MarcadorMonedas[h] * MonedasExamen[h];
                dResultado += dParcial;
            }

            return dResultado;

        }



    }
}
