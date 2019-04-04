using System;

namespace wizardNinjaSamural
{

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int dealhealth
        {
            get{return health;}
            set{health = value;}
        }

        public int Health
        {
            get { return health; }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public void getInfo(){
            Console.WriteLine($"name is {Name}, Strength :{Strength}, Intelligence:{Intelligence}, Dexterity:{Dexterity}, health:{health}");
        }
    }

    class Wizard: Human
    {
        public Wizard(string name):base(name)
        { 
            dealhealth = 50;
            Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.dealhealth -= dmg;
            dealhealth += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.dealhealth;
        }
        public void test(Wizard target)
        {
            target.health -=10;
        }

        public void Heal(Human target)
        {
            int heal = Intelligence *10;
            target.dealhealth += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal} health!");
        }

    }

    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.dealhealth -= dmg;
            Random rand = new Random();
            int randnum = rand.Next(1,5);
            if(randnum ==2){
                target.dealhealth -= 10;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.dealhealth;
        }

        public void Steal(Human target)
        {
            int steal = 5;
            target.dealhealth -= steal;
            dealhealth += steal;
            Console.WriteLine($"{Name} stealed {target.Name} for {steal} damage!");
        }
    }

    class Samural : Human
    {
        public Samural(string name) : base(name)
        {
            dealhealth = 200;
        }
        public override int Attack(Human target)
        {
            // base.Attack(target);
            // if(target.dealhealth<50){
            //     target.dealhealth = 0;
            // }
            if(base.Attack(target)<50)
            {
                target.dealhealth = 0;
            }
            Console.WriteLine($"{Name} attacked {target.Name} !");
            return target.dealhealth;
        }

        public void Meditate()
        {
            dealhealth = 200;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizard w1 = new Wizard("wizard");
            Ninja n1 = new Ninja("Ninjia");
            Samural s1 = new Samural("Samural");
            w1.getInfo();
            n1.getInfo();
            s1.getInfo();
            w1.Attack(n1);
            w1.getInfo();
            n1.getInfo();
            n1.Steal(s1);
            n1.getInfo();
            s1.getInfo();
        }
    }
}
