

namespace DataDelivery
{
    public class GetDataRequests
    {
        /// <summary>
        /// Creates the GET request string that is then consumed by the windows form.
        /// </summary>
        /// <param name="requestEnum">Enum value passed in to identify the request that is needed</param>
        /// <returns>String containing the URL for a GET request</returns>
        internal static string RetrieveGetStringRequest(GetCalls requestEnum)
        {
            string getString = "";
            switch (requestEnum)
            {
                case GetCalls.ListOfOrgs:
                    getString = "http://api.uoltt.org/api/v4/organizations";
                    break;
                case GetCalls.ListOfShips:
                    getString = "http://api.uoltt.org/api/v4/ships";
                    break;
                case GetCalls.ListOfUsers:
                    getString = "http://api.uoltt.org/api/v4/users";
                    break;
                default:
                    break;
            }
            return getString;
        }

        /// <summary>
        /// Overload of <see cref="RetrieveGETStringRequest(GetCalls)"/> that takes an Id to call invididual items
        /// rather than a full list of items
        /// </summary>
        /// <param name="requestEnum">Enum value passed in to identify the request that is needed</param>
        /// <param name="id">ID value of the item that is requested from the Enum request</param>
        /// <returns>String containing the URL for a GET request</returns>
        internal static string RetrieveGetStringRequest(GetCalls requestEnum, int id)
        {
            string getString = "";
            switch (requestEnum)
            {
                case GetCalls.IndividualOrg:
                        getString = "http://api.uoltt.org/api/v4/organizations/" + id;
                    break;
                case GetCalls.IndividualShip:
                        getString = "http://api.uoltt.org/api/v4/ships/" + id;
                    break;
                case GetCalls.IndividualUser:
                        getString = "http://api.uoltt.org/api/v4/users/" + id;
                    break;
            }
            return getString;
        }
    }
}

