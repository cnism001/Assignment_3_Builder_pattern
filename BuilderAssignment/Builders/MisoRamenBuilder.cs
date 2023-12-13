using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders

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
            ramen.Toppings = Topping.GreenOnions;
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
