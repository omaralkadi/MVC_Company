﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [MinLength(5)]
        public string Name { get; set; }
        [Column(TypeName = "Money")]
        public decimal Salary { get; set; }
        [Range(20, 60)]
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public Department? departnment { get; set; }
        public int? DepartmentId { get; set; }

    }
}
