﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_test
{
    internal class Player
    {
        Random rng = new Random();

        public string name;

        public int health = 100;

        public int x;
        public int y;

        public int strenth = 20;

        public Player(String name)
        {
            Console.WriteLine("Hello " + name);
            this.name = name;
        }

        public void TakeDamage(int damage, string enemyname)
        {
            Console.WriteLine(enemyname + " deals " + damage + " damage to " + name);
            health -= damage;
        }
        public int DealDamage()
        {
            
            int damage = rng.Next(1,strenth);
            return damage;
        }
        public void ShowStats()
        {
            Console.WriteLine(name + " has " + health + " health and has " + strenth + " points of strenth");
        }
    }
}
