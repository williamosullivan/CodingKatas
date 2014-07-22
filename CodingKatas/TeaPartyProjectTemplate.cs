using System;
using System.Collections.Generic;

namespace TeaParty
{
    public class Program
    {
        static void Main(string[] args)
        {
            var guestList = new List<ITeaPartyKata>();
            ITeaPartyKata jane = new TeaPartyKata();
            jane.lastName = "Austen";
            jane.isWoman = true;
            guestList.Add(jane);
            Console.WriteLine(guestList.ToString());
            Console.ReadLine();
        }
    }

    public class TeaPartyKata : ITeaPartyKata
    {
        public override string Welcome()
        {
            
            if (isWoman == true)
                return "Welcome Mrs. " + lastName;
            else if (isSir == true)
                return "Welcome Sir " + lastName;
            else
                return "Welcome Mr. " + lastName;
        }
    }

    public interface ITeaPartyKata
    {
        string lastName { get; set; }
        bool isWoman { get; set; }
        bool isSir { get; set; }
        string Welcome();

    }
}