using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carrera
{
    class Carrera
    {
        private const int etapa = 10;
        private Etapa[] etapas;
        private List<Equipo> equipos;

        private void reservarEspacioMemoria()
        {
            this.equipos = new List<Equipo>();
            this.etapas = new Etapa[etapa];
            for (int i = 0; i < etapa; i++)
            {
                this.etapas[i] = new Etapa(10, 2, i, this);
            }

        }
        public Carrera()
        {
            reservarEspacioMemoria();
        }

        public Etapa[] etapasNum
        {
            get { return this.etapas; }
        }

        public List<Equipo> participantes
        {
            get { return this.equipos; }
        }

        public void IniciarEtapa(int numeroEtapa)
        {
            Random rnd = new Random();
            int[] numero = new int[6];
            for (int i = 0; i < 6; i++)
            {
               numero[i] = rnd.Next(10, 25);
            }
   
            participantes[0].EtapaCorrida(numero[0], participantes[0].corredors[0], etapas[numeroEtapa].CodiEtapa);
            participantes[1].EtapaCorrida(numero[1], participantes[1].corredors[0], etapas[numeroEtapa].CodiEtapa);
            participantes[2].EtapaCorrida(numero[2], participantes[2].corredors[0], etapas[numeroEtapa].CodiEtapa);
            participantes[0].EtapaCorrida(numero[3], participantes[0].corredors[1], etapas[numeroEtapa].CodiEtapa);
            participantes[1].EtapaCorrida(numero[4], participantes[1].corredors[1], etapas[numeroEtapa].CodiEtapa);
            participantes[2].EtapaCorrida(numero[5], participantes[2].corredors[1], etapas[numeroEtapa].CodiEtapa);

            participantes[0].participacionEtapa(numeroEtapa);
            participantes[1].participacionEtapa(numeroEtapa);
            participantes[2].participacionEtapa(numeroEtapa);

        }

        public void IngresarEquipo(int codigo, String nombre)
        {
            Equipo equipo;
            equipo = new Equipo(codigo, nombre);
            participantes.Add(equipo);

        }
        public void MostrarEquipos()
        {
            Console.WriteLine("El equipo 1 son los {0} el cual tiene de corredores a {1} y {2}", equipos[0].Nombre, equipos[0].corredors[0].Nombre, equipos[0].corredors[1].Nombre);
            Console.WriteLine("El equipo 2 son los {0} el cual tiene de corredores a {1} y {2}", equipos[1].Nombre, equipos[1].corredors[0].Nombre, equipos[1].corredors[1].Nombre);
            Console.WriteLine("El equipo 3 son los {0} el cual tiene de corredores a {1} y {2}\n", equipos[2].Nombre, equipos[2].corredors[0].Nombre, equipos[2].corredors[1].Nombre);

        }

        public void MostrarTiempos(int etapanum)
        {
            etapas[etapanum].tiempos();
        }
        public String mejorPromedioCorredor()
        {
            Corredor corredor = equipos[0].mejorPromedio();
                for(int z=1; z < equipos.Count; z++)
                {
                    if (corredor.promedio() > equipos[z].mejorPromedio().promedio())
                    {
                        corredor = equipos[z].mejorPromedio();
                    }
                }
            Console.WriteLine("\nEl mejor promedio es del corredor {0}, Numero {1} con un promedio de {2}", corredor.Nombre, corredor.Codigo+1, corredor.promedio());
            return corredor.Nombre;
        }
        public String peorPromedioCorredor()
        {
            Corredor corredor = equipos[0].mejorPromedio();
            for (int z = 1; z < equipos.Count; z++)
            {
                if (corredor.promedio() < equipos[z].mejorPromedio().promedio())
                {
                    corredor = equipos[z].mejorPromedio();
                }
            }
            Console.WriteLine("El peor promedio es del corredor {0}, Numero {1} con un promedio de {2}", corredor.Nombre, corredor.Codigo + 1, corredor.promedio());
            return corredor.Nombre;
        }
        public Equipo Ganador()
        {
            Equipo equipoganador = participantes[0];
            for (int z = 1; z < participantes.Count; z++)
            {
                if (equipoganador.TiempoTotal() > participantes[z].TiempoTotal())
                {
                    equipoganador = participantes[z];
                }
            }
            return equipoganador;
        }
    }
        
}
