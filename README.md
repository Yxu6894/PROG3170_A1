netsh http add urlacl url="http://+:8082/GreetingService/" user=everyone
python -m zeep http://localhost:8082/GreetingService/?singleWsdl
