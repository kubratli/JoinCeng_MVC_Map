namespace JoinCeng_MVC_Map.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ilce")]
    public partial class Ilce
    {
        public int IlceID { get; set; }

        [StringLength(50)]
        public string IlceAdi { get; set; }
    }
}
