namespace ChatJOYA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int id { get; set; }

        public int idUser { get; set; }

        [Required]
        [StringLength(100)]
        public string text { get; set; }

        public int idRoom { get; set; }

        public virtual Room Room { get; set; }

        public virtual User User { get; set; }
    }
}
