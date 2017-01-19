using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDelivery
{
    /// <summary>
    /// Enum used, the lookup values are then stored in XXX where the request is then made.
    //TODO: include lookup for enum values
    /// </summary>
    internal enum GetCalls
    {

        /// <summary>
        /// Returns the stats for a singular Organisation,
        /// requests for a single Organisation must be proceeded by the orgs ID.
        /// UserIDs are provided but must be linked with a User for that Users information. This can be requested using the <see cref="IndividualUser"/> request
        /// </summary>
        IndividualOrg = 1,

        /// <summary>
        /// Returns the complete stats for a singular Ship,
        /// requests for a single Ship must be proceeded by the ships ID
        /// </summary>
        IndividualShip = 2,

        /// <summary>
        /// Returns the complete stats for a singular User,
        /// requests for a single User must be proceeded by the ships ID
        /// </summary>
        IndividualUser = 3,

        /// <summary>
        /// Returns a complete list of Ships with a limited amount of data.
        /// For a Ships complete stats, use the <see cref="IndividualShip"/> request
        /// </summary>
        ListOfShips = 4,

        /// <summary>
        /// Returns a complete list of Organisations with a limited amount of stats
        /// For an Organisations complete stats, use the <see cref="IndividualOrg"/> request
        /// </summary>
        ListOfOrgs = 5,

        /// <summary>
        /// Returns a complete list of Users with a limited amount of stats
        /// For an Users complete stats, use the <see cref="IndividualUser"/> request
        /// </summary>
        ListOfUsers = 6,

    };
}

