using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D13
    {
        public List<int[]> m_Machines = new List<int[]>();
        public List<long[]> m_Machines2 = new List<long[]>();
        public D13()
        {
            int n = 0;
            int aux = 0;
            List<long> results = new List<long>();
            List<List<int>> numbers = new List<List<int>>();
            string str = "Button A: X+62, Y+48\r\nButton B: X+21, Y+74\r\nPrize: X=3946, Y=6404\r\n\r\nButton A: X+14, Y+66\r\nButton B: X+79, Y+27\r\nPrize: X=9393, Y=7469\r\n\r\nButton A: X+15, Y+42\r\nButton B: X+62, Y+29\r\nPrize: X=367, Y=280\r\n\r\nButton A: X+50, Y+92\r\nButton B: X+99, Y+56\r\nPrize: X=3890, Y=5896\r\n\r\nButton A: X+61, Y+35\r\nButton B: X+23, Y+77\r\nPrize: X=3618, Y=3990\r\n\r\nButton A: X+58, Y+11\r\nButton B: X+32, Y+81\r\nPrize: X=14400, Y=1768\r\n\r\nButton A: X+26, Y+69\r\nButton B: X+49, Y+35\r\nPrize: X=508, Y=968\r\n\r\nButton A: X+11, Y+21\r\nButton B: X+54, Y+20\r\nPrize: X=1996, Y=6718\r\n\r\nButton A: X+47, Y+35\r\nButton B: X+19, Y+54\r\nPrize: X=1314, Y=2453\r\n\r\nButton A: X+13, Y+44\r\nButton B: X+73, Y+21\r\nPrize: X=7316, Y=17026\r\n\r\nButton A: X+20, Y+47\r\nButton B: X+50, Y+27\r\nPrize: X=3360, Y=6107\r\n\r\nButton A: X+19, Y+65\r\nButton B: X+39, Y+12\r\nPrize: X=17960, Y=8711\r\n\r\nButton A: X+24, Y+49\r\nButton B: X+63, Y+30\r\nPrize: X=7589, Y=18325\r\n\r\nButton A: X+18, Y+53\r\nButton B: X+94, Y+53\r\nPrize: X=1532, Y=1378\r\n\r\nButton A: X+19, Y+47\r\nButton B: X+62, Y+17\r\nPrize: X=5722, Y=15472\r\n\r\nButton A: X+89, Y+68\r\nButton B: X+11, Y+51\r\nPrize: X=3176, Y=4386\r\n\r\nButton A: X+12, Y+51\r\nButton B: X+37, Y+17\r\nPrize: X=16775, Y=15119\r\n\r\nButton A: X+22, Y+60\r\nButton B: X+59, Y+28\r\nPrize: X=7431, Y=2100\r\n\r\nButton A: X+71, Y+27\r\nButton B: X+20, Y+59\r\nPrize: X=5683, Y=9988\r\n\r\nButton A: X+53, Y+17\r\nButton B: X+15, Y+48\r\nPrize: X=9147, Y=2208\r\n\r\nButton A: X+21, Y+87\r\nButton B: X+90, Y+13\r\nPrize: X=1317, Y=778\r\n\r\nButton A: X+38, Y+94\r\nButton B: X+40, Y+19\r\nPrize: X=3086, Y=5795\r\n\r\nButton A: X+34, Y+62\r\nButton B: X+45, Y+12\r\nPrize: X=9746, Y=12542\r\n\r\nButton A: X+29, Y+98\r\nButton B: X+92, Y+15\r\nPrize: X=7971, Y=8295\r\n\r\nButton A: X+56, Y+12\r\nButton B: X+20, Y+80\r\nPrize: X=8056, Y=19772\r\n\r\nButton A: X+25, Y+52\r\nButton B: X+38, Y+15\r\nPrize: X=8663, Y=3661\r\n\r\nButton A: X+68, Y+60\r\nButton B: X+11, Y+69\r\nPrize: X=3070, Y=4962\r\n\r\nButton A: X+29, Y+65\r\nButton B: X+46, Y+17\r\nPrize: X=16489, Y=15013\r\n\r\nButton A: X+43, Y+24\r\nButton B: X+18, Y+52\r\nPrize: X=13743, Y=7816\r\n\r\nButton A: X+87, Y+34\r\nButton B: X+34, Y+47\r\nPrize: X=3336, Y=1506\r\n\r\nButton A: X+17, Y+61\r\nButton B: X+91, Y+78\r\nPrize: X=7436, Y=8788\r\n\r\nButton A: X+15, Y+37\r\nButton B: X+50, Y+13\r\nPrize: X=19305, Y=19061\r\n\r\nButton A: X+84, Y+23\r\nButton B: X+13, Y+75\r\nPrize: X=18181, Y=1490\r\n\r\nButton A: X+73, Y+12\r\nButton B: X+32, Y+58\r\nPrize: X=5695, Y=1780\r\n\r\nButton A: X+18, Y+60\r\nButton B: X+80, Y+37\r\nPrize: X=3460, Y=15864\r\n\r\nButton A: X+63, Y+26\r\nButton B: X+28, Y+61\r\nPrize: X=6360, Y=16905\r\n\r\nButton A: X+11, Y+55\r\nButton B: X+37, Y+16\r\nPrize: X=3532, Y=15555\r\n\r\nButton A: X+67, Y+16\r\nButton B: X+16, Y+47\r\nPrize: X=11623, Y=18093\r\n\r\nButton A: X+15, Y+69\r\nButton B: X+50, Y+12\r\nPrize: X=4300, Y=14744\r\n\r\nButton A: X+70, Y+46\r\nButton B: X+22, Y+48\r\nPrize: X=8274, Y=3270\r\n\r\nButton A: X+70, Y+20\r\nButton B: X+86, Y+93\r\nPrize: X=5636, Y=2363\r\n\r\nButton A: X+82, Y+34\r\nButton B: X+12, Y+58\r\nPrize: X=11660, Y=11164\r\n\r\nButton A: X+34, Y+16\r\nButton B: X+20, Y+46\r\nPrize: X=600, Y=10964\r\n\r\nButton A: X+90, Y+37\r\nButton B: X+26, Y+98\r\nPrize: X=3144, Y=3388\r\n\r\nButton A: X+56, Y+22\r\nButton B: X+28, Y+65\r\nPrize: X=2244, Y=403\r\n\r\nButton A: X+82, Y+25\r\nButton B: X+14, Y+15\r\nPrize: X=1684, Y=1490\r\n\r\nButton A: X+15, Y+42\r\nButton B: X+55, Y+25\r\nPrize: X=15825, Y=17469\r\n\r\nButton A: X+11, Y+39\r\nButton B: X+68, Y+14\r\nPrize: X=2069, Y=12193\r\n\r\nButton A: X+31, Y+11\r\nButton B: X+46, Y+80\r\nPrize: X=576, Y=6208\r\n\r\nButton A: X+35, Y+84\r\nButton B: X+83, Y+45\r\nPrize: X=5260, Y=8769\r\n\r\nButton A: X+30, Y+14\r\nButton B: X+31, Y+47\r\nPrize: X=16142, Y=11518\r\n\r\nButton A: X+67, Y+11\r\nButton B: X+22, Y+63\r\nPrize: X=6432, Y=4420\r\n\r\nButton A: X+68, Y+24\r\nButton B: X+20, Y+70\r\nPrize: X=13400, Y=14060\r\n\r\nButton A: X+16, Y+42\r\nButton B: X+66, Y+36\r\nPrize: X=5332, Y=7436\r\n\r\nButton A: X+13, Y+78\r\nButton B: X+74, Y+61\r\nPrize: X=1962, Y=7942\r\n\r\nButton A: X+75, Y+20\r\nButton B: X+11, Y+55\r\nPrize: X=4144, Y=2615\r\n\r\nButton A: X+11, Y+57\r\nButton B: X+53, Y+18\r\nPrize: X=2307, Y=11513\r\n\r\nButton A: X+18, Y+73\r\nButton B: X+56, Y+23\r\nPrize: X=5408, Y=4583\r\n\r\nButton A: X+24, Y+55\r\nButton B: X+48, Y+13\r\nPrize: X=4448, Y=5003\r\n\r\nButton A: X+58, Y+63\r\nButton B: X+93, Y+18\r\nPrize: X=5128, Y=5238\r\n\r\nButton A: X+51, Y+57\r\nButton B: X+87, Y+19\r\nPrize: X=4254, Y=1938\r\n\r\nButton A: X+19, Y+52\r\nButton B: X+85, Y+55\r\nPrize: X=1883, Y=2489\r\n\r\nButton A: X+64, Y+13\r\nButton B: X+13, Y+59\r\nPrize: X=1149, Y=2995\r\n\r\nButton A: X+23, Y+60\r\nButton B: X+86, Y+60\r\nPrize: X=3860, Y=3660\r\n\r\nButton A: X+33, Y+70\r\nButton B: X+50, Y+11\r\nPrize: X=6707, Y=5720\r\n\r\nButton A: X+98, Y+45\r\nButton B: X+20, Y+30\r\nPrize: X=5890, Y=4245\r\n\r\nButton A: X+23, Y+64\r\nButton B: X+53, Y+14\r\nPrize: X=2194, Y=9622\r\n\r\nButton A: X+79, Y+38\r\nButton B: X+12, Y+52\r\nPrize: X=13581, Y=5494\r\n\r\nButton A: X+23, Y+50\r\nButton B: X+55, Y+18\r\nPrize: X=13049, Y=7630\r\n\r\nButton A: X+11, Y+54\r\nButton B: X+73, Y+34\r\nPrize: X=4237, Y=3370\r\n\r\nButton A: X+43, Y+19\r\nButton B: X+21, Y+37\r\nPrize: X=7035, Y=331\r\n\r\nButton A: X+22, Y+43\r\nButton B: X+37, Y+16\r\nPrize: X=4575, Y=13038\r\n\r\nButton A: X+50, Y+18\r\nButton B: X+16, Y+69\r\nPrize: X=19696, Y=11834\r\n\r\nButton A: X+27, Y+62\r\nButton B: X+94, Y+63\r\nPrize: X=9374, Y=6546\r\n\r\nButton A: X+33, Y+18\r\nButton B: X+12, Y+49\r\nPrize: X=10055, Y=13962\r\n\r\nButton A: X+49, Y+15\r\nButton B: X+17, Y+38\r\nPrize: X=5038, Y=1903\r\n\r\nButton A: X+46, Y+65\r\nButton B: X+33, Y+15\r\nPrize: X=1322, Y=5090\r\n\r\nButton A: X+15, Y+30\r\nButton B: X+53, Y+25\r\nPrize: X=12907, Y=7140\r\n\r\nButton A: X+65, Y+36\r\nButton B: X+20, Y+48\r\nPrize: X=1550, Y=1080\r\n\r\nButton A: X+37, Y+14\r\nButton B: X+20, Y+45\r\nPrize: X=14779, Y=19088\r\n\r\nButton A: X+27, Y+58\r\nButton B: X+41, Y+23\r\nPrize: X=12475, Y=5911\r\n\r\nButton A: X+36, Y+15\r\nButton B: X+17, Y+49\r\nPrize: X=13187, Y=9797\r\n\r\nButton A: X+15, Y+42\r\nButton B: X+71, Y+45\r\nPrize: X=7631, Y=16316\r\n\r\nButton A: X+96, Y+48\r\nButton B: X+34, Y+55\r\nPrize: X=4028, Y=2546\r\n\r\nButton A: X+44, Y+26\r\nButton B: X+49, Y+89\r\nPrize: X=3683, Y=3077\r\n\r\nButton A: X+12, Y+83\r\nButton B: X+73, Y+11\r\nPrize: X=8495, Y=15633\r\n\r\nButton A: X+51, Y+13\r\nButton B: X+16, Y+77\r\nPrize: X=10044, Y=16925\r\n\r\nButton A: X+67, Y+22\r\nButton B: X+19, Y+61\r\nPrize: X=7050, Y=3159\r\n\r\nButton A: X+88, Y+21\r\nButton B: X+42, Y+97\r\nPrize: X=7254, Y=1992\r\n\r\nButton A: X+78, Y+19\r\nButton B: X+34, Y+41\r\nPrize: X=4778, Y=3585\r\n\r\nButton A: X+62, Y+19\r\nButton B: X+31, Y+73\r\nPrize: X=3773, Y=18083\r\n\r\nButton A: X+28, Y+66\r\nButton B: X+76, Y+55\r\nPrize: X=9356, Y=10384\r\n\r\nButton A: X+33, Y+83\r\nButton B: X+53, Y+11\r\nPrize: X=8763, Y=9909\r\n\r\nButton A: X+46, Y+12\r\nButton B: X+35, Y+64\r\nPrize: X=6644, Y=11608\r\n\r\nButton A: X+47, Y+17\r\nButton B: X+41, Y+77\r\nPrize: X=15413, Y=4925\r\n\r\nButton A: X+38, Y+13\r\nButton B: X+40, Y+75\r\nPrize: X=6848, Y=13928\r\n\r\nButton A: X+18, Y+45\r\nButton B: X+25, Y+15\r\nPrize: X=17133, Y=10400\r\n\r\nButton A: X+16, Y+76\r\nButton B: X+61, Y+14\r\nPrize: X=16947, Y=666\r\n\r\nButton A: X+13, Y+37\r\nButton B: X+54, Y+34\r\nPrize: X=19571, Y=10963\r\n\r\nButton A: X+16, Y+37\r\nButton B: X+66, Y+24\r\nPrize: X=9800, Y=10640\r\n\r\nButton A: X+45, Y+21\r\nButton B: X+48, Y+83\r\nPrize: X=6828, Y=8398\r\n\r\nButton A: X+12, Y+22\r\nButton B: X+50, Y+21\r\nPrize: X=8444, Y=1198\r\n\r\nButton A: X+62, Y+51\r\nButton B: X+11, Y+70\r\nPrize: X=5407, Y=6581\r\n\r\nButton A: X+28, Y+11\r\nButton B: X+21, Y+68\r\nPrize: X=19219, Y=16319\r\n\r\nButton A: X+99, Y+35\r\nButton B: X+43, Y+79\r\nPrize: X=2211, Y=2887\r\n\r\nButton A: X+56, Y+26\r\nButton B: X+33, Y+60\r\nPrize: X=3067, Y=3586\r\n\r\nButton A: X+24, Y+44\r\nButton B: X+31, Y+14\r\nPrize: X=16060, Y=1468\r\n\r\nButton A: X+11, Y+51\r\nButton B: X+71, Y+34\r\nPrize: X=8684, Y=15629\r\n\r\nButton A: X+11, Y+44\r\nButton B: X+81, Y+43\r\nPrize: X=18983, Y=18130\r\n\r\nButton A: X+24, Y+40\r\nButton B: X+43, Y+14\r\nPrize: X=16053, Y=8370\r\n\r\nButton A: X+36, Y+19\r\nButton B: X+37, Y+88\r\nPrize: X=5509, Y=7906\r\n\r\nButton A: X+46, Y+79\r\nButton B: X+80, Y+21\r\nPrize: X=8446, Y=7638\r\n\r\nButton A: X+46, Y+24\r\nButton B: X+16, Y+53\r\nPrize: X=444, Y=5428\r\n\r\nButton A: X+38, Y+69\r\nButton B: X+31, Y+11\r\nPrize: X=18308, Y=4776\r\n\r\nButton A: X+47, Y+19\r\nButton B: X+21, Y+40\r\nPrize: X=5815, Y=19032\r\n\r\nButton A: X+12, Y+49\r\nButton B: X+85, Y+47\r\nPrize: X=6494, Y=18488\r\n\r\nButton A: X+56, Y+18\r\nButton B: X+28, Y+61\r\nPrize: X=10336, Y=13904\r\n\r\nButton A: X+53, Y+12\r\nButton B: X+27, Y+80\r\nPrize: X=913, Y=11260\r\n\r\nButton A: X+16, Y+78\r\nButton B: X+64, Y+15\r\nPrize: X=2880, Y=15044\r\n\r\nButton A: X+43, Y+96\r\nButton B: X+60, Y+21\r\nPrize: X=5225, Y=9519\r\n\r\nButton A: X+11, Y+27\r\nButton B: X+58, Y+41\r\nPrize: X=6653, Y=14661\r\n\r\nButton A: X+12, Y+54\r\nButton B: X+65, Y+61\r\nPrize: X=4044, Y=7086\r\n\r\nButton A: X+25, Y+70\r\nButton B: X+56, Y+15\r\nPrize: X=14097, Y=9250\r\n\r\nButton A: X+11, Y+73\r\nButton B: X+52, Y+14\r\nPrize: X=3135, Y=8989\r\n\r\nButton A: X+92, Y+39\r\nButton B: X+25, Y+44\r\nPrize: X=5781, Y=4889\r\n\r\nButton A: X+24, Y+40\r\nButton B: X+50, Y+22\r\nPrize: X=3246, Y=3018\r\n\r\nButton A: X+60, Y+42\r\nButton B: X+16, Y+36\r\nPrize: X=12568, Y=16796\r\n\r\nButton A: X+75, Y+40\r\nButton B: X+14, Y+49\r\nPrize: X=19537, Y=16492\r\n\r\nButton A: X+72, Y+31\r\nButton B: X+43, Y+84\r\nPrize: X=3886, Y=2328\r\n\r\nButton A: X+72, Y+14\r\nButton B: X+12, Y+77\r\nPrize: X=3284, Y=19387\r\n\r\nButton A: X+69, Y+37\r\nButton B: X+38, Y+89\r\nPrize: X=6982, Y=7381\r\n\r\nButton A: X+60, Y+15\r\nButton B: X+16, Y+57\r\nPrize: X=10492, Y=1814\r\n\r\nButton A: X+52, Y+72\r\nButton B: X+68, Y+28\r\nPrize: X=6104, Y=3424\r\n\r\nButton A: X+19, Y+12\r\nButton B: X+20, Y+58\r\nPrize: X=1189, Y=2974\r\n\r\nButton A: X+65, Y+33\r\nButton B: X+24, Y+47\r\nPrize: X=16767, Y=13934\r\n\r\nButton A: X+76, Y+13\r\nButton B: X+44, Y+97\r\nPrize: X=1812, Y=3531\r\n\r\nButton A: X+41, Y+22\r\nButton B: X+38, Y+76\r\nPrize: X=5043, Y=4986\r\n\r\nButton A: X+41, Y+19\r\nButton B: X+21, Y+73\r\nPrize: X=4361, Y=6513\r\n\r\nButton A: X+25, Y+97\r\nButton B: X+37, Y+31\r\nPrize: X=2121, Y=4515\r\n\r\nButton A: X+21, Y+48\r\nButton B: X+56, Y+22\r\nPrize: X=12653, Y=1688\r\n\r\nButton A: X+63, Y+34\r\nButton B: X+34, Y+64\r\nPrize: X=16084, Y=18336\r\n\r\nButton A: X+53, Y+17\r\nButton B: X+31, Y+62\r\nPrize: X=11230, Y=8291\r\n\r\nButton A: X+78, Y+15\r\nButton B: X+94, Y+87\r\nPrize: X=7660, Y=6918\r\n\r\nButton A: X+82, Y+25\r\nButton B: X+12, Y+52\r\nPrize: X=8056, Y=3858\r\n\r\nButton A: X+78, Y+48\r\nButton B: X+27, Y+80\r\nPrize: X=4581, Y=6432\r\n\r\nButton A: X+41, Y+12\r\nButton B: X+26, Y+65\r\nPrize: X=7348, Y=4215\r\n\r\nButton A: X+66, Y+87\r\nButton B: X+87, Y+32\r\nPrize: X=6324, Y=3706\r\n\r\nButton A: X+53, Y+14\r\nButton B: X+18, Y+53\r\nPrize: X=8546, Y=9263\r\n\r\nButton A: X+15, Y+48\r\nButton B: X+52, Y+20\r\nPrize: X=1621, Y=3284\r\n\r\nButton A: X+48, Y+90\r\nButton B: X+66, Y+11\r\nPrize: X=2250, Y=3655\r\n\r\nButton A: X+13, Y+47\r\nButton B: X+59, Y+18\r\nPrize: X=9432, Y=2691\r\n\r\nButton A: X+38, Y+11\r\nButton B: X+16, Y+67\r\nPrize: X=13954, Y=19138\r\n\r\nButton A: X+13, Y+38\r\nButton B: X+44, Y+16\r\nPrize: X=9077, Y=11150\r\n\r\nButton A: X+84, Y+31\r\nButton B: X+48, Y+98\r\nPrize: X=6756, Y=10281\r\n\r\nButton A: X+15, Y+50\r\nButton B: X+73, Y+23\r\nPrize: X=3235, Y=18700\r\n\r\nButton A: X+23, Y+41\r\nButton B: X+67, Y+20\r\nPrize: X=4963, Y=2881\r\n\r\nButton A: X+18, Y+65\r\nButton B: X+56, Y+15\r\nPrize: X=4992, Y=5655\r\n\r\nButton A: X+50, Y+17\r\nButton B: X+28, Y+51\r\nPrize: X=14692, Y=5242\r\n\r\nButton A: X+65, Y+15\r\nButton B: X+14, Y+53\r\nPrize: X=9264, Y=10918\r\n\r\nButton A: X+71, Y+34\r\nButton B: X+30, Y+81\r\nPrize: X=2598, Y=4176\r\n\r\nButton A: X+62, Y+22\r\nButton B: X+34, Y+76\r\nPrize: X=17948, Y=3296\r\n\r\nButton A: X+80, Y+23\r\nButton B: X+53, Y+72\r\nPrize: X=5276, Y=2198\r\n\r\nButton A: X+49, Y+25\r\nButton B: X+36, Y+56\r\nPrize: X=18951, Y=2903\r\n\r\nButton A: X+51, Y+12\r\nButton B: X+14, Y+44\r\nPrize: X=9882, Y=6180\r\n\r\nButton A: X+54, Y+74\r\nButton B: X+25, Y+11\r\nPrize: X=4031, Y=4989\r\n\r\nButton A: X+27, Y+56\r\nButton B: X+35, Y+21\r\nPrize: X=10038, Y=7662\r\n\r\nButton A: X+33, Y+80\r\nButton B: X+67, Y+45\r\nPrize: X=6928, Y=9280\r\n\r\nButton A: X+17, Y+14\r\nButton B: X+11, Y+85\r\nPrize: X=1338, Y=2241\r\n\r\nButton A: X+32, Y+44\r\nButton B: X+37, Y+14\r\nPrize: X=4167, Y=16174\r\n\r\nButton A: X+34, Y+56\r\nButton B: X+82, Y+26\r\nPrize: X=9362, Y=4732\r\n\r\nButton A: X+55, Y+87\r\nButton B: X+81, Y+42\r\nPrize: X=7654, Y=7887\r\n\r\nButton A: X+34, Y+73\r\nButton B: X+43, Y+20\r\nPrize: X=1346, Y=2456\r\n\r\nButton A: X+14, Y+22\r\nButton B: X+25, Y+13\r\nPrize: X=4534, Y=10958\r\n\r\nButton A: X+24, Y+71\r\nButton B: X+52, Y+16\r\nPrize: X=12916, Y=3562\r\n\r\nButton A: X+23, Y+57\r\nButton B: X+33, Y+18\r\nPrize: X=9501, Y=12137\r\n\r\nButton A: X+17, Y+99\r\nButton B: X+76, Y+51\r\nPrize: X=7738, Y=7470\r\n\r\nButton A: X+28, Y+85\r\nButton B: X+69, Y+13\r\nPrize: X=15991, Y=13874\r\n\r\nButton A: X+26, Y+68\r\nButton B: X+68, Y+20\r\nPrize: X=17416, Y=17224\r\n\r\nButton A: X+86, Y+17\r\nButton B: X+55, Y+51\r\nPrize: X=3871, Y=3213\r\n\r\nButton A: X+37, Y+11\r\nButton B: X+26, Y+67\r\nPrize: X=10077, Y=3613\r\n\r\nButton A: X+18, Y+30\r\nButton B: X+97, Y+50\r\nPrize: X=1859, Y=1870\r\n\r\nButton A: X+59, Y+32\r\nButton B: X+34, Y+58\r\nPrize: X=14268, Y=8286\r\n\r\nButton A: X+27, Y+54\r\nButton B: X+56, Y+33\r\nPrize: X=4651, Y=6143\r\n\r\nButton A: X+88, Y+38\r\nButton B: X+18, Y+57\r\nPrize: X=9788, Y=8854\r\n\r\nButton A: X+62, Y+18\r\nButton B: X+12, Y+59\r\nPrize: X=16650, Y=1065\r\n\r\nButton A: X+48, Y+66\r\nButton B: X+35, Y+13\r\nPrize: X=11648, Y=14762\r\n\r\nButton A: X+82, Y+57\r\nButton B: X+40, Y+92\r\nPrize: X=3748, Y=4146\r\n\r\nButton A: X+78, Y+13\r\nButton B: X+58, Y+52\r\nPrize: X=12570, Y=6032\r\n\r\nButton A: X+28, Y+56\r\nButton B: X+60, Y+35\r\nPrize: X=12124, Y=2363\r\n\r\nButton A: X+79, Y+30\r\nButton B: X+15, Y+51\r\nPrize: X=1666, Y=7601\r\n\r\nButton A: X+60, Y+12\r\nButton B: X+15, Y+61\r\nPrize: X=17825, Y=5203\r\n\r\nButton A: X+33, Y+17\r\nButton B: X+14, Y+23\r\nPrize: X=6805, Y=19369\r\n\r\nButton A: X+13, Y+41\r\nButton B: X+75, Y+30\r\nPrize: X=8216, Y=3962\r\n\r\nButton A: X+12, Y+42\r\nButton B: X+74, Y+24\r\nPrize: X=17410, Y=9800\r\n\r\nButton A: X+95, Y+47\r\nButton B: X+28, Y+97\r\nPrize: X=1169, Y=2075\r\n\r\nButton A: X+44, Y+62\r\nButton B: X+98, Y+22\r\nPrize: X=12870, Y=6642\r\n\r\nButton A: X+62, Y+20\r\nButton B: X+21, Y+51\r\nPrize: X=1885, Y=11497\r\n\r\nButton A: X+38, Y+68\r\nButton B: X+49, Y+22\r\nPrize: X=14751, Y=2442\r\n\r\nButton A: X+47, Y+14\r\nButton B: X+16, Y+64\r\nPrize: X=1315, Y=2902\r\n\r\nButton A: X+36, Y+69\r\nButton B: X+84, Y+14\r\nPrize: X=7416, Y=6276\r\n\r\nButton A: X+79, Y+19\r\nButton B: X+35, Y+82\r\nPrize: X=4501, Y=8220\r\n\r\nButton A: X+79, Y+12\r\nButton B: X+69, Y+90\r\nPrize: X=12481, Y=8814\r\n\r\nButton A: X+93, Y+59\r\nButton B: X+30, Y+94\r\nPrize: X=8118, Y=7774\r\n\r\nButton A: X+47, Y+93\r\nButton B: X+91, Y+29\r\nPrize: X=10288, Y=8272\r\n\r\nButton A: X+60, Y+20\r\nButton B: X+48, Y+66\r\nPrize: X=3588, Y=4496\r\n\r\nButton A: X+15, Y+66\r\nButton B: X+56, Y+19\r\nPrize: X=3688, Y=1515\r\n\r\nButton A: X+65, Y+15\r\nButton B: X+26, Y+70\r\nPrize: X=16500, Y=12300\r\n\r\nButton A: X+42, Y+38\r\nButton B: X+87, Y+12\r\nPrize: X=7665, Y=3666\r\n\r\nButton A: X+85, Y+42\r\nButton B: X+53, Y+97\r\nPrize: X=4910, Y=7737\r\n\r\nButton A: X+96, Y+52\r\nButton B: X+35, Y+65\r\nPrize: X=4301, Y=5967\r\n\r\nButton A: X+94, Y+78\r\nButton B: X+16, Y+74\r\nPrize: X=3226, Y=5288\r\n\r\nButton A: X+31, Y+76\r\nButton B: X+50, Y+15\r\nPrize: X=7652, Y=15977\r\n\r\nButton A: X+11, Y+52\r\nButton B: X+78, Y+26\r\nPrize: X=1476, Y=2522\r\n\r\nButton A: X+24, Y+13\r\nButton B: X+24, Y+42\r\nPrize: X=15416, Y=11932\r\n\r\nButton A: X+27, Y+59\r\nButton B: X+58, Y+18\r\nPrize: X=10884, Y=2044\r\n\r\nButton A: X+65, Y+14\r\nButton B: X+50, Y+48\r\nPrize: X=9195, Y=5294\r\n\r\nButton A: X+56, Y+23\r\nButton B: X+18, Y+64\r\nPrize: X=6606, Y=10568\r\n\r\nButton A: X+20, Y+59\r\nButton B: X+60, Y+24\r\nPrize: X=11300, Y=9950\r\n\r\nButton A: X+79, Y+24\r\nButton B: X+14, Y+64\r\nPrize: X=10080, Y=15680\r\n\r\nButton A: X+80, Y+29\r\nButton B: X+34, Y+42\r\nPrize: X=5076, Y=2849\r\n\r\nButton A: X+39, Y+15\r\nButton B: X+34, Y+60\r\nPrize: X=11578, Y=17000\r\n\r\nButton A: X+82, Y+38\r\nButton B: X+18, Y+34\r\nPrize: X=4504, Y=2780\r\n\r\nButton A: X+30, Y+19\r\nButton B: X+19, Y+43\r\nPrize: X=18763, Y=12159\r\n\r\nButton A: X+32, Y+33\r\nButton B: X+75, Y+18\r\nPrize: X=7155, Y=2097\r\n\r\nButton A: X+42, Y+14\r\nButton B: X+30, Y+67\r\nPrize: X=8144, Y=12035\r\n\r\nButton A: X+23, Y+43\r\nButton B: X+47, Y+21\r\nPrize: X=15418, Y=7394\r\n\r\nButton A: X+38, Y+99\r\nButton B: X+77, Y+49\r\nPrize: X=7550, Y=9967\r\n\r\nButton A: X+13, Y+61\r\nButton B: X+28, Y+11\r\nPrize: X=3003, Y=4701\r\n\r\nButton A: X+50, Y+13\r\nButton B: X+65, Y+92\r\nPrize: X=8430, Y=8350\r\n\r\nButton A: X+48, Y+71\r\nButton B: X+41, Y+13\r\nPrize: X=2935, Y=15156\r\n\r\nButton A: X+61, Y+40\r\nButton B: X+32, Y+93\r\nPrize: X=5820, Y=10874\r\n\r\nButton A: X+73, Y+12\r\nButton B: X+11, Y+45\r\nPrize: X=2352, Y=12983\r\n\r\nButton A: X+41, Y+17\r\nButton B: X+19, Y+55\r\nPrize: X=6540, Y=7920\r\n\r\nButton A: X+70, Y+28\r\nButton B: X+24, Y+64\r\nPrize: X=6710, Y=11820\r\n\r\nButton A: X+16, Y+71\r\nButton B: X+75, Y+21\r\nPrize: X=4864, Y=18423\r\n\r\nButton A: X+93, Y+16\r\nButton B: X+31, Y+43\r\nPrize: X=6851, Y=4305\r\n\r\nButton A: X+65, Y+28\r\nButton B: X+15, Y+42\r\nPrize: X=4895, Y=4312\r\n\r\nButton A: X+14, Y+21\r\nButton B: X+37, Y+15\r\nPrize: X=8114, Y=11906\r\n\r\nButton A: X+15, Y+69\r\nButton B: X+40, Y+13\r\nPrize: X=5765, Y=17537\r\n\r\nButton A: X+56, Y+15\r\nButton B: X+23, Y+64\r\nPrize: X=2790, Y=12835\r\n\r\nButton A: X+55, Y+17\r\nButton B: X+12, Y+60\r\nPrize: X=4915, Y=1077\r\n\r\nButton A: X+77, Y+12\r\nButton B: X+15, Y+61\r\nPrize: X=833, Y=10411\r\n\r\nButton A: X+84, Y+52\r\nButton B: X+29, Y+82\r\nPrize: X=3746, Y=3728\r\n\r\nButton A: X+22, Y+68\r\nButton B: X+80, Y+70\r\nPrize: X=6040, Y=6260\r\n\r\nButton A: X+39, Y+15\r\nButton B: X+38, Y+59\r\nPrize: X=15452, Y=3962\r\n\r\nButton A: X+34, Y+15\r\nButton B: X+26, Y+62\r\nPrize: X=9220, Y=2426\r\n\r\nButton A: X+48, Y+44\r\nButton B: X+14, Y+58\r\nPrize: X=5134, Y=7642\r\n\r\nButton A: X+99, Y+87\r\nButton B: X+86, Y+12\r\nPrize: X=8829, Y=2037\r\n\r\nButton A: X+95, Y+13\r\nButton B: X+30, Y+84\r\nPrize: X=4540, Y=3098\r\n\r\nButton A: X+13, Y+95\r\nButton B: X+95, Y+77\r\nPrize: X=9667, Y=13241\r\n\r\nButton A: X+62, Y+19\r\nButton B: X+25, Y+69\r\nPrize: X=3712, Y=6724\r\n\r\nButton A: X+23, Y+54\r\nButton B: X+48, Y+28\r\nPrize: X=8619, Y=18970\r\n\r\nButton A: X+27, Y+12\r\nButton B: X+23, Y+41\r\nPrize: X=1893, Y=1857\r\n\r\nButton A: X+25, Y+59\r\nButton B: X+53, Y+17\r\nPrize: X=12619, Y=11763\r\n\r\nButton A: X+19, Y+25\r\nButton B: X+50, Y+17\r\nPrize: X=2982, Y=2460\r\n\r\nButton A: X+40, Y+79\r\nButton B: X+61, Y+28\r\nPrize: X=6621, Y=5586\r\n\r\nButton A: X+12, Y+56\r\nButton B: X+59, Y+19\r\nPrize: X=11964, Y=6068\r\n\r\nButton A: X+37, Y+95\r\nButton B: X+56, Y+39\r\nPrize: X=6635, Y=10644\r\n\r\nButton A: X+67, Y+27\r\nButton B: X+17, Y+48\r\nPrize: X=5655, Y=9518\r\n\r\nButton A: X+66, Y+12\r\nButton B: X+18, Y+52\r\nPrize: X=19562, Y=1988\r\n\r\nButton A: X+21, Y+57\r\nButton B: X+66, Y+32\r\nPrize: X=11801, Y=5977\r\n\r\nButton A: X+14, Y+55\r\nButton B: X+82, Y+39\r\nPrize: X=412, Y=8162\r\n\r\nButton A: X+53, Y+27\r\nButton B: X+11, Y+28\r\nPrize: X=16579, Y=8710\r\n\r\nButton A: X+20, Y+70\r\nButton B: X+70, Y+26\r\nPrize: X=8530, Y=9390\r\n\r\nButton A: X+35, Y+11\r\nButton B: X+51, Y+83\r\nPrize: X=5094, Y=11694\r\n\r\nButton A: X+28, Y+44\r\nButton B: X+72, Y+15\r\nPrize: X=3648, Y=1905\r\n\r\nButton A: X+64, Y+14\r\nButton B: X+42, Y+96\r\nPrize: X=7374, Y=8124\r\n\r\nButton A: X+25, Y+87\r\nButton B: X+79, Y+36\r\nPrize: X=1809, Y=1278\r\n\r\nButton A: X+64, Y+87\r\nButton B: X+70, Y+18\r\nPrize: X=9860, Y=9237\r\n\r\nButton A: X+93, Y+56\r\nButton B: X+14, Y+92\r\nPrize: X=9180, Y=7032\r\n\r\nButton A: X+70, Y+12\r\nButton B: X+12, Y+37\r\nPrize: X=10884, Y=1351\r\n\r\nButton A: X+92, Y+70\r\nButton B: X+13, Y+85\r\nPrize: X=6266, Y=6420\r\n\r\nButton A: X+13, Y+91\r\nButton B: X+94, Y+38\r\nPrize: X=9417, Y=5779\r\n\r\nButton A: X+54, Y+22\r\nButton B: X+15, Y+27\r\nPrize: X=7742, Y=16598\r\n\r\nButton A: X+23, Y+55\r\nButton B: X+52, Y+18\r\nPrize: X=9181, Y=7813\r\n\r\nButton A: X+17, Y+35\r\nButton B: X+46, Y+23\r\nPrize: X=3863, Y=16241\r\n\r\nButton A: X+29, Y+11\r\nButton B: X+18, Y+32\r\nPrize: X=17920, Y=6300\r\n\r\nButton A: X+34, Y+80\r\nButton B: X+99, Y+66\r\nPrize: X=3554, Y=3688\r\n\r\nButton A: X+19, Y+40\r\nButton B: X+79, Y+33\r\nPrize: X=8099, Y=5852\r\n\r\nButton A: X+96, Y+33\r\nButton B: X+31, Y+49\r\nPrize: X=4001, Y=5018\r\n\r\nButton A: X+65, Y+46\r\nButton B: X+20, Y+87\r\nPrize: X=3770, Y=9297\r\n\r\nButton A: X+13, Y+38\r\nButton B: X+44, Y+31\r\nPrize: X=8799, Y=18736\r\n\r\nButton A: X+73, Y+45\r\nButton B: X+17, Y+47\r\nPrize: X=12662, Y=350\r\n\r\nButton A: X+21, Y+51\r\nButton B: X+59, Y+25\r\nPrize: X=17122, Y=3246\r\n\r\nButton A: X+49, Y+28\r\nButton B: X+20, Y+47\r\nPrize: X=18656, Y=16322\r\n\r\nButton A: X+60, Y+14\r\nButton B: X+28, Y+62\r\nPrize: X=13800, Y=15636\r\n\r\nButton A: X+52, Y+30\r\nButton B: X+15, Y+36\r\nPrize: X=9941, Y=4094\r\n\r\nButton A: X+65, Y+35\r\nButton B: X+13, Y+46\r\nPrize: X=14589, Y=513\r\n\r\nButton A: X+93, Y+59\r\nButton B: X+23, Y+84\r\nPrize: X=3917, Y=5886\r\n\r\nButton A: X+22, Y+54\r\nButton B: X+86, Y+16\r\nPrize: X=4048, Y=5644\r\n\r\nButton A: X+62, Y+23\r\nButton B: X+23, Y+37\r\nPrize: X=6447, Y=3388\r\n\r\nButton A: X+77, Y+36\r\nButton B: X+24, Y+79\r\nPrize: X=4298, Y=6754\r\n\r\nButton A: X+54, Y+29\r\nButton B: X+11, Y+25\r\nPrize: X=5275, Y=10524\r\n\r\nButton A: X+67, Y+74\r\nButton B: X+95, Y+30\r\nPrize: X=10602, Y=7364\r\n\r\nButton A: X+18, Y+42\r\nButton B: X+98, Y+65\r\nPrize: X=4582, Y=4963\r\n\r\nButton A: X+70, Y+25\r\nButton B: X+16, Y+64\r\nPrize: X=4324, Y=11566\r\n\r\nButton A: X+48, Y+14\r\nButton B: X+35, Y+75\r\nPrize: X=1662, Y=6676\r\n\r\nButton A: X+20, Y+45\r\nButton B: X+62, Y+25\r\nPrize: X=9014, Y=17975\r\n\r\nButton A: X+11, Y+53\r\nButton B: X+74, Y+31\r\nPrize: X=2157, Y=4533\r\n\r\nButton A: X+88, Y+30\r\nButton B: X+42, Y+72\r\nPrize: X=7834, Y=6420\r\n\r\nButton A: X+78, Y+39\r\nButton B: X+34, Y+62\r\nPrize: X=8208, Y=8154\r\n\r\nButton A: X+12, Y+38\r\nButton B: X+71, Y+47\r\nPrize: X=15341, Y=14727\r\n\r\nButton A: X+73, Y+51\r\nButton B: X+19, Y+94\r\nPrize: X=6062, Y=10451\r\n\r\nButton A: X+21, Y+84\r\nButton B: X+44, Y+21\r\nPrize: X=4675, Y=9555\r\n\r\nButton A: X+58, Y+75\r\nButton B: X+81, Y+31\r\nPrize: X=5008, Y=5296\r\n\r\nButton A: X+54, Y+23\r\nButton B: X+15, Y+42\r\nPrize: X=4154, Y=3125\r\n\r\nButton A: X+65, Y+20\r\nButton B: X+15, Y+39\r\nPrize: X=8845, Y=1030\r\n\r\nButton A: X+20, Y+75\r\nButton B: X+93, Y+70\r\nPrize: X=9687, Y=8730\r\n\r\nButton A: X+51, Y+24\r\nButton B: X+29, Y+59\r\nPrize: X=13536, Y=12777\r\n\r\nButton A: X+53, Y+11\r\nButton B: X+39, Y+78\r\nPrize: X=6231, Y=13482\r\n\r\nButton A: X+24, Y+94\r\nButton B: X+44, Y+30\r\nPrize: X=1912, Y=2934\r\n\r\nButton A: X+24, Y+92\r\nButton B: X+89, Y+50\r\nPrize: X=4351, Y=9982\r\n\r\nButton A: X+35, Y+88\r\nButton B: X+85, Y+28\r\nPrize: X=4775, Y=6620\r\n\r\nButton A: X+12, Y+19\r\nButton B: X+44, Y+15\r\nPrize: X=16064, Y=11340\r\n\r\nButton A: X+36, Y+78\r\nButton B: X+75, Y+27\r\nPrize: X=4236, Y=4842\r\n\r\nButton A: X+24, Y+74\r\nButton B: X+55, Y+16\r\nPrize: X=19430, Y=3834\r\n\r\nButton A: X+21, Y+59\r\nButton B: X+94, Y+17\r\nPrize: X=10632, Y=6891\r\n\r\nButton A: X+33, Y+13\r\nButton B: X+43, Y+98\r\nPrize: X=3645, Y=5570\r\n\r\nButton A: X+24, Y+92\r\nButton B: X+25, Y+19\r\nPrize: X=3891, Y=9153\r\n\r\nButton A: X+61, Y+87\r\nButton B: X+94, Y+38\r\nPrize: X=9321, Y=9067\r";
            //string str = "Button A: X+94, Y+34\r\nButton B: X+22, Y+67\r\nPrize: X=8400, Y=5400\r\n\r\nButton A: X+26, Y+66\r\nButton B: X+67, Y+21\r\nPrize: X=12748, Y=12176\r\n\r\nButton A: X+17, Y+86\r\nButton B: X+84, Y+37\r\nPrize: X=7870, Y=6450\r\n\r\nButton A: X+69, Y+23\r\nButton B: X+27, Y+71\r\nPrize: X=18641, Y=10279\r";
            int[] temp = new int[6];
            int aux2 = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'A')
                {
                    string firstnumber = "";
                    bool Found = false;
                    for (int j = i + 1; j < str.Length && Found == false; j++)
                    {
                        if (Numeric(str[j]))
                        {
                            firstnumber += str[j];
                        }
                        if (str[j] == ',')
                        {
                            Found = true;
                            temp[0] = int.Parse(firstnumber);
                            i = j + 1;
                            aux2 = 1;
                        }
                    }
                }
                if (str.Substring(i,2) == "Y+")
                {
                    string firstnumber = "";
                    bool Found = false;
                    for (int j = i + 1; j < str.Length && Found == false; j++)
                    {
                        if (Numeric(str[j]))
                        {
                            firstnumber += str[j];
                        }
                        if (str[j] == '\r')
                        {
                            Found = true;
                            if(aux2 == 1)
                            {
                                temp[1] = int.Parse(firstnumber);
                            }
                            else
                            {
                                temp[3] = int.Parse(firstnumber);
                            }
                            i = j + 1;
                        }
                    }
                }
                if (str.Substring(i,2) == "B:")
                {
                    string firstnumber = "";
                    bool Found = false;
                    for (int j = i + 1; j < str.Length && Found == false; j++)
                    {
                        if (Numeric(str[j]))
                        {
                            firstnumber += str[j];
                        }
                        if (str[j] == ',')
                        {
                            Found = true;
                            temp[2] = int.Parse(firstnumber);
                            i = j + 1;
                            aux2 = 2;
                        }
                    }
                }
                if (str[i] == 'P')
                {
                    string firstnumber = "";
                    bool Found = false;
                    for (int j = i + 1; j < str.Length && Found == false; j++)
                    {
                        if (Numeric(str[j]))
                        {
                            firstnumber += str[j];
                        }
                        if (str[j] == ',')
                        {
                            Found = true;
                            temp[4] = int.Parse(firstnumber);
                            i = j + 1;
                        }
                    }
                }
                if (str.Substring(i, 2) == "Y=")
                {
                    string firstnumber = "";
                    bool Found = false;
                    for (int j = i + 1; j < str.Length && Found == false; j++)
                    {
                        if (Numeric(str[j]))
                        {
                            firstnumber += str[j];
                        }
                        if (str[j] == '\r')
                        {
                            Found = true;
                            temp[5] = int.Parse(firstnumber);
                            i = j + 1;

                            m_Machines.Add((int[])temp.Clone());
                        }
                    }
                }
            }
        }
        public long star1()
        {
            long output = 0;
            List<List<(int,int)>> possibilities = new List<List<(int,int)>>();
            for(int i = 0; i < m_Machines.Count; i++)
            {
                possibilities.Add(Solve(m_Machines[i][0], m_Machines[i][1], m_Machines[i][2], m_Machines[i][3], m_Machines[i][4], m_Machines[i][5]));
            }
            foreach(List<(int,int)> list in possibilities)
            {
                foreach((int,int) point in list)
                {
                    output += point.Item1 * 3 + point.Item2;
                }
            }
            return output;
        }
        public long star2()
        {
            int output = 0;
            List<(long,long)> solutions = new List<(long, long)> ();
            foreach(int[] array in m_Machines )
            {
                long[] temp = new long[6];
                for(int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                temp[4] += 10000000000000;
                temp[5] += 10000000000000;
                solutions.Add(Solve2(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]));
            }
            return output;
        }
        public (long, long) Solve2(long AX, long AY, long BX, long BY, long X, long Y)
        {
            long startA = Math.Min((int)Math.Ceiling((float)(X) / (float)(AX)), (int)Math.Ceiling((float)(Y) / (float)(AY)));
            long startB = Math.Min((int)Math.Ceiling((float)(X) / (float)(BX)), (int)Math.Ceiling((float)(Y) / (float)(BY)));
            bool Found = false;
            long z = Math.Abs(X - (AX * (startA) + BX * startB)) + Math.Abs(Y - (AY * (startA) + BY * startB));
            for (int i = 0; i < 10000; i++)
            {
                long stepsize = 1;
                if(i < 100)
                {
                    stepsize = 100000000000;
                }
                if (i > 100 && i < 200)
                {
                    stepsize = 100000000;
                }
                if (i < 100 && i < 300)
                {
                    stepsize = 1000000;
                }
                if (i < 100 && i < 400)
                {
                    stepsize = 1000;
                }
                if (i < 100 && i < 500)
                {
                    stepsize = 10;
                }
                if (i > 500)
                {
                    stepsize = 10;
                }
                (long,long,long) result = Search(startA, startB, stepsize, z, AX, AY, BX, BY, X, Y);
                z = result.Item1;
                startA = result.Item2;
                startB = result.Item3;
            }
            return (startA, startB);
        }
        public (long,long,long) Search(long s1, long s2, long stepsize, long z, long AX, long AY, long BX, long BY, long X, long Y)
        {
            long min = z;
            long output1 = s1;
            long output2 = s2;
            if( Math.Abs(X - (AX*(s1 + stepsize) + BX*s2)) + Math.Abs(Y - (AY*(s1 + stepsize) + BY*s2)) < min)
            {
                min = Math.Abs(X - (AX * (s1 + stepsize) + BX * s2)) + Math.Abs(Y - (AY * (s1 + stepsize) + BY * s2));
                output1 = s1 + stepsize;
                output2 = s2;
            }
            if (Math.Abs(X - (AX * (s1 - stepsize) + BX * s2)) + Math.Abs(Y - (AY * (s1 - stepsize) + BY * s2)) < min)
            {
                min = Math.Abs(X - (AX * (s1 - stepsize) + BX * s2)) + Math.Abs(Y - (AY * (s1 - stepsize) + BY * s2));
                output1 = s1 - stepsize;
                output2 = s2;
            }
            if (Math.Abs(X - (AX * s1 + BX * (s2 - stepsize))) + Math.Abs(Y - (AY * s1 + BY * (s2 - stepsize))) < min)
            {
                min = Math.Abs(X - (AX * s1 + BX * (s2 - stepsize))) + Math.Abs(Y - (AY * s1 + BY * (s2 - stepsize)));
                output1 = s1;
                output2 = s2 - stepsize;
            }
            if (Math.Abs(X - (AX * s1 + BX * (s2 + stepsize))) + Math.Abs(Y - (AY * s1 + BY * (s2 + stepsize))) < min)
            {
                min = Math.Abs(X - (AX * s1 + BX * (s2 + stepsize))) + Math.Abs(Y - (AY * s1 + BY * (s2 + stepsize)));
                output1 = s1;
                output2 = s2 + stepsize;
            }
            return (z, output1, output2);
        }
        public List<(int, int)> Solve(int AX, int AY,  int BX, int BY, int X, int Y)
        {
            List<(int,int)> Output = new List<(int, int)> ();
            int MaxA = Math.Max((int)Math.Ceiling((float)(X) / (float)(AX)), (int)Math.Ceiling((float)(Y) / (float)(AY)));
            int MaxB = Math.Max((int)Math.Ceiling((float)(X) / (float)(BX)), (int)Math.Ceiling((float)(Y) / (float)(BY)));
            int[] A = new int[MaxA];
            int[] B = new int[MaxB];
            for(int i = 0;  i < MaxA; i++)
            {
                A[i] = i + 1;
            }
            for (int i = 0; i < MaxB; i++)
            {
                B[i] = i + 1;
            }
            for (int i = 0; i < MaxA; i++)
            {
                for (int j = 0; j < MaxB; j++)
                {
                    if (AX * A[i] + BX * B[j] == X && AY * A[i] + BY * B[j] == Y)
                    {
                        Output.Add((A[i], B[j]));
                    }
                }
            }
            return Output;
        }
        public bool Numeric(char a)
        {
            if (a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9' || a == '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
