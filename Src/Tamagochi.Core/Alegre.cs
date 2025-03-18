namespace Tamagochi.Core;

public class Alegre : IEstadoMascota
{
    private int vecesJugadas;

    public int Felicidad { get; private set; }

    public Alegre (int felicidadInicial)
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
            mascota.CambiarEstado(new Hambriento());
        }
    }

    public bool PuedeJugar() => true;

    public int ObtenerFelicidad() => Felicidad;
}
