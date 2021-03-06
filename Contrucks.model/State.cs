﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
      
        public virtual string StateName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual string Deleted { get; set; }
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }


        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Truckers> Truckers { get; set; }
        public virtual ICollection<Contractors> Contractors { get; set; }


    }
}
