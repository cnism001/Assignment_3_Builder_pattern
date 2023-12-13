using BuilderAssignment.Models;
using System.Collections.Generic;

namespace BuilderAssignment.Builders
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public IRamenBuilder SetBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu; 
            return this;
        }

        public IRamenBuilder SetNoodles()
        {
            ramen.Noodles = NoodleType.Thin; 
            return this;
        }

        public IRamenBuilder AddToppings()
        {
            // Add toppings to the list
            ramen.Toppings.Add(Topping.ChashuPork); 
            ramen.Toppings.Add(Topping.GreenOnions); 
            return this;
        }

        public IRamenBuilder AddExtras()
        {
            ramen.Extras = Extra.ExtraSpice;
            return this;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
