using Practica.Models;
using Practica.ViewModels;

namespace Practica.Procesos
{
    public class Operaciones
    {

        /***************************************************
            Operaciones relacionadas a las listas 
            de equipos y de jugadores
         ***************************************************/
        public ListadoEquipos_Y_Jugadores Listados() 
        {

            var listado = new ListadoEquipos_Y_Jugadores();
            listado.ListadoDeEquipos = Equipos();
            listado.ListadoDeJugadores = Jugadores();

            return listado;
        }

        private List<Equipo> Equipos() 
        {
            using(PracticaContexto BD = new PracticaContexto()) 
            {
                var lista_equipos = BD.Equipos.ToList();
                return lista_equipos;
            }
        }

        private List<Jugadores> Jugadores() 
        {
            using (PracticaContexto BD = new PracticaContexto())
            {
                var lista_jugadores = BD.Jugadores.ToList();
                return lista_jugadores;
            }
        }


        /***************************************************
            Operaciones relacionadas a la creacion 
            de equipos y de jugadores
        ***************************************************/

        public void AgregarJugadorNuevo(Jugadores jugador) 
        {
            using (PracticaContexto BD = new PracticaContexto()) 
            {
                BD.Jugadores.Add(jugador);
                BD.SaveChanges();
            }
        }

        public void AgregarEquipoNuevo(Equipo nuevo_equipo) 
        {
            using (PracticaContexto BD = new PracticaContexto())
            {
                BD.Equipos.Add(nuevo_equipo);
                BD.SaveChanges();
            }
        }

    }
}
