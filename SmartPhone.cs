using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class SmartPhone : IDisplayable, IConnectable, IRechareable
    {
        public string Model { get; set; }
        public bool IsConnected { get; set; }
        public int Percentage { get; set; }
        public SmartPhone(string name) 
        {
            Model = name;
            IsConnected = false;
            Percentage = 100;
        }
        public bool Connect()
        {
            IsConnected = true;
            return IsConnected;
        }
        public void Charge(int minutes)
        {
            if (IsConnected)
            {
                Console.WriteLine($"{Model} will take {minutes} minutes to recharge fully");
                Percentage -= minutes;
            }
                
            else
                Console.WriteLine("You have to connect the charger");
        }
        public string Display()
        {
            string result = $"Mobile Model : {Model}\nPercentage : {Percentage}\n";
            return result;
        }
    }
}
