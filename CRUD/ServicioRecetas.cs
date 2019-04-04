using Modelo;
using System;
using System.Collections.Generic;

namespace CRUD
{
    public class ServicioRecetas
    {
        private static List<Receta> _dbRecetas = new List<Receta>()
        {
            new Receta() { Id = 0, Ingredientes = new List<Ingrediente>()
            {
                new Ingrediente() { Id = 0, Nombre = "Remolacha" },
                new Ingrediente() {Id = 1, Nombre = "Queso"}
            },
             Instrucciones = "Pelar la remolacha. Hervirla y servirla en un plato. Tirarle el queso",  Nombre = "Remolacha al soque"},

            new Receta() { Id = 1, Ingredientes = new List<Ingrediente>()
            {
                new Ingrediente() { Id = 2, Nombre = "Papa" },
                new Ingrediente() {Id = 3, Nombre = "Leche"}
            },
             Instrucciones = "Pelar la papa. Hervirla y servirla en un plato. Echarle leche y pisarla",  Nombre = "Puré"}
        };


    }
}
