using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scr.Tamagochi.Core;

public abstract class Estado_Aburrido : IEstadoMascota
{
    private DateTime tiempoAburrida;

    public Estado_Aburrido()
    {
        tiempoAburrida = DateTime.Now;
    }

    public void Comer(Mascota mascota)
    {
        if ((DateTime.Now - tiempoAburrida).TotalMinutes > 80)
        {
            mascota.CambiarEstado(new Contenta(mascota.Felicidad));
        }
    }

    public void Jugar(Mascota mascota)
    {
        mascota.CambiarEstado(new Contenta(mascota.Felicidad));
    }

    public bool PuedeJugar() => true;

    public int ObtenerFelicidad() => 0;
}

