﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.CodeFirst.Entities
{
    // This is a hand-crafted entity/class. We create/maintain these ourselves in Code-First
    public class Customer
    {
        // By default conventions, EF will treat "CustomerId" 
        // as a primary Key in the database AND an Identity column 
        // in the database with a default seed and increment of 1.
        public int CustomerId { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped] // Tell EF not to expect a column in the DB table
        public string FormalName
        { get { return LastName + ", " + FirstName; } }

        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public string FullName { get; set; }

        // navigation properties
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual ContactDetail ContacDetail { get; set; }
    }
}
