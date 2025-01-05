using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class CptisUser
    {
        /// <summary>
        /// The system assigned unique identifier for the CPTISUSER
        /// </summary>
        public int CptisUserId { get; set; }

        /// <summary>
        /// User's First Name
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// The User's Last Name
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// The Email Associated with the user's Azure Active Directory account
        /// </summary>
        public string UserEmail { get; set; }



        // Navigation properties
        /// <summary>
        /// List of user Permissions asociated with the user.
        /// </summary>
        public ICollection<CptIsUserPermissions> UserPermissionsList { get; set; }
    }
}
