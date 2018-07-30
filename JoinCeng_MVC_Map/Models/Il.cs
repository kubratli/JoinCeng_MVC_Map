namespace JoinCeng_MVC_Map.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Il")]
    public partial class Il
    {
        public int IlID { get; set; }

        [StringLength(50)]
        public string IlAdi { get; set; }
    }
}
