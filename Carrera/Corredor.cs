using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carrera
{
    class Corredor
    {
        string nombre;
        Equipo equipo;
        int codigo;
        int tiempoDeCarrera = 0;
        List<int> participaciones;
        List<int> tiemposDeCarrera;

        private void ReservarEspacioMemoria()
        {
            this.tiemposDeCarrera = new List<int>();
            this.participaciones = new List<int>();
        }

        public Corredor(string nombre, int codigo,int tiempoDeCarrera)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.tiempoDeCarrera = tiempoDeCarrera;
            ReservarEspacioMemoria();
        }

        public string Nombre
        {
            get { return this.nombre;  }
            set { this.nombre = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public int TiempoCarrera
        {
            get { return this.tiempoDeCarrera; }
            set { this.tiempoDeCarrera = value; }
        }
        public List<int> listaTiempos
        {
            get { return this.tiemposDeCarrera; }
        }
        public List<int> etapasCorridas
        {
            get { return this.participaciones;  }
        }
        public void participacion(int tiempo, int etapa)
        {
            TiempoCarrera = 0;
            TiempoCarrera = TiempoCarrera + tiempo;
            this.listaTiempos.Add(tiempo);
            this.participaciones.Add(etapa);
        }
        public double promedio()
        {
            double prom=0;
            for(int i=0; i < listaTiempos.Count; i++)
            {
                prom = prom + listaTiempos[i];
            }
            return prom/listaTiempos.Count;
        }
    }
}
