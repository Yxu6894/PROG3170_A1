using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingService
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    public class GreetingServiceType : IGreetingService
    {
        private Dictionary<string, Dictionary<string, string>> greetings = new Dictionary<string, Dictionary<string, string>>
    {
        {"Morning", new Dictionary<string, string>
            {
                {"English", "Good Morning"},
                {"Spanish", "Buenos días"},
                {"French", "Bonjour"}
            }
        },
        {"Afternoon", new Dictionary<string, string>
            {
                {"English", "Good Afternoon"},
                {"Spanish", "Buenas tardes"},
                {"French", "Bon après-midi"}
            }
        },
        {"Evening", new Dictionary<string, string>
            {
                {"English", "Good Evening"},
                {"Spanish", "Buenas noches"},
                {"French", "Bonsoir"}
            }
        }
    };

        public GreetingResponse Greet(GreetingRequest request)
        {
            if (greetings.ContainsKey(request.TimeOfDay) && greetings[request.TimeOfDay].ContainsKey(request.Language))
            {
                return new GreetingResponse
                {
                    TimeOfDay = request.TimeOfDay,
                    Language = request.Language,
                    Greeting = greetings[request.TimeOfDay][request.Language]
                };
            }
            throw new FaultException($"Unsupported TimeOfDay or Language: {request.TimeOfDay}, {request.Language}");
        }

        public List<string> GetAllTimesOfDay()
        {
            return new List<string> { "Morning", "Afternoon", "Evening" };
        }

        public List<string> GetSupportedLanguages()
        {
            return new List<string> { "English", "Spanish", "French" };
        }
    }

}
