using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectes
{
    class Cuenta
    {
        string titular;
        double cantidad;



        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 1200;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;

        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public void MostraCuenta(string titular, double cantidad)
        {
            Console.WriteLine($"{titular} tiene {cantidad}€");
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad < 0) { }
            else
                this.cantidad += cantidad;

            

        }

        public void Retirar(double  cantidad)
        {
            if (cantidad < 0) { }
            else
                this.cantidad -= cantidad;

            

        }
    }
}
