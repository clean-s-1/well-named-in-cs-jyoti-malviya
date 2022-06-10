using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColourMap
    {
        public static void MapByPairNumber(int pairNumber)
        {
            ColorPair testPair1 = ColorPairMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            switch (pairNumber)
            {
                case 4:
                    Debug.Assert(testPair1.majorColor == Color.White);
                    Debug.Assert(testPair1.minorColor == Color.Brown);
                    break;
                case 5:
                    Debug.Assert(testPair1.majorColor == Color.White);
                    Debug.Assert(testPair1.minorColor == Color.SlateGray);
                    break;
                case 23:
                    Debug.Assert(testPair1.majorColor == Color.Violet);
                    Debug.Assert(testPair1.minorColor == Color.Green);
                    break;
            }

        }
        public static void MapByColor(Color color1, Color color2)
        {
            ColorPair testPair2 = new ColorPair() { majorColor = color1, minorColor = color2 };
            int pairNumber = PairColourMap.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            switch (pairNumber)
            {
                case 18:
                    Debug.Assert(pairNumber == 18);
                    break;
                case 6:
                    Debug.Assert(pairNumber == 6);
                    break;
            }

        }

    }
}
