namespace DataDelivery
{
    public class GetDataRequests
    {
        /// <summary>
        /// Creates the GET request string that is then consumed by the windows form.
        /// </summary>
        /// <param name="requestEnum">Enum value passed in to identify the request that is needed</param>
        /// <param name="id">OPTIONAL Parameter used for Individual requests where a specific Id is needed to identify which object to return</param>
        /// <returns></returns>
        internal static string RetrieveGETStringRequest(GetCalls requestEnum, int? id = null)
        {
            string getString = "";
            switch (requestEnum)
            {
                case GetCalls.IndividualOrg:
                    if (id.HasValue)
                    {
                        getString = "http://api.uoltt.org/api/v4/organizations/" + id;
                    }
                    break;
                case GetCalls.IndividualShip:
                    if (id.HasValue)
                    {
                        getString = "http://api.uoltt.org/api/v4/ships/" + id;
                    }
                    break;
                case GetCalls.IndividualUser:
                    if (id.HasValue)
                    {
                        getString = "http://api.uoltt.org/api/v4/users/" + id;
                    }
                    break;
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
    }
}

