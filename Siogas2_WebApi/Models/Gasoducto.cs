using System.ComponentModel.DataAnnotations;

namespace Siogas2_webapi.Models
{   

    public class Gasoducto  
    {
        [Key] public int Gasoducto_id { get; set; }
        
        
        public string? Nombre { get; set ; }
        public string? Descripcion { get; set; }

       
    }


}
