using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace GreetingService
{

    [DataContract]
    public class GreetingRequest
    {
        [DataMember(IsRequired = true)]
        public string TimeOfDay { get; set; }

        [DataMember(IsRequired = true)]
        public string Language { get; set; }
    }



}
