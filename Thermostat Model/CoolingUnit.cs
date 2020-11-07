namespace ThermostatModel
{
    /// <summary>
    /// Performs Cooling work.
    /// </summary>
    public static class CoolingUnit
    {
        /// <summary>
        /// Cooling.
        /// </summary>
        /// <param name="liquid">Liquid in the system.</param>
        /// <param name="temperature">Required temperature.</param>
        public static void Cooling(Liquid liquid, int temperature)
        {
            if (temperature < liquid?.Temperature)
            {
                System.Console.WriteLine($"A cooling unit is running. \nIt is necessary to cool the liquid from {liquid.Temperature} to {temperature} degrees.");
                liquid.Temperature = temperature;
                System.Console.WriteLine($"The temperature is set at {liquid.Temperature} degrees.");
            }
        }
    }
}
