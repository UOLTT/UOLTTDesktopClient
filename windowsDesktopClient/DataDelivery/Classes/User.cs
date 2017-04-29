using System.Collections.Generic;
// ReSharper disable ConvertToAutoProperty

namespace DataDelivery.Classes
{
    internal class User
    {
        #region Private Internal Storage

        private int _id;
        private string _name;
        private string _userName;
        private string _gameHandle;
        private int? _organisationId;
        private int? _fleedId;
        private int? _squadId;
        private int? _stationId;
        private int? _activeShip;
        private Organization _organization;
        private string _fleet; // To be changed to Fleet later
        private string _squad; // To be changed to Squad later
        private List<Ship> _ships;

        #endregion

        /// <summary>
        /// Unique Identifier for each user
        /// </summary>
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        /// <summary>
        /// The User Name of the selected User, created from uoltt.org
        /// </summary>
        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        /// <summary>
        /// The Users in game User Name
        /// </summary>
        public string Game_Handle
        {
            get => _gameHandle;
            set => _gameHandle = value;
        }
        /// <summary>
        /// The ID of the organisation this user is part of, a look up of the organisation can be done using this ID
        /// </summary>
        public int? Organization_Id
        {
            get => _organisationId;
            set => _organisationId = value;
        }
        /// <summary>
        /// The ID of the fleet this user is part of, a look up of the fleet can be done using this ID
        /// </summary>
        public int? Fleet_Id
        {
            get => _fleedId;
            set => _fleedId = value;
        }
        /// <summary>
        /// The ID of the squad this user is part of, a look up of the squad can be done using this ID
        /// </summary>
        public int? Squad_Id
        {
            get => _squadId;
            set => _squadId = value;
        }
        public int? Station_Id
        {
            get => _stationId;
            set => _stationId = value;
        }
        /// <summary>
        /// ID of the users active ship
        /// </summary>
        public int? Active_Ship
        { 
            get => _activeShip;
            set => _activeShip = value;
        }
        /// <summary>
        /// Organization that the user is part of, this has reduced information over the full Organization data
        /// </summary>
        public Organization Organization
        {
            get => _organization;
            set => _organization = value;
        }
        public string Fleet
        {
            get => _fleet;
            set => _fleet = value;
        }
        public string Squad
        {
            get => _squad;
            set => _squad = value;
        }
        /// <summary>
        /// List of ships that the user owns on their SC account
        /// </summary>
        public List<Ship> Ships
        {
            get => _ships;
            set => _ships = value;
        }
    }
}
