namespace WebASPNETFrameworkt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NASCIMENTO { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(14)]
        public string TELEFONE { get; set; }

        [StringLength(60)]
        public string ENDERECO { get; set; }
    }
}
