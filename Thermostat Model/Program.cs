namespace ThermostatModel
{
    using System;

    /// <summary>
    /// Main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            Thermostat thermostat = new Thermostat();
            thermostat.TemperatureChanging += HeatingUnit.Heating;
            thermostat.TemperatureChanging += CoolingUnit.Cooling;
            ITemperatureChanges temperatureChanges = thermostat;
            temperatureChanges.TemperatureChanges(50);
            thermostat.TemperatureChanges(90);
            thermostat.TemperatureChanges(40);
            thermostat.Liquid.Temperature = 20;
            Console.ReadKey();
        }
    }
}
