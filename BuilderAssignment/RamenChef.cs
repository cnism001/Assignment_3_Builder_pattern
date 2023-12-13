using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.SetBroth();  
            builder.SetNoodles(); 
            builder.AddToppings();  
            builder.AddExtras();

            //TODO#2: Finaly return build bowl of ramen
            return builder.GetRamen();
        }
    }
}
