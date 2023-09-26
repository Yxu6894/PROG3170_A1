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
        private Dictionary<string, Dictionary<string, Dictionary<string, string>>> greetings = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>
{
    {"Morning", new Dictionary<string, Dictionary<string, string>>
        {
            {"English", new Dictionary<string, string>
                {
                    {"Formal", "Good Morning"},
                    {"Casual", "Hey"}
                }
            },
            {"Spanish", new Dictionary<string, string>
                {
                    {"Formal", "Buenos días"},
                    {"Casual", "Hola"}
                }
            },
            {"French", new Dictionary<string, string>
                {
                    {"Formal", "Bonjour"},
                    {"Casual", "Salut"}
                }
            }
        }
    },
    {"Afternoon", new Dictionary<string, Dictionary<string, string>>
        {
            {"English", new Dictionary<string, string>
                {
                    {"Formal", "Good Afternoon"},
                    {"Casual", "What's up?"}
                }
            },
            {"Spanish", new Dictionary<string, string>
                {
                    {"Formal", "Buenas tardes"},
                    {"Casual", "¿Qué tal?"}
                }
            },
            {"French", new Dictionary<string, string>
                {
                    {"Formal", "Bon après-midi"},
                    {"Casual", "Coucou"}
                }
            }
        }
    },
    {"Evening", new Dictionary<string, Dictionary<string, string>>
        {
            {"English", new Dictionary<string, string>
                {
                    {"Formal", "Good Evening"},
                    {"Casual", "Hey there"}
                }
            },
            {"Spanish", new Dictionary<string, string>
                {
                    {"Formal", "Buenas noches"},
                    {"Casual", "Hola otra vez"}
                }
            },
            {"French", new Dictionary<string, string>
                {
                    {"Formal", "Bonsoir"},
                    {"Casual", "Rebonsoir"}
                }
            }
        }
    }
};


        public GreetingResponse Greet(GreetingRequest request)
        {
            if (greetings.ContainsKey(request.TimeOfDay)
                && greetings[request.TimeOfDay].ContainsKey(request.Language)
                && greetings[request.TimeOfDay][request.Language].ContainsKey(request.Tone ?? "Formal"))
            {
                return new GreetingResponse
                {
                    TimeOfDay = request.TimeOfDay,
                    Language = request.Language,
                    Tone = request.Tone ?? "Formal",
                    Greeting = greetings[request.TimeOfDay][request.Language][request.Tone ?? "Formal"]
                };
            }
            throw new FaultException($"Unsupported TimeOfDay, Language, or Tone: {request.TimeOfDay}, {request.Language}, {request.Tone}");
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
