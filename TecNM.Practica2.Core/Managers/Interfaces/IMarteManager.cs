using TecNM.Practica2.Core.Entities;

namespace TecNM.Practica2.Core.Managers.Interfaces;

public interface IMarteManager{
    Marte GetMarte(Person person);
}