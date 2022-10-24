using System.ComponentModel.DataAnnotations;

namespace web_api_empleado.Models{
public class Empleados{
        [Key]
        public int id_empleado {get; set;}
        public string nombres {get; set;}
        public string apellidos {get; set;}
        public string direccion {get; set;}
        public string telefono {get; set;}
        public string id_puesto {get; set;}
        public string DPI {get; set;}
        public string fecha_nacimiento {get; set;}
        public string FechaIngresoRegistro {get; set;}
        
}

}