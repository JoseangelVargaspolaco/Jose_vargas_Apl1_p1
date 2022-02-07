using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Jose_vargas_Apl1_p1.Entidades
{
    public class Productos
    {
        [Key] public int Productoid {get; set;}

        public string? Descripcion {get; set;}

        public string? Existencia {get; set;}

        public int Costo {get; set;}

        public float ValorInventario {get; set;}

    }
}
