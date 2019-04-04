using System.Collections.Generic;

namespace Modelo
{
    public class Receta
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public string Instrucciones { get; set; }
    }
}
