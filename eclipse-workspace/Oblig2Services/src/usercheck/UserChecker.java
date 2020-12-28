package usercheck;

/*
 * Denne klassen sjekker f�rst om brukernavn og passord stemmer
 * Dersom det ikke stemmer s� blir fors�ket lagret i failedLogins arraylisten,
 * Dersom du har feilaktig logget inn mer enn 2 ganger s� m� tjenesten restartes
 * Ved vellykket fors�k bygger den en streng med brukernavn, epost og fullt navn som returneres til klienten.
 */
import java.util.ArrayList;
import java.util.Hashtable;

import javax.naming.AuthenticationException;
import javax.naming.CommunicationException;
import javax.naming.Context;
import javax.naming.NamingEnumeration;
import javax.naming.directory.Attribute;
import javax.naming.directory.Attributes;
import javax.naming.directory.DirContext;
import javax.naming.directory.InitialDirContext;
import javax.naming.directory.SearchControls;
import javax.naming.directory.SearchResult;
import javax.naming.ldap.InitialLdapContext;
import javax.naming.ldap.LdapContext;

public class UserChecker {
	
	private static ArrayList<String> failedLogins = new ArrayList<String>();
    private Hashtable<String,String> env = new Hashtable<String,String>();
    private DirContext dc = null;
	
    private final String INITIAL_CONTEXT = "com.sun.jndi.ldap.LdapCtxFactory";
    private final String PROVIDER_URL = "ldap://dc.ad.uit.no:389";
    private final String SECURITY_AUTHENTICATION = "simple";
    		
	private String username;
	private String password;
	
	private StringBuilder result = new StringBuilder();
	
	public UserChecker(String username, String password) {
		this.username = username;
		this.password = password;
		
		//Setter opp env hashtable
		env.put(Context.INITIAL_CONTEXT_FACTORY, INITIAL_CONTEXT);
		env.put(Context.PROVIDER_URL,  PROVIDER_URL);
		env.put(Context.SECURITY_AUTHENTICATION, SECURITY_AUTHENTICATION);

	}
	
	public void setUser(String username, String password) {
		this.username = username;
		this.password = password;
		
	}
	
	public String getResult() {
		env.put(Context.SECURITY_PRINCIPAL, username);
		env.put(Context.SECURITY_CREDENTIALS, password);	
		result.setLength(0);
		int count = 0;
		for(int i = 0; i<failedLogins.size();i++) {
			if(failedLogins.get(i).equals(username)) {
				count++;
			}
		}
		if(count > 2) {
			result.append("Allerede mislykket login 2 ganger.");
			return result.toString();
		}
		

		try {
			dc = new InitialDirContext(env);
			SearchControls controls = new SearchControls();
			controls.setSearchScope(SearchControls.SUBTREE_SCOPE);
			String base = "dc=ad,dc=uit,dc=no";
			String filter ="(&(userPrincipalName="+username+"))";
			NamingEnumeration answer = dc.search(base,  filter, controls);
			if(answer == null) return "No such user found";
			while(answer.hasMoreElements()) {
				SearchResult sr = (SearchResult)answer.next();
				Attributes attrs = sr.getAttributes();
				if(attrs != null) {
					NamingEnumeration ne = attrs.getAll();
					while(ne.hasMore()) {
						Attribute a = (Attribute)ne.next();
						if(a.getID().compareTo("mail")==0) {
							result.append(" E-post: " + a.get().toString());
						}
						else if(a.getID().compareTo("cn")==0) {
							result.append(" Navn: " + a.get().toString());
						}
					}
				} 
			}			
		}
		catch(AuthenticationException e) {
			result.append("LDAP ERROR 49: Feil brukernavn eller passord.");
			failedLogins.add(username);
		}
		catch(CommunicationException e) {
			result.append("CommunicationException. Koble til internett og VPN for � f� adgang.");
		}
		catch(Exception e) { 
			result.append("Exception: " + e.toString());
		} 
		return result.toString();
	}

}