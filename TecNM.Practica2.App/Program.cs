using System;
using TecNM.Practica2.Core;
using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers;
using TecNM.Practica2.Core.Services;

namespace TecNM.Practica2.App;

public static class Program{
    public static void Main(string[] args){
        float personPeso;

        System.Console.WriteLine("Peso en la tierra: ");
        Single.TryParse(System.Console.ReadLine(), out personPeso);

        var person = new Person{peso = personPeso};
        var service = new MarteService();
        var manager = new MarteManager(service);

        Marte marte = manager.GetMarte(person);

        System.Console.WriteLine($"Peso en marte: {marte.pesoMarte}");
    }
}
