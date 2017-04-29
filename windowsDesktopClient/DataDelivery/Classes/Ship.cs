using System.Collections.Generic;
// ReSharper disable ConvertToAutoProperty

namespace DataDelivery.Classes
{
    /// <summary>
    /// Ship Class used for deserialising Json string
    /// </summary>
    internal class Ship
    {

        #region Private Intenal Storage

        private int _id;
        private string _shipName;
        private int? _length;
        private int? _beam;
        private int? _height;
        private int? _nullMass;
        private int? _cargoCapacity;
        private int? _crew;
        private int? _powerPlant;
        private int? _powerCount;
        private int? _primary;
        private int? _pCount;
        private int? _manouvering;
        private int? _manCount;
        private int? _shield;
        private int? _shieldCount;
        private string _raceEnabled;
        private int? _price;
        private string _class;
        private int? _combatSpeed;
        private int? _combatRating;
        private int? _waveRank;
        private List<Stations> _stations;
        private List<User> _users;

        #endregion

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string ShipName
        {
            get => _shipName;
            set => _shipName = value;
        }
        public int? Length
        {
            get => _length;
            set => _length = value;
        }
        public int? Beam
        {
            get => _beam;
            set => _beam = value;
        }
        public int? Height
        {
            get => _height;
            set => _height = value;
        }
        public int? NullMass
        {
            get => _nullMass;
            set => _nullMass = value;
        }
        public int? CargoCapacity
        {
            get => _cargoCapacity;
            set => _cargoCapacity = value;
        }
        public int? Crew
        {
            get => _crew;
            set => _crew = value;
        }
        public int? PowerPlant
        {
            get => _powerPlant;
            set => _powerPlant = value;
        }
        public int? PowerCount
        {
            get => _powerCount;
            set => _powerCount = value;
        }
        public int? Primary
        {
            get => _primary;
            set => _primary = value;
        }
        public int? PCount
        {
            get => _pCount;
            set => _pCount = value;
        }
        public int? Maneuvering
        {
            get => _manouvering;
            set => _manouvering = value;
        }
        public int? ManCount
        {
            get => _manCount;
            set => _manCount = value;
        }
        public int? Shield
        {
            get => _shield;
            set => _shield = value;
        }
        public int? ShieldCount
        {
            get => _shieldCount;
            set => _shieldCount = value;
        }
        public string RaceEnabled
        {
            get => _raceEnabled;
            set => _raceEnabled = value;
        }
        public int? Price
        {
            get => _price;
            set => _price = value;
        }
        public string Class
        {
            get => _class;
            set => _class = value;
        }
        public int? CombatSpeed
        {
            get => _combatSpeed;
            set => _combatSpeed = value;
        }
        public int? CombatRating
        {
            get => _combatRating;
            set => _combatRating = value;
        }
        public int? WaveRank
        {
            get => _waveRank;
            set => _waveRank = value;
        }
        public List<Stations> Stations
        {
            get => _stations;
            set => _stations = value;
        }
        public List<User> Users
        {
            get => _users;
            set => _users = value;
        }
    }
}
