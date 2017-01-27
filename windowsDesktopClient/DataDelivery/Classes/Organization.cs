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
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }
        public int Admin_User_Id
        {
            get { return _adminUserId; }
            set { _adminUserId = value; }
        }
        public int Status_Id
        {
            get { return _statusId; }
            set { _statusId = value; }
        }
        public string Manifesto
        {
            get { return _manifesto; }
            set { _manifesto = value; }
        }
        public string Created_At
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        public string Updated_At
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
        public int Fleet_Count
        {
            get { return _fleedCount; }
            set { _fleedCount = value; }
        }
        public int User_Count
        {
            get { return _userCount; }
            set { _userCount = value; }
        }
        public int Squad_Count
        {
            get { return _squadCount; }
            set { _squadCount = value; }
        }
    }
}
