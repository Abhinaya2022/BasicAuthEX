using System;
using System.Collections.Generic;

#nullable disable

namespace PatientMVC.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appiontments = new HashSet<Appiontment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public virtual ICollection<Appiontment> Appiontments { get; set; }
    }
}
