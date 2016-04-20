// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.ProxyPattern
{
    class ProxySystem
    {
        // private Subject class with with an internal constructor
        private class Subject
        {
            string name;
            string password;
            string text;

            internal Subject(string n, string pw)
            {
                name = n;
                password = pw;
            }

            internal void Add(string t)
            {
                text = t;
            }
        }

        // public Proxy class, used to access the private Subject class
        public class Proxy
        {
            Subject subject;
            string password;
            string name;
            bool loggedIn = false;


            public void Register(string pw, string nm)
            {
                if (pw != null)
                    password = pw;

                if (nm != null)
                    name = nm;
            }

            public void Reset()
            {
                password = null;
                name = null;
                subject = null;
            }


            public bool Authenticate(string suppliedPassword)
            {
                if (suppliedPassword == password)
                {
                    loggedIn = true;

                    if (subject == null)
                        subject = new Subject(name, password);

                    return true;
                }

                return false;
            }


            public void Add(string addedText)
            {
                Check(password);

                if (loggedIn)
                    subject.Add(addedText);
            }

           

            void Check(string suppliedPassword)
            {
                if (!loggedIn)
                {
                    if (subject == null)
                        Authenticate(suppliedPassword);
                }
            }
        }
    }
}
