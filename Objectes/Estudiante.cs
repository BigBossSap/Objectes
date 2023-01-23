using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectes
{
    class estudiante
    {

        string nom;
        int edat;
        string dni;
       
        

        public estudiante (string nom, int edat, string dni)
        {
            this.nom = nom;
            Edat = edat;
            this.dni = dni;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Edat
        {
            get { return edat; }
            set {
                if (value < 0)
                    edat = 0;
                else
                    edat = value;}
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public void Mostra()
        {
            Console.WriteLine($"Nom: {nom}\nEdat: {edat}\nDni: {dni}\n");
        }

        public bool EsMajor()
        {
            bool major = false;
            if (edat >= 18)
                major = true;

            return major;
        }
    }
}
