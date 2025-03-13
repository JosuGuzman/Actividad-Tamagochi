using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scr.Tamagochi.Core;

public abstract class Estado_Hambrienta : IEstadoMascota
{
    public void Comer(Mascota mascota)
    {
        mascota.CambiarEstado(new Contenta(mascota.Felicidad));
    }

    public void Jugar(Mascota mascota)
    {
        // No hace nada, no puede jugar si está hambrienta.
    }

    public bool PuedeJugar() => false;

    public int ObtenerFelicidad() => 0;
}
