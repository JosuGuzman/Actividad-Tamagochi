using Tamagochi.Core.Persitencia;

namespace Tamagochi.Core;

public class Aburrido : IEstadoMascota
{
    private DateTime tiempoAburrida;

    public Aburrido() => tiempoAburrida = DateTime.Now;

    public void Comer(MascotaVirtual mascota)
    {
        if ((DateTime.Now - tiempoAburrida).TotalMinutes > 80)
            mascota.CambiarEstado(new Alegre(mascota.Felicidad));
    }

    public void Jugar(MascotaVirtual mascota)
        => mascota.CambiarEstado(new Alegre(mascota.Felicidad));

    public bool PuedeJugar() => true;

    public int ObtenerFelicidad() => 0;
}
