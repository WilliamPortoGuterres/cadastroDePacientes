﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cadastroDePacientes.Ressource
{
    public partial class colaboradores
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id_colaboradores { get; set; }
        [Required]
        [StringLength(40)]
        public string nomecolaborador { get; set; }
        [Required]
        [StringLength(20)]
        public string nickcolaborador { get; set; }
        [Required]
        [StringLength(40)]
        public string emailcolaborador { get; set; }
        [Required]
        [StringLength(20)]
        public string senhacolaborador { get; set; }
        [Required]
        [StringLength(120)]
        public string enderecocolaborador { get; set; }
        [Required]
        [StringLength(20)]
        public string telefonecolaborador { get; set; }
        [Required]
        [StringLength(20)]
        public string funcaocolaborador { get; set; }
        [Required]
        [StringLength(20)]
        public string cns { get; set; }
        [Required]
        [StringLength(20)]
        public string cbo { get; set; }
        [Required]
        [StringLength(40)]
        public string especialidade { get; set; }
        [Required]
        [StringLength(4)]
        public string atendimentotr { get; set; }
    }
}