﻿using BuilderAssignment.Builders;

namespace BuilderAssignment.Models
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public IRamenBuilder SetBroth(BrothType broth)
        {
            ramen.Broth = BrothType.Miso;
            return this;
        }

        public IRamenBuilder SetNoodles(NoodleType noodles)
        {
            ramen.Noodles = NoodleType.Udon;
            return this;
        }

        public IRamenBuilder AddToppings(Topping topping)
        {
            ramen.Toppings.Add(Topping.GreenOnions);
            return this;
        }

        public IRamenBuilder AddExtras(Extra extra)
        {
            ramen.Extras = Extra.Corn;
            return this;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
