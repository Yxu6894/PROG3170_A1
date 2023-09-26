using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GreetingService
{
    

    [ServiceContract]
    public interface IGreetingService
    {
        [OperationContract]
        GreetingResponse Greet(GreetingRequest request);

        [OperationContract]
        List<string> GetAllTimesOfDay();

        [OperationContract]
        List<string> GetSupportedLanguages();
    }

}
