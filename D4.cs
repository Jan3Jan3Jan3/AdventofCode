using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D4
    {
        public char[,] m_Words;
        public D4()
        {
            List<int[]> list = new List<int[]>();
            List<int> temp = new List<int>();
            string filepath = @"C:\Users\jan\Downloads\D4.txt";
            string[] lines = File.ReadAllLines(filepath);
            char[,] Words = new char[lines.Length, lines[0].Length];
            for(int i = 0; i < lines.Length; i++)
            {
                for(int j = 0; j < lines[0].Length; j++)
                {
                    Words[i, j] = lines[i][j];
                }
            }
            m_Words = Words;
        }
        public int star1()
        {
            int output = 0;
            int m = m_Words.GetLength(0);
            int n = m_Words.GetLength(1);
            //Horizontal
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 3; j++)
                {
                    string candidate = "";
                    for (int k = 0; k < 4; k++)
                    {
                        candidate += m_Words[i, j + k];
                        if(candidate == "XMAS" || candidate == "SAMX")
                        {
                            output++;
                        }
                    }
                }
            }
            //Vertical
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m - 3; j++)
                {
                    string candidate = "";
                    for (int k = 0; k < 4; k++)
                    {
                        candidate += m_Words[j+k,i];
                        if (candidate == "XMAS" || candidate == "SAMX")
                        {
                            output++;
                        }
                    }
                }
            }
            //Diagonal \
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < m - 3; j++)
                {
                    string candidate = "";
                    for (int k = 0; k < 4; k++)
                    {
                        candidate += m_Words[j + k, i + k];
                        if (candidate == "XMAS" || candidate == "SAMX")
                        {
                            output++;
                        }
                    }
                }
            }
            //Diagonal /
            for (int i = 3; i < n; i++)
            {
                for (int j = 3; j < m; j++)
                {
                    string candidate = "";
                    for (int k = 0; k < 4; k++)
                    {
                        candidate += m_Words[j - k, i - k];
                        if (candidate == "XMAS" || candidate == "SAMX")
                        {
                            output++;
                        }
                    }
                }
            }
            return output;
        }
        public int star2()
        {
            int output = 0;
            int m = m_Words.GetLength(0);
            int n = m_Words.GetLength(1);
            for(int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    char[,] temp = new char[3, 3];
                    for(int k = 0; k < 3 ; k++)
                    {
                        for(int l = 0; l < 3 ; l++)
                        {
                            temp[k,l] = m_Words[i+k,j+l];
                        }
                    }
                    if(XMAS(temp))
                    {
                        output++;
                    }
                }
            }
            return output;
        }
        public bool XMAS(char[,] a)
        {
            bool output = false;
            if (a[1,1] == 'A' && a[0,0] == 'M' && a[0,2] == 'S' && a[2,0] == 'M' && a[2,2] == 'S')
            {
                output = true;
            }
            else if (a[1, 1] == 'A' && a[0, 0] == 'M' && a[0, 2] == 'M' && a[2, 0] == 'S' && a[2, 2] == 'S')
            {
                output = true;
            }
            else if (a[1, 1] == 'A' && a[0, 0] == 'S' && a[0, 2] == 'S' && a[2, 0] == 'M' && a[2, 2] == 'M')
            {
                output = true;
            }
            else if (a[1, 1] == 'A' && a[0, 0] == 'S' && a[0, 2] == 'M' && a[2, 0] == 'S' && a[2, 2] == 'M')
            {
                output = true;
            }
            return output;
        }
    }
}
