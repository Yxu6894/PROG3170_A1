using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GreetingService
{
    [DataContract]
    public class GreetingResponse : GreetingRequest
    {
        [DataMember(IsRequired = true)]
        public string Greeting { get; set; }
    }
}
