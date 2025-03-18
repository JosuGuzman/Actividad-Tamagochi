namespace Tamagochi.Core;

public class Hambriento : IEstadoMascota
{
    public void Comer(Mascota mascota)
    {
        mascota.CambiarEstado(new Alegre(mascota.Felicidad));
    }

    public void Jugar(Mascota mascota)
    {
        // No hace nada, no puede jugar si está hambrienta.
    }

    public bool PuedeJugar() => false;

    public int ObtenerFelicidad() => 0;
}
