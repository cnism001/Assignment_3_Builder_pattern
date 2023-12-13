using BuilderAssignment.Models;
using System.Collections.Generic;

namespace BuilderAssignment.Builders
{
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public IRamenBuilder SetBroth()
        {
            ramen.Broth = BrothType.Vegan; 
            return this;
        }

        public IRamenBuilder SetNoodles()
        {
            ramen.Noodles = NoodleType.Soba;
            return this;
        }

        public IRamenBuilder AddToppings()
        {
            // Add toppings to the list
            ramen.Toppings.Add(Topping.BambooShoots); 
            ramen.Toppings.Add(Topping.Seaweed);
            return this;
        }

        public IRamenBuilder AddExtras()
        {
            // Assuming no extras are added for Vegan Ramen
           
            return this;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
