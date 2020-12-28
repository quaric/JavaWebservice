package fortunecookie;
/*
 * Denne klassen brukes til å generere et nummer n- som vi bruker til å hente QR Bilde.
 */
import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.Calendar;

import org.apache.ws.axis2.FortuneCookieStub;

public class FortuneCookie {
	private String cookieMessage;
	private FortuneCookieStub stub;
	
	public org.apache.axis2.databinding.ADBBean getRemoteObject(java.lang.Class type) throws java.lang.Exception {
		return (org.apache.axis2.databinding.ADBBean) type.newInstance();
	}
	
	public FortuneCookie() {
	} 
	
	/*
	 * Denne metoden genererer et cookienummer ved hjelp av lengde på brukernavn og dagens dato
	 */
	public static int generateCookieNumber(String username) {
		int cookieNumber;
		Calendar calendar = Calendar.getInstance();
		int todaysDateNumber = calendar.get(Calendar.DAY_OF_MONTH);
		cookieNumber = (todaysDateNumber + username.length()) *2;
		while(cookieNumber > 50) {
			cookieNumber -= 50;
		}
		return cookieNumber;
	}
	
	/*
	 * Denne metoden henter en fortunecookie, som den får ved å spørre n-ganger slik oppgaven beskriver
	 */
	public static String getCookie(String username, int n) {
		FortuneCookie cookie = new FortuneCookie();
		String r;
		try {
			FortuneCookieStub stub = new FortuneCookieStub();
			FortuneCookieStub.GetCookie getCookie = null;
			for(int i=0;i<n;i++) {
				getCookie = (FortuneCookieStub.GetCookie)cookie.getRemoteObject(FortuneCookieStub.GetCookie.class);
			}
			
			FortuneCookieStub.GetCookieResponse response = stub.getCookie(getCookie);
			r= response.get_return();
		} catch(Exception e) {
			r= e.toString();
		}
		return r;
	}
	
	/*
	 * Denne kontakter QRImage API'et som genererer et QR-bilde utfra teksten og n-verdien
	 * Returnerer bildet som bytearray til klienten
	 */
	public static byte[] getQR(String username) {
		int n = generateCookieNumber(username);
		String cookieString = getCookie(username, n);
		String params = "Iterasjon nummer: " + n + ": " + cookieString;
	
		byte[] imageAsByteArray;
		try {
			String url = "http://api.qrserver.com/v1/create-qr-code/?data=" + URLEncoder.encode(params, StandardCharsets.UTF_8.toString()) + "&size=100x100";
			InputStream imageAsStream = new URL(url).openStream();
			imageAsByteArray = new byte[imageAsStream.available()];
			imageAsStream.read(imageAsByteArray);
		} catch(Exception e) {
			imageAsByteArray = null;
		}
		return imageAsByteArray;
	}
}
