//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final_4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacaciones
    {
        public int Id { get; set; }
        public short CodigoE { get; set; }
        public System.DateTime Desde { get; set; }
        public System.DateTime Hasta { get; set; }
        public short Correspondiente { get; set; }
        public string Comentarios { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}
