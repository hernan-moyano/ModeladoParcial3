using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEvaluacion.Shared.Datos.Entidades
{
    [Index(nameof(dni), Name = "UQ_Persona_dni", IsUnique = true)]
    public class Persona
    {
        public int Id { get; set; }

        [Display(Name = "DNI")]
        [Required(ErrorMessage = "El dni es requerido")]
        public int dni { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El Apellido es requerido")]
        public string apellido { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Fecha de nacimiento es requerida")]
        public DateTime fecha_nacimiento { get; set; }


    }

}
