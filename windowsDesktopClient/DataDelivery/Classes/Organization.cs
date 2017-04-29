// ReSharper disable ConvertToAutoProperty

namespace DataDelivery.Classes
{
    internal class Organization
    {

        #region Private Internal Storage

        private int _id;
        public string _name;
        private string _domain;
        private int _adminUserId;
        private int _statusId;
        private string _manifesto;
        private string _createdAt;
        private string _updatedAt;
        private int _fleedCount;
        private int _userCount;
        private int _squadCount;

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
        public string Domain
        {
            get => _domain;
            set => _domain = value;
        }
        public int Admin_User_Id
        {
            get => _adminUserId;
            set => _adminUserId = value;
        }
        public int Status_Id
        {
            get => _statusId;
            set => _statusId = value;
        }
        public string Manifesto
        {
            get => _manifesto;
            set => _manifesto = value;
        }
        public string Created_At
        {
            get => _createdAt;
            set => _createdAt = value;
        }
        public string Updated_At
        {
            get => _updatedAt;
            set => _updatedAt = value;
        }
        public int Fleet_Count
        {
            get => _fleedCount;
            set => _fleedCount = value;
        }
        public int User_Count
        {
            get => _userCount;
            set => _userCount = value;
        }
        public int Squad_Count
        {
            get => _squadCount;
            set => _squadCount = value;
        }
    }
}
