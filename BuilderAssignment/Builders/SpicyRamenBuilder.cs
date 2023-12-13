using BuilderAssignment.Builders;
using System.Collections.Generic;

namespace BuilderAssignment.Models
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public IRamenBuilder SetBroth(BrothType broth)
        {
            ramen.Broth = BrothType.SpicyTonkotsu; 
            return this;
        }

        public IRamenBuilder SetNoodles(NoodleType noodles)
        {
            ramen.Noodles = NoodleType.Thin; 
            return this;
        }

        public IRamenBuilder AddToppings(Topping topping)
        {
            // Add toppings to the list
            ramen.Toppings.Add(Topping.ChashuPork); 
            ramen.Toppings.Add(Topping.GreenOnions); 
            return this;
        }

        public IRamenBuilder AddExtras(Extra extra)
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
