using Tamagochi.Core;

public class TamagochiTest
{
    [Fact]
    public void Jugar_Desde_Aburrida_A_Contenta()
    {
        var mascota = new MascotaVirtual();
        
        mascota.Jugar();
        
        Assert.True(mascota.PuedeJugar());
        Assert.Equal(0, mascota.Felicidad);
    }

    [Fact]
    public void Comer_Desde_Hambrienta_A_Contenta()
    {
        var mascota = new MascotaVirtual();
        mascota.CambiarEstado(new Hambriento());
        
        mascota.Comer();
        
        Assert.True(mascota.PuedeJugar());
    }

    [Fact]
    public void Jugar_MasDeCincoVeces_DesdeContenta_PasaAHambrienta()
    {
        var mascota = new MascotaVirtual();
        mascota.CambiarEstado(new Alegre(0));
        
        for (int i = 0; i < 6; i++)
        {
            mascota.Jugar();
        }
        
        Assert.False(mascota.PuedeJugar());
    }
}