namespace ThermostatModel
{
    /// <summary>
    /// Notify of changes in temperature.
    /// </summary>
    public interface ITemperatureChanges
    {
        /// <summary>
        /// Notify of changes in temperature.
        /// </summary>
        /// <param name="newTemperature">New required temperature.</param>
        void TemperatureChanges(int newTemperature);
    }
}
