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

        public IRamenBuilder SetBroth()
        {
            ramen.Broth = BrothType.Miso;
            return this;
        }

        public IRamenBuilder SetNoodles()
        {
            ramen.Noodles = NoodleType.Udon;
            return this;
        }

        public IRamenBuilder AddToppings()
        {
            ramen.Toppings.Add(Topping.GreenOnions);
            return this;
        }

        public IRamenBuilder AddExtras()
        {
            ramen.Extras.Add(Extra.Corn);
            return this;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
