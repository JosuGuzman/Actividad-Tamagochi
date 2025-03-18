namespace Tamagochi.Core.Persitencia;

public interface IEstadoMascota
{
    void Comer(MascotaVirtual mascota);
    void Jugar(MascotaVirtual mascota);
    bool PuedeJugar();
    int ObtenerFelicidad();
}
