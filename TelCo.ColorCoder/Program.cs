using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            ColourMap.MapByPairNumber(4);
            ColourMap.MapByPairNumber(5);
            ColourMap.MapByPairNumber(23);
            ColourMap.MapByColor(Color.Yellow, Color.Green);
            ColourMap.MapByColor(Color.Red, Color.Blue);
        }
    }
}
