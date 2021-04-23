﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Protus.DTOS
{
    public class TopicDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Display(Name="Course")]
        public int? CourseId { get; set; }

    }
}
