using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Carrera
{
    class Equipo
    {
        List<Corredor> corredoress;
        int codigo;
        string nombre;
        List<int> tiemposDeCarrera;

        private void ReservarEspacioMemoria()
        {
            this.corredoress = new List<Corredor>();
            this.tiemposDeCarrera = new List<int>();
        }

        public Equipo(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            ReservarEspacioMemoria();
        }
        public Equipo()
        {
            ReservarEspacioMemoria();
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public List<Corredor> corredors
        {
            get { return this.corredoress; }
        }

        public List<int> TiemposDeCarrera
        { get => tiemposDeCarrera; set => tiemposDeCarrera = value; }

        public void AñadirCorredorEstatico(string nombre, int codigo)
        {
            Corredor corredor;

            corredor = new Corredor(nombre, codigo, 1);
            corredoress.Add(corredor);
        }
        public void EtapaCorrida(int tiempoDeVuelta, Corredor corredor, int etapa)
        {
            corredor.participacion(tiempoDeVuelta, 1);
        }


        public int participacionEtapa(int etapa)
        {
            int suma = 0;
            for (int i = 0; i < corredoress.Count; i++)
            {
                suma = suma + corredoress[i].listaTiempos[etapa];
            }
            TiemposDeCarrera.Add(suma);
            return suma;
        }

        public double promedio(int etapa)
        {
            double prom = TiemposDeCarrera[etapa];
            return prom / TiemposDeCarrera.Count;
        }
        public Corredor corredorMasRapido(int etapa)
        {
            Corredor masRapido = null;
            int i = 0;
            for (int z = 1; z < corredoress.Count; z++)
            {
                if (corredoress[i].listaTiempos[etapa] < corredoress[z].listaTiempos[etapa])
                {
                    if (z < 2)
                        masRapido = corredoress[i];
                    else
                    {
                        if (masRapido.listaTiempos[etapa] > corredoress[i].listaTiempos[etapa])
                            masRapido = corredoress[i];
                    }
                }
                else
                {
                    if (z < 2)
                    {
                        masRapido = corredoress[z];
                    }
                    else
                    {
                        if (masRapido.listaTiempos[etapa] > corredoress[z].listaTiempos[etapa])
                            masRapido = corredoress[z];
                    }
                }
            }
            return masRapido;
        }
        public Corredor mejorPromedio()
        {
            Corredor corredor = corredoress[0];
            for (int z = 1; z < corredoress.Count; z++)
            {
                if (corredor.promedio() > corredoress[z].promedio())
                {
                    corredor = corredoress[z];
                }
            }
            return corredor;
        }            
        public Corredor peorPromedio()
        {
        Corredor corredor = corredoress[0];
        for (int z = 1; z < corredoress.Count; z++)
        {
            if (corredor.promedio() < corredoress[z].promedio())
            {
                corredor = corredoress[z];
            }
        }
        return corredor;
        }
        public int TiempoTotal()
        {
            int tiempototal = 0;
            for(int i=0; i < 2; i++)
            {
                tiempototal += TiemposDeCarrera[i];
            }
            return tiempototal;
        }
    }
}
