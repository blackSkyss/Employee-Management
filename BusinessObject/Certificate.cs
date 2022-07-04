using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Certificate
    {
        public int CerId { get; set; }
        public string CerName { get; set; }
        public DateTime? Doi { get; set; }
        public int? IdEmp { get; set; }
        public int? IdTypeCer { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual TypeCertificate IdTypeCerNavigation { get; set; }
    }
}
