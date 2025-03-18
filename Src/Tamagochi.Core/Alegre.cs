using Tamagochi.Core.Persitencia;

namespace Tamagochi.Core;

public class Alegre : IEstadoMascota
{
    private int vecesJugadas = 0;

    public int Felicidad { get; private set; }

    public Alegre (int felicidadInicial = 0)
    {
        Felicidad = felicidadInicial;
    }

    public void Comer(MascotaVirtual mascota)
    {
        Felicidad++;
    }

    public void Jugar(MascotaVirtual mascota)
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
