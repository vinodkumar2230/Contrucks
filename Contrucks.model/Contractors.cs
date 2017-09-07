﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class Contractors
    {
        [Key]
        public int PK_ContractorId { get; set; }
        public int PK_UserTableId { get; set; }
        [ForeignKey("FK_UserTableId")]
        public virtual UserTables UserTables { get; set; }

        public int PK_StateId { get; set; }
       // [ForeignKey("FK_StateId")]
        public virtual State State { get; set; }

        public int PK_CityId { get; set; }
       // [ForeignKey("FK_CityId")]
        public virtual City City { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(255)]
        public string ContractorName { get; set; }

        [Required(ErrorMessage = "Valid Age is Required")]
        [Range(18, 120)]
        public int ContractorAge { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(15, ErrorMessage = "Invalid Phone Number")]
        public string ContractorPhone { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
