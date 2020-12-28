using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    [Serializable]
    public class Person
    {
        private string navn;
        private int alder;

        public Person(string navn, int alder)
        {
            this.navn = navn;
            this.alder = alder;
        }

        public Person() {}

        public void setNavn(string navn)
        {
            this.navn = navn;
        }

        public string getNavn()
        {
            return navn;
        }

        public void setAlder(int alder)
        {
            this.alder = alder;
        }

        public int getAlder()
        {
            return alder;
        }
    }
}
