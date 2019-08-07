using RandomNameGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracePoint_DemoApp
{
    class Person
    {
        private static RandomName m_nameGen = new RandomName(new Random());
        public static Person GetRandom()
        {
            Person peep = new Person();

            peep.Age = Global.RandomGenerator.Next(100);
            peep.Name = m_nameGen.Generate(Sex.Male);
            peep.State = Global.RandomState();
            peep.FriendsNames = m_nameGen.RandomNames(100, 2);

            return peep;
        }


        public string Name;
        public int Age;
        public string State;
        public List<string> FriendsNames;

        public Person()
        {

        }
    }
}
