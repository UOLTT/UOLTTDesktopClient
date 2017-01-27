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
            get { return _id; }
            set { _id = value; }
        }
        public string ShipName
        {
            get { return _shipName; }
            set { _shipName = value; }
        }
        public int? Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public int? Beam
        {
            get { return _beam; }
            set { _beam = value; }
        }
        public int? Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int? NullMass
        {
            get { return _nullMass; }
            set { _nullMass = value; }
        }
        public int? CargoCapacity
        {
            get { return _cargoCapacity; }
            set { _cargoCapacity = value; }
        }
        public int? Crew
        {
            get { return _crew; }
            set { _crew = value; }
        }
        public int? PowerPlant
        {
            get { return _powerPlant; }
            set { _powerPlant = value; }
        }
        public int? PowerCount
        {
            get { return _powerCount; }
            set { _powerCount = value; }
        }
        public int? Primary
        {
            get { return _primary; }
            set { _primary = value; }
        }
        public int? PCount
        {
            get { return _pCount; }
            set { _pCount = value; }
        }
        public int? Maneuvering
        {
            get { return _manouvering; }
            set { _manouvering = value; }
        }
        public int? ManCount
        {
            get { return _manCount; }
            set { _manCount = value; }
        }
        public int? Shield
        {
            get { return _shield; }
            set { _shield = value; }
        }
        public int? ShieldCount
        {
            get { return _shieldCount; }
            set { _shieldCount = value; }
        }
        public string RaceEnabled
        {
            get { return _raceEnabled; }
            set { _raceEnabled = value; }
        }
        public int? Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public int? CombatSpeed
        {
            get { return _combatSpeed; }
            set { _combatSpeed = value; }
        }
        public int? CombatRating
        {
            get { return _combatRating; }
            set { _combatRating = value; }
        }
        public int? WaveRank
        {
            get { return _waveRank; }
            set { _waveRank = value; }
        }
        public List<Stations> Stations
        {
            get { return _stations; }
            set { _stations = value; }
        }
        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }
    }
}
