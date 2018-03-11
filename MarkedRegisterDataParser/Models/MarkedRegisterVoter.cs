using MarkedRegisterDataParser.Models.Base;

namespace MarkedRegisterDataParser.Models
{
    public class MarkedRegisterVoter : BaseMarkedRegisterModel
    {
        public string WardCode { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        //Code to break up name into first and last

        //Code to break up address into key identifier parts (building name/number, outer postcode, inner postcode).


    }
}