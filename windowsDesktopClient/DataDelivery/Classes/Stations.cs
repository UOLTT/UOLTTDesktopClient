// ReSharper disable ConvertToAutoProperty

namespace DataDelivery.Classes
{
    internal class Stations
    {
        #region Private Internal Storage

        private int _id;
        private string _name;
        private string _description;

        #endregion

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
        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}
