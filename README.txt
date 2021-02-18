En applikasjon som henter et brukernavn ved UiT, forså å bruke tjenesten http://158.39.116.18:8080/FortuneCookieService/services/FortuneCookie til å generere
en "FortuneCookie". Denne brukes så til å generere et QR bilde ved hjelp av  http://qrserver.com/api/
som sendes til klienten.


Webservicen er skrevet i Java 8, Tomcat 8.0. 
Klienten er skrevet i C#, med Windows-Forms i Visual Studio 2019.

WSDL-dokumentet er satt til http://localhost:8080/Oblig2Services/services/MainService?wsdl i klienten.

Prosjektmappen til webservicen er ObligServices2 i workspace mappen.
