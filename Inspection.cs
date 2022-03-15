﻿using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Commnets { get; set; } = string.Empty;

        public int InspectionId { get; set; }

        public InspectionType? InspectionType { get; set; }


    }
}
