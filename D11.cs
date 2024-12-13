using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class D11
    {
        public List<long> m_List;
        public List<long> m_Star1;
        public D11()
        {
            string str = "0 5601550 3914 852 50706 68 6 645371";
            List<long> list = new List<long>( [0,5601550,3914,852,50706,68,6,645371] );
            //string str = "125 17";
            //List<int> list = new List<int>([125,17]);
            m_List = list;
        }
        public int star1()
        {
            List<List<long>> results = new List<List<long>>();
            results.Add(m_List);
            for(int i = 1; i <= 25; i++)
            {
                List<long> result = Blink(results[i-1]);
                results.Add(result);
            }
            m_Star1 = results[25];
            return results[25].Count;
        }
        public List<long> Blink(List<long> list)
        {
            List<long> output = new List<long>();
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == 0)
                {
                    output.Add(1);
                }
                else if(list[i].ToString().Length % 2 == 0)
                {
                    long toAdd1 = long.Parse(list[i].ToString().Substring(0, list[i].ToString().Length / 2));
                    string toAdd2 = list[i].ToString().Substring(list[i].ToString().Length / 2, list[i].ToString().Length / 2);
                    bool NonzeroFound = false;
                    for(int j = 0; j < toAdd2.Length - 1 && NonzeroFound == false; j++)
                    {
                        if(toAdd2 == "0")
                        {
                            toAdd2.Remove(j);
                        }
                        else
                        {

                        }
                    }
                    output.Add(toAdd1);
                    output.Add(long.Parse(toAdd2));
                }
                else
                {
                    long look = list[i];
                    output.Add(2024 * list[i]);
                }
            }
            return output;
        }
        public int star2()
        {
            int output = 0;
            for (int i = 0; i < m_Star1.Count; i++)
            {
                List<List<long>> results = new List<List<long>>();
                results.Add(new List<long>{ m_Star1[i] });
                for (int j = 1; j <= 25; j++)
                {
                    List<long> result = Blink(results[j-1]);
                    results.Add(result);
                }
            }
            return output;
        }
    }
}
