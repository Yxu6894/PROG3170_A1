import zeep

# Setup the client with the WSDL of your service
client = zeep.Client(wsdl='http://localhost:8082/GreetingService/?singleWsdl')


def main():
    print("Supported Times of Day:", client.service.GetAllTimesOfDay())
    print("Supported Languages:", client.service.GetSupportedLanguages())

    time_of_day = input("Enter Time of Day (e.g., Morning, Afternoon, Evening): ")
    language = input("Enter Language of choice (e.g., English, French, Spanish): ")
    tone = input("Enter Tone (Formal/Casual or leave empty for default): ")

    # Using the Greet service
    greeting_response = client.service.Greet({
        'TimeOfDay': time_of_day,
        'Language': language,
        'Tone': tone or None
    })
    print(greeting_response['Greeting'])

if __name__ == "__main__":
    main()
