using Tamagochi.Core.Persitencia;

namespace Tamagochi.Core;

public class Hambriento : IEstadoMascota
{
    public void Comer(MascotaVirtual mascota)
    {
        mascota.CambiarEstado(new Alegre(mascota.Felicidad));
    }

    public void Jugar(MascotaVirtual mascota)
    {
        // No hace nada, no puede jugar si está hambrienta.
    }

    public bool PuedeJugar() => false;

    public int ObtenerFelicidad() => 0;

}
