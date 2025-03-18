namespace Tamagochi.Core;

public class Aburrido
{
    private DateTime tiempoAburrida;

    public Aburrido()
    {
        tiempoAburrida = DateTime.Now;
    }

    public void Comer(Mascota mascota)
    {
        if ((DateTime.Now - tiempoAburrida).TotalMinutes > 80)
        {
            mascota.CambiarEstado(new Alegre(mascota.Felicidad));
        }
    }

    public void Jugar(Mascota mascota)
    {
        mascota.CambiarEstado(new Alegre(mascota.Felicidad));
    }

    public bool PuedeJugar() => true;

    public int ObtenerFelicidad() => 0;
}
