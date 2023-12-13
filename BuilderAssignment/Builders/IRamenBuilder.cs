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
        IRamenBuilder SetBroth();

        // - Setting noodles
        IRamenBuilder SetNoodles();

        // - Adding toppings
        IRamenBuilder AddToppings();
        // - Adding Extras
        IRamenBuilder AddExtras();

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        RamenBowl GetRamen();

    }
}
