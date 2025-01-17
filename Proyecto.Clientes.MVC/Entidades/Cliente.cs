﻿using System.ComponentModel.DataAnnotations;
namespace Proyecto.Clientes.MVC.Entidades
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Nombre { get; set; }
        [MaxLength(100)]
        public string? Apellido { get; set; }
        public int? Antiguedad { get; set; }
    }
}
