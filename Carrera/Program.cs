using System;

namespace Carrera
{

    /* Crear una carrera con 2 etapas, en la cual participan 3 equipos con 2 corredores en cada uno.
     Cada etapa tiene kilometros, fecha y codigo de etapa.
     Cada corredor tiene un tiempo por cada etapa que participa, un equipo, nombre e id.
     Por cada etapa mostrar por pantalla, el corredor ganador de la etapa y el equipo ganador de la etapa.
     Al final de la carrera mostrar el corredor con mejor promedio y peor promedio, y mostrar al equipo ganador de la carrera.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();

            carrera.IngresarEquipo(1, "Los leones");
            carrera.IngresarEquipo(2, "Los Borbones");
            carrera.IngresarEquipo(3, "Los Juanjos");
            
            carrera.participantes[0].AñadirCorredorEstatico("Juan", 0);
            carrera.participantes[1].AñadirCorredorEstatico("Pepe", 1);
            carrera.participantes[2].AñadirCorredorEstatico("Martin", 2);
            carrera.participantes[0].AñadirCorredorEstatico("Jose", 3);
            carrera.participantes[1].AñadirCorredorEstatico("Pedro", 4);
            carrera.participantes[2].AñadirCorredorEstatico("Mario", 5);

            carrera.MostrarEquipos();

            carrera.IniciarEtapa(0);
            carrera.IniciarEtapa(1);

            carrera.MostrarTiempos(0);
            carrera.MostrarTiempos(1);

            carrera.etapasNum[0].corredorGanador();
            carrera.etapasNum[1].corredorGanador();
            carrera.etapasNum[0].equipoGanador();
            carrera.etapasNum[1].equipoGanador();

            
            
            carrera.mejorPromedioCorredor();
            carrera.peorPromedioCorredor();
            Console.WriteLine("El equipo ganador de la carrera son los {0}", carrera.Ganador().Nombre);
        }
    }
}
    