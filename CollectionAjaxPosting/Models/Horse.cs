﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollectionAjaxPosting.Models
{
    public class Race
    {
        public Race() { HorsesInRace = new List<Horse>(); }

        [Display(Name = "Race Name"), Required]
        public string RaceName { get; set; }

        [Display(Name = "Horses In Race")]
        public List<Horse> HorsesInRace { get; set; }
    }

    public class Horse
    {
        [Display(Name = "Horse's Name"), Required]
        public string Name { get; set; }

        [Display(Name = "Horse's Age"), Required]
        public int Age { get; set; }
    }
}