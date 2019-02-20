using System;

namespace Dog
{
    public class Dog
    {
        public enum Gender
        {
            Male,
            Female
        }
        public String name;
        public String owner;
        public int age;
        public Gender gender;

        public static string GetGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            else
            {
                return "Her";
            }
        }



        public Dog(String dogName, String ownerName, int dogAge, Gender dogGender)
        {
            name = dogName;
            owner = ownerName;
            age = dogAge;
            gender = dogGender;
        }



        public void Bark(int num)
        {
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Woof!");
            }
        }


        public string GetTag()
        {
            string yearOrYears;
            if (age == 1)
            {
                yearOrYears = "year";
            }
            else
            {
                yearOrYears = "years";
            }

            string hisOrHer = GetGender(gender).ToString();
            string heOrShe;
            if (hisOrHer == "His")
            {
                heOrShe = "he";
            }
            else
            {
                heOrShe = "she";
            }
            return "If lost, call " + owner + ". " + hisOrHer + " name is " + name + " and " + heOrShe + " is " + age +" "+ yearOrYears +" old. ";
        }


        static void Main(string[] args)
        {

            Dog puppy = new Dog("Orion", "Shaun", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female); 
            myDog.Bark(1); 
            Console.WriteLine(myDog.GetTag()); 


        }
    }
}
