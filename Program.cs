using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            D1 DayOne = new D1();
            int D1star1 = DayOne.star1();
            int D1star2 = DayOne.star2();
            D2 DayTwo = new D2();
            int D2star1 = DayTwo.star1();
            int D2star2 = DayTwo.star2();
            DayTwo.star2();
            D3 DayThree = new D3();
            long D3star1 = DayThree.star1();
            long D3star2 = DayThree.star2();
            long result = D3star1 - D3star2;
            D4 DayFour = new D4();
            int D4star1 = DayFour.star1();
            int D4star2 = DayFour.star2();
            D5 DayFive = new D5();
            int DayFivestar1 = DayFive.star1();
            int DayFivestar2 = DayFive.star2();
            D6 DaySix = new D6();
            //int DaySixStar1 = DaySix.star1();
            //int DaySixStar2 = DaySix.star2();
            D7 DaySeven = new D7();
            //long DaySevenStar1 = DaySeven.star1();
            //long DaySevenStar2 = DaySeven.star2();
            D8 DayEight = new D8();
            //int DayEightstar1 = DayEight.star1();
            //int DayEightstar2 = DayEight.star2();
            D9 DayNine = new D9();
            //long DayNineStar1 = DayNine.star1();
            //long DayNineStar2 = DayNine.star2();
            D10 DayTen = new D10();
            (int,int) DayTenstars = DayTen.star();
            D11 DayEleven = new D11();
            //int DayElevenstar1 = DayEleven.star1();
            //int DayElevenstar2 = DayEleven.star2();
            D12 DayTwelve = new D12();
            int DayTwelvestar1 = DayTwelve.star1();
            int DayTwelvestar2 = DayTwelve.star2();
            Console.WriteLine("Day1:" + D1star1 + D1star2);
            Console.WriteLine("Day2:" + D2star1 + D2star2);
            D13 DayThirteen = new D13();
            long DayThirteenstar1 = DayThirteen.star1();
            long DayThirteenstar2 = DayThirteen.star2();
        }
    }
}