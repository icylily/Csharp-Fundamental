using System.Collections.Generic;
using System;
class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("chicken wing", 800, true, false),
            new Food("apple pie", 500, false, true),
            new Food("beef udon", 700, false, false),
            new Food("steak", 800, false, false),
            new Food("fried shirmp", 600, false, false),
            new Food("icecream", 300, false, true),
            new Food("chips", 300, true, false),
        };
        }

        public Food Serve()
        {
            Buffet serveBuffet = new Buffet();
            Random rand = new Random();
            int rand_index = rand.Next(0,serveBuffet.Menu.Count);
            Food serveFood = serveBuffet.Menu[rand_index];
            return serveFood;
        }
    }