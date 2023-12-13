﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        // Properties for each ingredient type
        public BrothType Broth { get; set; }
        public NoodleType Noodles { get; set; }
        public Topping Toppings { get; set; }
        public Extra Extras { get; set; }
        //TODO#2: Return description of finished bowl of ramen
        public static string FinishedBowlOfRamen()
        {
            return "";
        }
    }
}
