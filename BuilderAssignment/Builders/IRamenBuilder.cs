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
        IRamenBuilder SetBroth(string broth);

        // - Setting noodles
        IRamenBuilder SetNoodles(string noodles);

        // - Adding toppings
        IRamenBuilder AddToppings(string toppings);
        // - Adding Extras
        IRamenBuilder AddExtras(string extras);

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();
    }
}
