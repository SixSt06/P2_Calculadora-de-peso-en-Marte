using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers.Interfaces;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Managers;

public class MarteManager : IMarteManager{
    private readonly  IMarteService _service;

    public MarteManager(IMarteService service){
        _service = service;
    }

    public Marte GetMarte(Person person){
        return _service.ProcessPesoMarte(person);
    }
}