﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ENT.ParentEntities
{
    public class GenericEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get { return DateTime.Now; } }
    }
}
