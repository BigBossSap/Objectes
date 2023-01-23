using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectes
{
    class CuentaJoven
    {
        string titular;
        int edat;
        double cantidad;
        double bonificacio;


        public CuentaJoven()
        {
            titular = "";
            edat = 0;
            cantidad = 0;
        }

        public string Titular { 
            get => titular; 
            set => titular = value;}
        public double Cantidad { 
            get => cantidad;
            set => cantidad = value; }
        public double Bonificacio { 
            get => bonificacio;
            set => bonificacio = value; }
        public int Edat { 
            get => edat; 
            set => edat = value; }

        public bool EsTitularValid()
        {
            bool valid = false;
            if (edat >= 18 && edat<=25)
                valid = true;

            return valid;
        }

        public void MostrarCuentaJove()
        {
            if (EsTitularValid())
            {
                Console.WriteLine($"Cuenta joven de {titular}, tiene {cantidad}€");
            }
            else
                Console.WriteLine("No es titular valid");

        }

    }
}
