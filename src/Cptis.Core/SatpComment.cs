using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents comments related to SATP records.
    /// </summary>
    public class SatpComment
    {
        /// <summary>
        /// Unique identifier for the SATP comment.
        /// </summary>
        public int SatpCommentId { get; set; }

        /// <summary>
        /// Text content of the comment.
        /// </summary>
        public string Comment { get; set; }
    }

}
