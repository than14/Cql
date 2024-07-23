using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp
{
    internal class PageModel
    {

        public string idP { get; set; }
        public string nameP { get; set; }
        public Nullable<int> FollowCount { get; set; }
        public Nullable<int> VideoCount { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<bool> Adbreak { get; set; }
        public Nullable<bool> Reel { get; set; }
        public Nullable<bool> Bonus { get; set; }
        public Nullable<bool> RightManager { get; set; }
        public Nullable<bool> Verified { get; set; }
        public string countryP { get; set; }
        public string languageP { get; set; }
        public string Topic { get; set; }
        public string CHECKidSA { get; set; }
        public string idAC { get; set; }


    }
}
