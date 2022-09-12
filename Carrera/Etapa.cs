using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Carrera
{
    class Etapa
    {
        int kilometro;
        int fecha;
        int CodEtapa;
        Carrera carrera;

        public Etapa(int kilometro, int fecha, int codEtapa, Carrera carrera)
        {
            this.kilometro = kilometro;
            this.fecha = fecha;
            this.CodEtapa = codEtapa;
            this.carrera = carrera;
        }

        public int CodiEtapa { get => CodEtapa; set => CodEtapa = value; }

        public void tiempos()
        {
            Console.WriteLine("Etapa {0}", CodEtapa+1);
            Console.WriteLine("Corredor {0} Tiempo {1}", carrera.participantes[0].corredors[0].Nombre, carrera.participantes[0].corredors[0].listaTiempos[CodEtapa]);
            Console.WriteLine("Corredor {0} Tiempo {1}", carrera.participantes[1].corredors[0].Nombre, carrera.participantes[1].corredors[0].listaTiempos[CodEtapa]);
            Console.WriteLine("Corredor {0} Tiempo {1}", carrera.participantes[2].corredors[0].Nombre, carrera.participantes[2].corredors[0].listaTiempos[CodEtapa]);
            Console.WriteLine("Corredor {0} Tiempo {1}", carrera.participantes[0].corredors[1].Nombre, carrera.participantes[0].corredors[1].listaTiempos[CodEtapa]);
            Console.WriteLine("Corredor {0} Tiempo {1}", carrera.participantes[1].corredors[1].Nombre, carrera.participantes[1].corredors[1].listaTiempos[CodEtapa]);
            Console.WriteLine("Corredor {0} Tiempo {1}\n", carrera.participantes[2].corredors[1].Nombre, carrera.participantes[2].corredors[1].listaTiempos[CodEtapa]);
        }
        public string corredorGanador()
        {
            Corredor corredor = carrera.participantes[0].corredorMasRapido(CodiEtapa);
            for (int z = 1; z < carrera.participantes.Count; z++)
            {
                if (corredor.listaTiempos[CodiEtapa] > carrera.participantes[z].corredorMasRapido(CodiEtapa).listaTiempos[CodiEtapa])
                {
                    corredor = carrera.participantes[z].corredorMasRapido(CodiEtapa);
                }
            }
            Console.WriteLine("El corredor ganador de la etapa {0} es {1} con tiempo de {2}", CodiEtapa+1, corredor.Nombre, corredor.listaTiempos[CodiEtapa]);
            return corredor.Nombre;
        }

        public string equipoGanador()
        {
        Equipo equipo = carrera.participantes[0];
            for (int z = 1; z < carrera.participantes.Count; z++)
            {
                if (equipo.promedio(CodiEtapa) > carrera.participantes[z].promedio(CodiEtapa))
                {

                        equipo = carrera.participantes[z];
                }
            }
            Console.WriteLine("El Equipo ganador de la etapa {0} es {1} con tiempo de {2}", CodiEtapa + 1, equipo.Nombre, equipo.promedio(CodiEtapa));
            return equipo.Nombre;
        }
    }
}
 



