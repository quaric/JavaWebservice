package mainservice;

import java.io.ByteArrayInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.ObjectOutputStream;
import java.io.UnsupportedEncodingException;
import java.util.HashMap;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBElement;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import javax.xml.stream.FactoryConfigurationError;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.XMLStreamReader;

import org.apache.tomcat.util.http.fileupload.ByteArrayOutputStream;
import org.apache.ws.axis2.FortuneCookieStub;

import fortunecookie.FortuneCookie;
import usercheck.UserChecker;


public class MainService {
	private UserChecker check;
	
	/*
	 * denne teller bare lengden p� bytearrayet og returnerer det.
	 */
	public int getByteCount(byte[] bytes) {
		return bytes.length;
		
		/*
		 * Min f�rste ide var � bruke JAXB til � hente st�rrelsen, men jeg fikk bare feil st�rrelser.
		 * Metoden jeg brukte da var � serialisere objektet f�rst i C# med XMLSerializer, og deserialisere det med JAXB.
		 * En String p� 3 bytes ble til 1703 bytes f.eks, s� jeg droppet den ideen da jeg ikke fikk tid.
		 */
		/*InputStream is = new ByteArrayInputStream(o.getBytes("UTF-8"));
		XMLStreamReader reader = XMLInputFactory.newInstance().createXMLStreamReader(is);

		JAXBContext context = JAXBContext.newInstance(Object.class);
		Unmarshaller jaxbUnmarshaller = context.createUnmarshaller();
		
		JAXBElement<Object> elem = jaxbUnmarshaller.unmarshal(reader, Object.class);
		Object object = elem.getValue();
		
		ByteArrayOutputStream bos = new ByteArrayOutputStream();
		try {
			ObjectOutputStream oos = new ObjectOutputStream(bos);

			oos.writeObject(o);
			byte[] data = bos.toByteArray();
			bos.close();
			return data.length;
		} catch(Exception e) {
			e.printStackTrace();
		}
		return -1;*/
	}
	
	
	/*
	 * Brukes ikke, men kan brukes til � sjekke bytecount p� floatnummer
	 */
	/*
	public int getByteCountFloat(Float number) {
		ByteArrayOutputStream oos = new ByteArrayOutputStream();
		try {
			DataOutputStream dos = new DataOutputStream(oos);
			dos.writeFloat(number);
			oos.close();		
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return oos.toByteArray().length;
	}*/
	
	/*
	 * Brukes til � sjekke brukernavn og passord p� UiT sin AD,
	 * returnerer en string som bygges i den andre klassen med navn, brukernavn og epost.
	 */
	public String userCheck(String username, String password) {
		if(check==null) {
			check = new UserChecker(username, password);
		}
		check.setUser(username, password);
		return check.getResult();
	}
	
	/*
	 * Brukes til � hente QRBilde, som blir returnert som et byte array
	 */
	public byte[] getQRImage(String username) {
		return FortuneCookie.getQR(username);
	}
}
