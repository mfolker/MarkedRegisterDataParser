using MarkedRegisterDataParser.Models.Base;

namespace MarkedRegisterDataParser.Models
{
    public class ConnectVoter : BaseMarkedRegisterModel
    {
        public string LocalAuthority { get; set; }

        public string PollingDistrict { get; set; }

        public string PollingNumber { get; set; }

        public string VAN_ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }

        public string Suffix { get; set; }

        public bool Voted { get; set; }

        //PollingDistrict PollingNumber VAN ID LastName    FirstName MiddleName  Suffix Voted? 

    }
}
