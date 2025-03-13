using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scr.Tamagochi.Core;

public abstract class Estado_Alegre : IEstadoMascota
{
    private int vecesJugadas;

    public int Felicidad { get; private set; }

    public Estado_Alegre (int felicidadInicial)
    {
        Felicidad = felicidadInicial;
    }

    public void Comer(Mascota mascota)
    {
        Felicidad++;
    }

    public void Jugar(Mascota mascota)
    {
        Felicidad += 2;
        vecesJugadas++;

        if (vecesJugadas > 5)
        {
            mascota.CambiarEstado(new Hambrienta());
        }
    }

    public bool PuedeJugar() => true;

    public int ObtenerFelicidad() => Felicidad;
}
