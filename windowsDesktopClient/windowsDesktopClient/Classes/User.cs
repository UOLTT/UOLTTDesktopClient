using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Game_Handle { get; set; }
        public int? Organisation_Id { get; set; }
        public int? Fleed_Id { get; set; }
        public int? Squad_Id { get; set; }
        public int? Station_Id { get; set; }
        public int? Active_Ship { get; set; }
        public List<Organisation> Organisation { get; set; }
        public string Fleet { get; set; }
        public string Squad { get; set; }
        public List<Ship> Ships { get; set; }
    }
}
