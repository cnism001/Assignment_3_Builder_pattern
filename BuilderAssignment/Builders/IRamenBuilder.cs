using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for following steps
        // - Setting broth
        IRamenBuilder SetBroth(BrothType broth);

        // - Setting noodles
        IRamenBuilder SetNoodles(NoodleType noodles);

        // - Adding toppings
        IRamenBuilder AddToppings(Topping toppings);
        // - Adding Extras
        IRamenBuilder AddExtras(Extra extras);

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
