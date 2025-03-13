using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scr.Tamagochi.Core;

public interface IEstadoMascota
{
    void Comer(MascotaVirtual mascota);
    void Jugar(MascotaVirtual mascota);
    bool PuedeJugar();
    int ObtenerFelicidad();
}


