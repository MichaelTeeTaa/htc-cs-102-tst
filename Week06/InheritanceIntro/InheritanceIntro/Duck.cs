﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Duck : Animal
    {
        // Interhited From Animal
        // string Name;
        //public int Height;

        public void Quack()
        {
            MessageBox.Show("Quack");
        }
        // Interhited From Animal
        //public void SayName()
        //{
          //  MessageBox.Show($"My name is {Name}");
       // }

        public Duck()
        {
            
         }
        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }
       }
    }

