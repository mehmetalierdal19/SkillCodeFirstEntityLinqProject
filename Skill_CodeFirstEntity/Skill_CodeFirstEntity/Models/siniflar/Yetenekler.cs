﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.siniflar
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        public string ACIKLAMA { get; set; }
        public int DEGER { get; set; }
    }
}