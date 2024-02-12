using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Services;

public class MarteService : IMarteService{
    public Marte ProcessPesoMarte(Person person){
        var marte = new Marte();

        marte.pesoMarte = (person.peso/9.81) *3.71;
        
        return marte;
    }

}