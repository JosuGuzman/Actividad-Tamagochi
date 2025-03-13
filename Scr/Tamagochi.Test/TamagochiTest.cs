using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Scr.Tamagochi.Core;

namespace Scr.Tamagochi.Test;

public class TamagochiTest
{
    using System;
using Xunit;

public class MascotaTests
{
    [Fact]
    public void Jugar_Desde_Aburrida_A_Contenta()
    {
        var mascota = new Mascota();
        
        mascota.Jugar();
        
        Assert.True(mascota.PuedeJugar());
        Assert.Equal(0, mascota.Felicidad);
    }
    
    [Fact]
    public void Comer_Desde_Hambrienta_A_Contenta()
    {
        var mascota = new Mascota();
        mascota.CambiarEstado(new Hambrienta());
        
        mascota.Comer();
        
        Assert.True(mascota.PuedeJugar());
    }
    
    [Fact]
    public void Jugar_MasDeCincoVeces_DesdeContenta_PasaAHambrienta()
    {
        var mascota = new Mascota();
        mascota.CambiarEstado(new Contenta(0));
        
        for (int i = 0; i < 6; i++)
        {
            mascota.Jugar();
        }
        
        Assert.False(mascota.PuedeJugar());
    }

}