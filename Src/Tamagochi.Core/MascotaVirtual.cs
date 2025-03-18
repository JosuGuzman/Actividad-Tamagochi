namespace Tamagochi.Core;

public class MascotaVirtual
{
    private IEstadoMascota estadoActual;
    public int Felicidad => estadoActual.ObtenerFelicidad();

    public Mascota()
    {
        estadoActual = new Aburrida();
    }

    public void CambiarEstado(IEstadoMascota nuevoEstado)
    {
        estadoActual = nuevoEstado;
    }

    public void Comer()
    {
        estadoActual.Comer(this);
    }

    public void Jugar()
    {
        if (estadoActual.PuedeJugar())
        {
            estadoActual.Jugar(this);
        }
    }

    public bool PuedeJugar()
    {
        return estadoActual.PuedeJugar();
    }
}
