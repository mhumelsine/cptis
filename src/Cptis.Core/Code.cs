using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class Code
    {
        public int CodeId { get; set; }
        public string CodeType { get; set; }
        public string CodeName { get; set; }
        public string CodeDescription { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();
        public string CodeActive { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
