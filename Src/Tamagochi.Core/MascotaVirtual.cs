using Tamagochi.Core.Persitencia;
namespace Tamagochi.Core;

public class MascotaVirtual
{
    private IEstadoMascota estadoActual;
    public int Felicidad => estadoActual.ObtenerFelicidad();

    public MascotaVirtual()
    {
        estadoActual = new Aburrido();
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
