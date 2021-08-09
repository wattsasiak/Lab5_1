using System;
using System.Collections.Generic;

namespace RPGLab
{
    //Implement polymorphism for a fantasy role-playing game
    class GameCharacter
    {
        public string name;
        public int strength;
        public int intelligence;

        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {name}, Strength : {strength}, Intelligence : {intelligence}.");
        }

        //public GameCharacter(string name, int strength, int intelligence)
        //{
        //    this.name = name;
        //    this.strength = strength;
        //    this.intelligence = intelligence;
        //}
      
    }


    class Warrior : GameCharacter
    {
        public string WeaponType;
        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}, Strength : {strength}, Intelligence : {intelligence}, Weapon Type: {WeaponType}.");
        }

        //public Warrior(string name, int strength, int intelligence, string WeaponType)
        //{
        //    this.name = name;
        //    this.strength = strength;
        //    this.intelligence = intelligence;
        //    this.WeaponType = WeaponType;
        //}
    }

    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy;


        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}, Strength : {strength}, Intelligence : {intelligence}, Magical Energy: {MagicalEnergy}.");
        }



        //public MagicUsingCharacter(string name, int strength, int intelligence, int MagicalEnergy)
        //{
        //    this.name = name;
        //    this.strength = stength;
        //    this.intelligence = intelligence;
        //    this.MagicalEnergy = MagicalEnergy;
        //}


    }


    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber;

        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}, Strength : {strength}, Intelligence : {intelligence}, Magical Energy: {MagicalEnergy}, Number of Spells: {SpellNumber}.");
        }


        //public Wizard(string name, int strength, int intelligence, int MagicalEnergy, int SpellNumber)
        //{
        //    this.name = name;
        //    this.strength = strength;
        //    this.intelligence = intelligence;
        //    this.MagicalEnergy = MagicalEnergy;
        //    this.SpellNumber = SpellNumber;

        //}



    }

    class Program
    {
        static void Main(string[] args)

         {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");
            Console.WriteLine();

            Warrior Warrior1 = new Warrior();
            Warrior1.name = "Enaxx";
            Warrior1.strength = 90;
            Warrior1.intelligence = 100;
            Warrior1.WeaponType = "Sword";
            Warrior1.Play();
            //Console.WriteLine(Warrior1);


            Warrior Warrior2 = new Warrior();
            Warrior2.name = "Uzin";
            Warrior2.strength = 95;
            Warrior2.intelligence = 98;
            Warrior2.WeaponType = "Dagger";
            Warrior2.Play();
            //Console.WriteLine(Warrior2);



            Wizard Wizard1 = new Wizard();
            Wizard1.name = "Adus";
            Wizard1.strength = 95;
            Wizard1.intelligence = 98;
            Wizard1.SpellNumber = 50;
            Wizard1.MagicalEnergy = 70;
            Wizard1.Play();
            //Console.WriteLine(Wizard1);


            Wizard Wizard2 = new Wizard();
            Wizard2.name = "Elzomarim";
            Wizard2.strength = 80;
            Wizard2.intelligence = 75;
            Wizard2.SpellNumber = 90;
            Wizard2.MagicalEnergy = 80;
            Wizard2.Play();
            //Console.WriteLine(Wizard2);

            Wizard Wizard3 = new Wizard();
            Wizard3.name = "Zubeus";
            Wizard3.strength = 92;
            Wizard3.intelligence = 85;
            Wizard3.SpellNumber = 76;
            Wizard3.MagicalEnergy = 60;
            Wizard3.Play();
            //Console.WriteLine(Wizard3);

            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            foreach (GameCharacter item in gameCharacters)
            {
                item.Play();
            }
            
        }
    }
}
