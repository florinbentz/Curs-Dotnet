using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAndouRabbit
{
    public enum Eyes
    {
        blue,
        red,
        black,
    }
    public enum Fur
    {
        white,
        brown,
        black,
        gray
    }
    public enum Gender
    {
        m,
        f
    }
    internal class Rabbit
    {
        private Eyes eyes;
        private Fur fur;
        private Gender gender;

        public readonly DateTime birthDate;

        public Rabbit()
        {
            birthDate = DateTime.Now;
        }


        public Eyes Eyes 
        { 
            get { return eyes; }
            set { eyes = value; }
        }
        public Fur Fur 
        { 
            get {  return fur; }
            set { fur = value; }
        }
        public Gender Gender 
        { 
            get {  return gender; } 
            set { gender = value; }
        }

        public int age()
        {
            return DateTime.Now - 
                birthDate;
        }
    }
}
