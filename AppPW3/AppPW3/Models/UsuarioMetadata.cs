﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppPW3.Entidades
{
    internal class UsuarioMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsuarioMetadata()
        {
            this.Carpeta = new HashSet<Carpeta>();
            this.Tarea = new HashSet<Tarea>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "El email no es válido.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")] //falta validar que tenga lo puesto ahi
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{3,20}$", ErrorMessage = "La contraseña debe contener un número, una letra mayúscula y una letra minúscula.")]
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }

        [Display(Name = "Activo")]
        public short Activo { get; set; }

        [Display(Name = "Fecha de Registración")]
        public System.DateTime FechaRegistracion { get; set; }

        [Display(Name = "Fecha de Activación")]
        public Nullable<System.DateTime> FechaActivacion { get; set; }

        [Display(Name = "Código de Activación")]
        public string CodigoActivacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carpeta> Carpeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarea> Tarea { get; set; }
    }
}