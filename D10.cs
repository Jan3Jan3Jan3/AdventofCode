using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D10
    {
        public int[,] m_Map;
        public int m_n;
        public List<((int xs, int ys), (int xf, int yf))> m_trailheads = new List< ((int,int),(int,int))>();
        public Dictionary<(int,int), int> m_Dict = new Dictionary<(int,int), int>();
        public D10()
        {
            string str = "23456734567892109810123432345698901208765434101\r\n10549825676783478454398521050787432019010125014\r\n01234918985490565569207649801456541023121076523\r\n10109401434301234478111056712365695434536789434\r\n23218321098210765329022346543876786985445890124\r\n94567036707601896011233487652985497876096787633\r\n85432145816548987120545694561016386987187896544\r\n76398901923439878921698763278987275496256102345\r\n65487432301656763212785612109216189345343201976\r\n54306511012345654100126703456705071234014567889\r\n67215301165454343201455896989814560124323498701\r\n78995432874763210112364307890123458065015678012\r\n97786929923892109101876216543260309876784589903\r\n87657818018901238012905487630871212105693210854\r\n56545307667652387643814896321962343454321018765\r\n45430212550743496556723765412455424569910659321\r\n30721403441812305401201234902398512378876743430\r\n21876548732903412390321903801287609410965812565\r\n10961239699876501987430814702108988501234901276\r\n25670012588701431016587723612987667602345672187\r\n34981203476102340127896654543096543211898983098\r\n43210112345216765432945012345125476540127454678\r\n10367895432345898741832101436034989032016565549\r\n23456976001898987650710654987654102121023476432\r\n21043987116787650101921745078943278930234189701\r\n30789783295490543217839830161258767876101089850\r\n49650694386321898346540123250319456543212786761\r\n58941545677012897656621012343401304789303695410\r\n67632432498008783210012303012511215610454584323\r\n52102341345129654105987454987620354328960178765\r\n43001650216734547894326567889431298798873239854\r\n78765781001889030765410128976530321667654390345\r\n69344392190972121256707034345323410501563781236\r\n55431283081569876301898943236516501432457670145\r\n46720894672430985432987650127407832345898545056\r\n37810765543421456701109871298398945496989430987\r\n23946540104012387890234567701280126787870121676\r\n10837231231010892110100108898965435456765014589\r\n76548101942101743021985239707876540367654323987\r\n87439432853232659132376545610012301298303410854\r\n90126501764345678987431496921678431001212543763\r\n78067876545874325876520387834599532198389432102\r\n69158965456985014901011276543787640067476501201\r\n54543012317876123452100345937876551258585432376\r\n23632152101231034563498487890903469349691678985\r\n16721043676541043674567096541212378438710521294\r\n07890124589832012987650123432101289321023430123";
            //string str = "89010123\r\n78121874\r\n87430965\r\n96549874\r\n45678903\r\n32019012\r\n01329801\r\n10456732";
            bool Found = false;
            int n = 0;
            for (int i = 0; i < str.Length && Found == false; i++)
            {
                if (str[i] == '\r')
                {
                    n = i;
                    Found = true;
                }
            }
            int[,] map = new int[n, n];
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
                    map[aux2, n - 1 - aux1] = (int)char.GetNumericValue(str[i]);
                    aux2++;
                }
            }
            string lastline = "07890124589832012987650123432101289321023430123";
            //string lastline = "10456732";
            //string lastline = "......#...";
            for (int i = 0; i < lastline.Length; i++)
            {
                map[i, 0] = (int)char.GetNumericValue(lastline[i]);
            }
            m_n = n;
            m_Map = map;
        }
        public (int,int) star()
        {
            int output = 0;
            int star2 = 0;
            for(int i = 0; i < m_n; i++)
            {
                for(int j = 0; j < m_n; j++)
                {
                    if (m_Map[i,j] == 0)
                    {
                        List<List<(int,int)>> test =  RecursePath(9, i, j);
                        if (test.Count > 0)
                        {
                            int z = 0;
                        }
                        List<(int, int)> pairs = new List<(int, int)>();
                        foreach (List<(int,int)> list in test)
                        {
                            if (!pairs.Contains(list[9]))
                            {
                                pairs.Add(list[9]);
                            }
                        }
                        output += pairs.Count;
                        star2 += test.Count;
                        Move(i,j,0,(i,j));
                    }
                }
            }
            return (output,star2);
        }
        public bool LocationOnMap(int x, int y)
        {
            if ( x >= 0 && x < m_n && y >= 0 && y < m_n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Move(int x, int y, int elevation, (int,int) start)
        {
            if (LocationOnMap(x + 1, y))
            {
                if (m_Map[x + 1,y] == elevation + 1)
                {
                    if(elevation == 8)
                    {
                        m_trailheads.Add(((start.Item1,start.Item2), (x + 1, y)));
                        if(m_Dict.ContainsKey(start))
                        {
                            m_Dict[start]++;
                        }
                        else
                        {
                            m_Dict.Add(start,1);
                        }
                    }
                    else
                    {
                        elevation++;
                        Move(x + 1, y, elevation, start);
                    }
                }
            }
            if (LocationOnMap(x - 1, y))
            {
                if (m_Map[x - 1, y] == elevation + 1)
                {
                    if (elevation == 8)
                    {
                        m_trailheads.Add(((start.Item1, start.Item2), (x - 1, y)));
                        if (m_Dict.ContainsKey(start))
                        {
                            m_Dict[start]++;
                        }
                        else
                        {
                            m_Dict.Add(start, 1);
                        }
                    }
                    else
                    {
                        elevation++;
                        Move(x - 1, y, elevation, start);
                    }
                }
            }
            if (LocationOnMap(x, y + 1))
            {
                if (m_Map[x, y + 1] == elevation + 1)
                {
                    if (elevation == 8)
                    {
                        m_trailheads.Add(((start.Item1, start.Item2), (x, y + 1)));
                        if (m_Dict.ContainsKey(start))
                        {
                            m_Dict[start]++;
                        }
                        else
                        {
                            m_Dict.Add(start, 1);
                        }
                    }
                    else
                    {
                        elevation++;
                        Move(x, y + 1, elevation, start);
                    }
                }
            }
            if (LocationOnMap(x, y - 1))
            {
                if (m_Map[x, y - 1] == elevation + 1)
                {
                    if (elevation == 8)
                    {
                        m_trailheads.Add(((start.Item1, start.Item2), (x, y - 1)));
                        if (m_Dict.ContainsKey(start))
                        {
                            m_Dict[start]++;
                        }
                        else
                        {
                            m_Dict.Add(start, 1);
                        }
                    }
                    else
                    {
                        elevation++;
                        Move(x, y - 1, elevation, start);
                    }
                }
            }

        }
        public List<List<(int,int)>> RecursePath(int n, int x, int y)
        {
            if (n == 0)
            {
                return new List<List<(int, int)>> { new List<(int, int)>() { (x, y) } };
            }
            else
            {
                List<List<(int , int)>> previous = RecursePath(n-1,x,y);
                List<List<(int, int)>> next = new List<List<(int, int)>>();
                foreach(List<(int,int)> list in previous)
                {
                    if(LocationOnMap(list[list.Count - 1].Item1 + 1, list[list.Count - 1].Item2))
                    {
                        if (m_Map[list[list.Count - 1].Item1 + 1, list[list.Count - 1].Item2] == n)
                        {
                            List<(int, int)> copy = list.ToList();
                            copy.Add((list[list.Count - 1].Item1 + 1, list[list.Count - 1].Item2));
                            next.Add(copy);
                        }
                    }
                    if (LocationOnMap(list[list.Count - 1].Item1 - 1, list[list.Count - 1].Item2))
                    {
                        if (m_Map[list[list.Count - 1].Item1 - 1, list[list.Count - 1].Item2] == n)
                        {
                            List<(int, int)> copy2 = list.ToList();
                            copy2.Add((list[list.Count - 1].Item1 - 1, list[list.Count - 1].Item2));
                            next.Add(copy2);
                        }
                    }
                    if (LocationOnMap(list[list.Count - 1].Item1, list[list.Count - 1].Item2 + 1))
                    {
                        if (m_Map[list[list.Count - 1].Item1, list[list.Count - 1].Item2 + 1]  == n)
                        {
                            List<(int, int)> copy3 = list.ToList();
                            copy3.Add((list[list.Count - 1].Item1, list[list.Count - 1].Item2 + 1));
                            next.Add(copy3);
                        }
                    }
                    if (LocationOnMap(list[list.Count - 1].Item1, list[list.Count - 1].Item2 - 1))
                    {
                        if (m_Map[list[list.Count - 1].Item1, list[list.Count - 1].Item2 - 1] == n)
                        {
                            List<(int, int)> copy4 = list.ToList();
                            copy4.Add((list[list.Count - 1].Item1, list[list.Count - 1].Item2 - 1));
                            next.Add(copy4);
                        }
                    }
                }
                return next;
            }
        }
    }
}
