using System;


namespace Objectes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Exercici 1

            estudiante alumno = new estudiante("Sergi", -3, "41581196W");
            alumno.Mostra();
            if(alumno.EsMajor())
                Console.WriteLine("Es major");
            else
                Console.WriteLine("Es menor");

           estudiante alumno2= new  estudiante("Marco", 12, "41581886W");
            Console.WriteLine();
            alumno2.Mostra();
            if (alumno2.EsMajor())
                Console.WriteLine("Es major");
            else
                Console.WriteLine("Es menor");
            Console.WriteLine();

            // Exercici 2

            Cuenta cuenta = new Cuenta("Sergio");
           
            cuenta.MostraCuenta(cuenta.Titular, cuenta.Cantidad);
            cuenta.Ingresar(-1000);
            cuenta.MostraCuenta(cuenta.Titular, cuenta.Cantidad);
            cuenta.Retirar(150);
            cuenta.MostraCuenta(cuenta.Titular, cuenta.Cantidad);

            //Exercici 3

            Console.WriteLine();
            CuentaJoven cuentaJoven = new CuentaJoven();
            cuentaJoven.Titular = "Josep";
            cuentaJoven.Cantidad = 2000;
            cuentaJoven.Edat = 25;
            cuentaJoven.MostrarCuentaJove();

        }
    }
}
