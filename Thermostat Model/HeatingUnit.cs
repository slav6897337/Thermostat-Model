namespace ThermostatModel
{
    /// <summary>
    /// Performs heating work.
    /// </summary>
    public static class HeatingUnit
    {
        /// <summary>
        /// Cooling.
        /// </summary>
        /// <param name="liquid">Liquid in the system.</param>
        /// <param name="temperature">Required temperature.</param>
        public static void Heating(Liquid liquid, int temperature)
        {
            if (temperature > liquid?.Temperature)
            {
                System.Console.WriteLine($"A heating unit is running. \nIt is necessary to heat the liquid from {liquid.Temperature} to {temperature} degrees.");
                liquid.Temperature = temperature;
                System.Console.WriteLine($"The temperature liquid is set at {liquid.Temperature} degrees.");
            }
        }
    }
}
