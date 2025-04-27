// Models/User.cs
using System.Xml.Serialization;

namespace BankingSystemGUI.Models
{
    public class User
    {
        [XmlElement("Username")]
        public string Username { get; set; }
        
        [XmlElement("Password")]
        public string Password { get; set; }
        
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        
        [XmlElement("LastName")]
        public string LastName { get; set; }
    }
}