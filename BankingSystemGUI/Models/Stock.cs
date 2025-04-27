// Models/Stock.cs
using System;
using System.Xml.Serialization;

namespace BankingSystemGUI.Models
{
    public class Stock
    {
        [XmlElement("Symbol")]
        public string Symbol { get; set; }
        
        [XmlElement("Price")]
        public decimal Price { get; set; }
        
        [XmlElement("LastUpdated")]
        public DateTime LastUpdated { get; set; }

        public Stock() { }

        public Stock(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
            LastUpdated = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Symbol}: ${Price:0.00}";
        }
    }
}