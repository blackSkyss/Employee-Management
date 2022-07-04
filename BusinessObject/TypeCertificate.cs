using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class TypeCertificate
    {
        public TypeCertificate()
        {
            Certificates = new HashSet<Certificate>();
        }

        public int IdTypeCer { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Certificate> Certificates { get; set; }
    }
}
