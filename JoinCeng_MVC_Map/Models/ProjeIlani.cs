namespace JoinCeng_MVC_Map.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjeIlani")]
    public partial class ProjeIlani
    {
        [Key]
        public int ProjeID { get; set; }

        [StringLength(50)]
        public string ProjeBasligi { get; set; }

        public string Aciklama { get; set; }

        [StringLength(50)]
        public string ProjeSektoru { get; set; }

        [StringLength(50)]
        public string ProjeMaas { get; set; }

        [StringLength(50)]
        public string ProjeIsTuru { get; set; }

        public string Adres { get; set; }

        [StringLength(50)]
        public string Enlem { get; set; }

        [StringLength(50)]
        public string Boylam { get; set; }

        public int? KategoriID { get; set; }

        public int? KullaniciID { get; set; }

        public int? IlID { get; set; }

        public int? IlceID { get; set; }
    }
}
