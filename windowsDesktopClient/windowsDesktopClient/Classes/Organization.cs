using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient.Classes
{
    internal class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int Admin_User_Id { get; set; }
        public int Status_Id { get; set; }
        public string Manifesto { get; set; }
        public string Created_At { get; set; }
        public string Updated_At { get; set; }
        public int Fleet_Count { get; set; }
        public int User_Count { get; set; }
        public int Squad_Count { get; set; }
    }
}
