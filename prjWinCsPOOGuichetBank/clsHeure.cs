using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsPOOGuichetBank
{
    public class clsHeure
    {
        // declaration des variables privees pour stocker les valeurs des proprietes
        private int vHeure;
        private int vMinute;
        private int vSeconde;




        // declaration des proprietes publiques 
        public int Heure
        {
            get // acces en lecture 
            {
                return vHeure;
            }
            set // acces eln ecriture 
            {
                vHeure = (value >= 0 && value <= 23) ?value :00; 
            }
            
        }
        public int Minute
        {
            get // acces en lecture 
            {
                return vMinute;
            }
            set // acces eln ecriture 
            {
                vMinute = (value >= 0 && value <= 59) ? value : 00;
            }

        }
        public int Seconde
        {
            get // acces en lecture 
            {
                return vSeconde;
            }
            set // acces eln ecriture 
            {
                vSeconde = (value >= 0 && value <= 59) ? value : 00;
            }
        }

        // declaration des constructeurs 

        public clsHeure()
        {
            vHeure = 12;
            vMinute = vSeconde = 0;
        }

        public clsHeure(int heure, int minute, int seconde)
        {
            Heure = heure;
            Minute = minute;    
            Seconde = seconde;
        }
        public clsHeure(int heure, int minute)
        {
            Heure = heure;
            Minute = minute;
            Seconde = 0;
        }
        public clsHeure(int heure)
        {
            Heure = heure;
            Minute = 0;
            Seconde = 0;
        }

        // declaration des methodes publiques 
        public void Regler(int uneHeure, int uneMinute, int uneSeconde)
        {
           
                Heure = uneHeure;
                Minute = uneMinute;
                Seconde = uneSeconde;            
            
        }


        public string EnUniversel()
        {
            return Heure +":"+Minute +":"+Seconde;
        }

        public string EnStandard()
        {
            if (Heure > 12)
            {
                    int newHeure = Heure - 12;
                    return newHeure + ":" + Minute + ":" + Seconde+ " pm";

            }
            else if (Heure == 12)
            {
                return Heure + ":" + Minute + ":" + Seconde + "pm";
            }
            else 
            { return Heure + ":" + Minute + ":" + Seconde + "am"; }
            
        }

    }

}
