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
        public List<Topping> Toppings { get; set; } = new List<Topping>();
        public List<Extra> Extras { get; set; } = new List<Extra>();

        //TODO#2: Return description of finished bowl of ramen
        //string description = ramen.FinishedBowlOfRamen(); would return description of ramen instance of RamenBowl
        public string FinishedBowlOfRamen()
        {
            //converting contents of list Toppings and Extras to string to return their contents to handle multiple toppings and/or extras
            string toppingsString = string.Join(", ", Toppings.Select(t => t.ToString()));
            string extraString = string.Join(", ", Extras.Select(t => t.ToString()));
            return $"Broth: {Broth}, Noodles: {Noodles}, Toppings: {toppingsString}, Extras: {extraString}";
        }
    }
}
