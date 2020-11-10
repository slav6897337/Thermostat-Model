namespace ThermostatModel
{
    /// <summary>
    /// Liquid properties in the system.
    /// </summary>
    public class Liquid
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Liquid"/> class.
        /// </summary>
        public Liquid()
            : this("Water")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Liquid"/> class.
        /// </summary>
        /// <param name="compsition">Liquid composition.</param>
        public Liquid(string compsition)
        {
            Compsition = compsition;
            Temperature = 0;
        }

        /// <summary>
        /// Gets or sets liquid composition.
        /// </summary>
        public string Compsition { get; set; }

        /// <summary>
        /// Gets or sets liquid temperature.
        /// </summary>
        public int Temperature { get; set; }
    }
}
