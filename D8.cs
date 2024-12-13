using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D8
    {
        public char[,] m_Map;
        public int m_n;
        public (int, int) m_start;
        public D8()
        {
            int n = 0;
            string str = "...s..............................................\r\n...................w......K.......t...............\r\n........s.........................................\r\n.......s......w...............1...................\r\n.........w5.......................................\r\n.......................t.F........................\r\n..................................................\r\nF................................1...........d....\r\n.........................5......................K.\r\n............5.................R..............KZ...\r\n....F.....q.........w..............1.....t........\r\n............8.......I.............................\r\n..........8.................t....................K\r\n...........8.................5.....Z..............\r\n.........q..............................Z...d..U..\r\n...................Y.q...R........................\r\n....................E.....z...............y.......\r\n..........................................U.......\r\n.....F.................................k........S.\r\n............q...................d.................\r\n.................................R................\r\n..x....................................U.........y\r\n.......x.........................E..M...U..d......\r\n......z.......X............................4......\r\n...............I....m....M......R............y....\r\n.......z...................................k..e...\r\n..f..z.......................................e....\r\n...f.I..........7..u..........M................D..\r\n.......X..I.......x.................k.............\r\n.........X.......7....................4.......S...\r\n....................u9...T.....3.Z....o..........6\r\n........f.......D..3....u..................S......\r\n...W...0.........................................D\r\n.....................T................E.......m...\r\n...8....Y............f........T4..................\r\n......Y...........................................\r\n....0.............3...............................\r\n....................3.T.....................k.....\r\n.......................u..............6...........\r\n...........................6..........9........e..\r\n..................4....7.............o..........D.\r\n.................................M...E..o.........\r\n...i.................O...........................Q\r\n.....0.i.....................................m.2..\r\n.......Y.r........7..............S..O..2.......m..\r\n.....r......0.............O.......................\r\n..................................Q...............\r\n........................6................o......Q.\r\n..W...r.................................9.........\r\n.W.........................O........2.............";
            //string str = "....#.....\r\n.........#\r\n..........\r\n..#.......\r\n.......#..\r\n..........\r\n.#..^.....\r\n........#.\r\n#.........\r\n......#...";
            bool Found = false;
            for(int i = 0; i < str.Length && Found == false; i++)
            {
                if (str[i] == '\r')
                {
                    n = i;
                    Found = true;
                }
            }
            char[,] map = new char[n, n];
            int aux1 = 0;
            int aux2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\r')
                {
                    aux1++;
                    aux2 = 0;
                }
                else if (str[i] == '\n')
                {

                }
                else
                {
                    map[aux2,n-1-aux1] = str[i];
                    aux2++;
                }
            }
            string lastline = ".W.........................O........2.............";
            //string lastline = "......#...";
            for (int i = 0; i < lastline.Length; i++)
            {
                map[i,0] = lastline[i];
            }
            m_n = n;
            m_Map = map;
        }
        public int star1()
        {
            List<(int,int)> points = new List<(int,int)> ();
            Dictionary<char, List<(int, int)>> dict = new Dictionary<char, List<(int, int)>>();
            for (int i = 0; i  < m_n; i++)
            {
                for(int j = 0; j < m_n; j++)
                {
                    if (m_Map[i,j] != '.')
                    {
                        if (!dict.ContainsKey(m_Map[i,j]))
                        {
                            dict.Add(m_Map[i, j], new List<(int, int)> { (i, j) });
                        }
                        else
                        {
                            dict[m_Map[i, j]].Add((i,j));
                        }
                    }
                }
            }
            foreach (KeyValuePair<char, List<(int, int)>> kvp in dict)
            {
                foreach (var tuple in kvp.Value)
                {
                    foreach (var tuple2 in kvp.Value)
                    {
                        if(tuple != tuple2)
                        {
                            int xdistance = tuple.Item1 - tuple2.Item1;
                            int ydistance = tuple.Item2 - tuple2.Item2;
                            if (!points.Contains((tuple.Item1 + xdistance, tuple.Item2 + ydistance)))
                            {
                                points.Add((tuple.Item1 + xdistance, tuple.Item2 + ydistance));
                            }
                            if (!points.Contains((tuple2.Item1 - xdistance, tuple2.Item2 - ydistance)))
                            {
                                points.Add((tuple2.Item1 - xdistance, tuple2.Item2 - ydistance));
                            }
                        }
                    }
                }
            }
            int output = 0;
            foreach((int,int) point in points)
            {
                if(point.Item1 >= 0 && point.Item1 < 50 && point.Item2 >= 0 && point.Item2 < 50)
                {
                    output++;
                }
            }
            return output;
        }
        public int star2()
        {
            List<(int, int)> points = new List<(int, int)>();
            Dictionary<char, List<(int, int)>> dict = new Dictionary<char, List<(int, int)>>();
            for (int i = 0; i < m_n; i++)
            {
                for (int j = 0; j < m_n; j++)
                {
                    if (m_Map[i, j] != '.')
                    {
                        if (!dict.ContainsKey(m_Map[i, j]))
                        {
                            dict.Add(m_Map[i, j], new List<(int, int)> { (i, j) });
                        }
                        else
                        {
                            dict[m_Map[i, j]].Add((i, j));
                        }
                    }
                }
            }
            foreach (KeyValuePair<char, List<(int, int)>> kvp in dict)
            {
                foreach (var tuple in kvp.Value)
                {
                    foreach (var tuple2 in kvp.Value)
                    {
                        if (tuple != tuple2)
                        {
                            if (!points.Contains(tuple))
                            {
                                points.Add(tuple);
                            }
                            if (!points.Contains(tuple2))
                            {
                                points.Add(tuple2);
                            }
                            int xdistance = tuple.Item1 - tuple2.Item1;
                            int ydistance = tuple.Item2 - tuple2.Item2;
                            for (int j = 1; j < 1000; j++)
                            {
                                if (!points.Contains((tuple.Item1 + j * xdistance, tuple.Item2 + j * ydistance)))
                                {
                                    points.Add((tuple.Item1 + j * xdistance, tuple.Item2 + j * ydistance));
                                }
                                if (!points.Contains((tuple2.Item1 - j * xdistance, tuple2.Item2 - j * ydistance)))
                                {
                                    points.Add((tuple2.Item1 - j * xdistance, tuple2.Item2 - j * ydistance));
                                }
                            }
                        }
                    }
                }
            }
            int output = 0;
            foreach ((int, int) point in points)
            {
                if (point.Item1 >= 0 && point.Item1 < 50 && point.Item2 >= 0 && point.Item2 < 50)
                {
                    output++;
                }
            }
            return output;
        }
    }
}
