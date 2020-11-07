namespace ThermostatModel
{
    using System;
    using System.Threading;

    /// <summary>
    /// Heating management.
    /// </summary>
    public class Thermostat : ITemperatureChanges
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thermostat"/> class.
        /// </summary>
        public Thermostat()
        {
            Liquid = new Liquid();
            TimerCallback timerdelegate = new TimerCallback(TemperatureCheck);
            Timer timer = new Timer(timerdelegate, 0, 0, 3000);
        }

        /// <summary>
        /// Temperature Changing.
        /// </summary>
        public event Action<Liquid, int> TemperatureChanging;

        /// <summary>
        /// Gets or sets liquid in the system.
        /// </summary>
        public Liquid Liquid { get; set; }

        /// <summary>
        /// Gets the temperature that the user has set.
        /// </summary>
        public int SettledTemperature { get; private set; } = 50;

        /// <summary>
        /// Notify of changes in temperature.
        /// </summary>
        /// <param name="newTemperature">New required temperature.</param>
        public void TemperatureChanges(int newTemperature)
        {
            if (newTemperature != Liquid.Temperature)
            {
                SettledTemperature = newTemperature;
                TemperatureChanging?.Invoke(Liquid, newTemperature);
            }
            else
            {
                Console.WriteLine($"Actual temperature {Liquid.Temperature} corresponds to the desired one.");
            }
        }

        /// <summary>
        /// Temperature check by timer.
        /// </summary>
        private void TemperatureCheck(object obj)
        {
            Console.WriteLine($"TemperatureCheck.");
            if (SettledTemperature != Liquid.Temperature)
            {
                TemperatureChanges(SettledTemperature);
            }
        }
    }
}
