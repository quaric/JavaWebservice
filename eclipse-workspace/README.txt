Webservicen er skrevet i Java 8, Tomcat 8.0. 
Klienten er skrevet i C#, med Windows-Forms i Visual Studio 2019.

WSDL-dokumentet er satt til http://localhost:8080/Oblig2Services/services/MainService?wsdl i klienten.
Jeg fikk ikke til å bruke JAXB eller noe slikt med C#, så jeg konverterte til bytearray før jeg sendte til webservice og returnerte lengden.
Ellers fungerer alt.

Jeg la ved hele workspace, ikke sikker på om prosjektmappen holder da det er noen auto-genererte filer.
Prosjektmappen til webservicen er ObligServices2 i workspace mappen.