using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Juego
    {

        string nombre;
        private DateTime tiempoIni;
        private DateTime tiempoFin;
        bool termino;


        public Juego() { }
        public Juego(string nombre, DateTime tiempoIni, DateTime tiempoFin, bool termino)
        {
            this.nombre = nombre;
            this.tiempoIni = tiempoIni;
            this.tiempoFin = tiempoFin;
            this.termino = termino;
        }

        public string NombreJugador
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime TiempoIni
        {
            get { return this.tiempoIni; }
            set { this.tiempoIni = value; }
        }

        public DateTime TiempoFin
        {
            get { return this.tiempoFin; }
            set { this.tiempoFin = value; }
        }

        public TimeSpan tiempoTot
        {
            get { return tiempoFin.Subtract(tiempoIni); }    //se restan ambos tiempos 
        }

        public bool TerminoJugada
        {
            get { return this.termino; }
            set { this.termino = value; }
        }





        


       



       





    }
}


    


        

       
            
            
        
    

