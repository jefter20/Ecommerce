﻿using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_COMPRA_USUARIO")]
    public class CompraUsuario : Notifies
    {
        [Column("CUS_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("TB_PRODUCT")]
        [Column(Order = 1)]
        public int ProdutoId { get; set; }
        public virtual Product? Produto { get; set; }

        [Column("CUS_ESTADO")]
        [Display(Name = "Estado")]
        public EstadoCompra Estado { get; set; }

        [Column("CUS_QTD")]
        [Display(Name = "Quantidade")]
        public int QtdCompra { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("AplicationUser")]
        [Column(Order = 4)]
        public string? UserId { get; set; }
        public virtual AplicationUser? AplicationUser { get; set; }
    }
}
