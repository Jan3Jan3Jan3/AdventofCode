﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D2
    {
        public List<int[]> m_list;
        public D2()
        {
            List<int[]> list = new List<int[]>();
            List<int> temp = new List<int>();
            string str = "51 54 57 60 61 64 67 64\r\n54 56 57 58 60 60\r\n41 44 45 46 48 50 54\r\n62 64 67 69 72 79\r\n57 58 61 62 63 61 64\r\n81 84 82 84 87 85\r\n15 17 15 16 16\r\n82 85 87 85 87 91\r\n5 6 5 8 10 12 17\r\n69 70 71 73 74 74 76\r\n12 13 16 17 20 21 21 20\r\n25 28 29 30 30 32 32\r\n38 40 41 41 42 43 47\r\n62 65 65 68 73\r\n77 79 83 86 89\r\n22 25 26 30 31 32 33 30\r\n2 3 7 9 11 11\r\n59 62 65 66 70 74\r\n67 68 69 73 80\r\n34 37 38 39 45 47 48 51\r\n77 80 82 85 91 93 90\r\n52 55 61 64 64\r\n50 52 59 61 64 68\r\n70 73 74 81 84 90\r\n77 75 76 77 80 83 85 88\r\n18 17 18 19 20 18\r\n71 69 72 74 74\r\n14 13 14 16 20\r\n62 60 63 65 66 68 71 77\r\n31 28 27 30 31\r\n82 79 78 79 81 78\r\n83 82 79 81 81\r\n38 35 38 41 42 41 45\r\n58 57 59 61 59 61 64 70\r\n64 62 65 66 69 71 71 73\r\n38 35 38 38 40 37\r\n43 41 44 46 49 49 49\r\n13 10 10 12 15 17 21\r\n30 28 30 30 31 33 36 41\r\n90 89 91 95 96\r\n55 52 56 57 54\r\n46 44 48 50 50\r\n61 59 63 65 67 71\r\n66 65 67 70 74 80\r\n26 25 28 35 36\r\n88 87 88 91 96 97 96\r\n81 79 86 89 90 92 95 95\r\n28 25 26 32 34 38\r\n59 56 57 58 59 60 66 73\r\n27 27 30 33 34\r\n4 4 7 9 10 13 16 13\r\n35 35 36 39 40 43 43\r\n62 62 64 66 69 73\r\n70 70 71 73 79\r\n96 96 93 95 96\r\n74 74 72 74 73\r\n31 31 30 31 32 32\r\n2 2 3 6 4 5 7 11\r\n32 32 29 30 35\r\n75 75 75 78 79 80\r\n28 28 30 32 35 35 33\r\n94 94 95 97 97 97\r\n54 54 56 56 58 61 65\r\n39 39 41 44 47 47 52\r\n12 12 16 17 18 21\r\n83 83 86 90 91 92 90\r\n38 38 42 44 46 47 49 49\r\n3 3 5 6 10 14\r\n78 78 82 85 92\r\n13 13 20 22 25 28\r\n54 54 57 60 62 69 67\r\n67 67 69 76 76\r\n1 1 3 8 12\r\n52 52 54 55 57 59 65 70\r\n23 27 28 31 34 37 39 42\r\n37 41 42 45 47 50 53 50\r\n84 88 90 92 93 94 95 95\r\n48 52 53 54 56 59 60 64\r\n58 62 65 67 72\r\n70 74 75 78 79 78 79\r\n41 45 48 50 52 49 52 49\r\n40 44 46 49 46 46\r\n37 41 38 40 42 45 49\r\n66 70 67 68 71 76\r\n52 56 56 58 61\r\n58 62 62 64 66 65\r\n76 80 83 85 85 88 88\r\n53 57 58 58 62\r\n24 28 30 32 35 35 40\r\n44 48 50 54 56\r\n40 44 46 50 51 54 56 53\r\n62 66 68 71 75 75\r\n56 60 63 67 70 73 75 79\r\n14 18 22 25 27 33\r\n71 75 80 83 86 88 91 92\r\n26 30 31 37 34\r\n54 58 65 66 68 71 73 73\r\n24 28 29 36 37 38 39 43\r\n78 82 87 89 95\r\n82 87 88 91 94 95\r\n43 49 51 54 55 53\r\n20 27 28 31 34 36 38 38\r\n48 55 58 61 65\r\n32 37 40 43 45 52\r\n8 13 12 14 17\r\n6 13 15 12 14 17 19 17\r\n59 64 62 63 65 67 67\r\n20 25 22 23 26 29 32 36\r\n63 68 66 69 72 75 77 82\r\n83 88 90 92 94 94 95 97\r\n73 80 80 83 86 84\r\n82 88 90 91 91 94 94\r\n36 41 41 42 44 47 51\r\n64 69 69 72 73 80\r\n62 67 68 70 74 77 78\r\n57 62 64 66 68 69 73 71\r\n68 74 77 79 83 84 85 85\r\n34 41 45 47 48 52\r\n9 16 19 20 22 26 27 34\r\n67 72 73 80 82\r\n41 46 47 53 51\r\n53 59 64 67 67\r\n59 64 65 68 69 71 78 82\r\n50 57 59 66 71\r\n23 20 18 16 14 11 9 11\r\n36 33 31 30 28 26 24 24\r\n93 92 90 89 87 84 80\r\n46 44 41 40 39 37 35 30\r\n66 65 64 63 66 63\r\n88 85 84 82 84 87\r\n78 75 74 76 75 75\r\n58 56 54 51 53 49\r\n76 73 70 67 64 66 60\r\n50 47 46 46 45 42 39\r\n69 68 68 66 64 61 63\r\n85 82 81 81 81\r\n44 41 39 37 37 34 31 27\r\n39 37 35 34 34 31 28 21\r\n29 27 23 20 17\r\n20 18 15 11 12\r\n68 66 62 59 58 55 55\r\n75 74 71 67 66 62\r\n85 82 80 76 69\r\n57 56 51 50 49\r\n61 59 58 52 55\r\n57 54 49 47 44 44\r\n20 17 14 9 6 2\r\n28 26 20 18 17 14 8\r\n75 76 75 73 72 71\r\n14 15 12 11 14\r\n89 90 87 84 81 80 78 78\r\n54 57 54 51 47\r\n62 65 62 60 57 54 53 48\r\n95 97 94 97 94\r\n7 10 8 10 11\r\n18 19 18 21 21\r\n21 24 23 20 22 19 17 13\r\n67 70 69 71 64\r\n68 69 69 67 65 62 59 58\r\n36 38 38 37 38\r\n80 81 80 77 77 75 75\r\n95 97 95 93 92 92 88\r\n67 69 69 66 59\r\n70 72 71 69 66 62 59\r\n34 37 33 30 29 30\r\n65 68 66 62 61 60 59 59\r\n54 56 55 52 48 47 44 40\r\n66 69 67 65 61 58 52\r\n86 87 81 80 78 75\r\n80 82 77 76 79\r\n56 58 57 56 53 52 46 46\r\n33 34 28 26 24 23 20 16\r\n28 30 27 24 23 18 16 9\r\n67 67 64 63 62 59 58\r\n21 21 18 16 13 14\r\n10 10 8 5 5\r\n14 14 13 12 9 6 5 1\r\n17 17 15 14 12 9 6 1\r\n46 46 44 43 40 41 40\r\n42 42 41 42 45\r\n9 9 6 7 7\r\n36 36 35 37 36 35 31\r\n94 94 93 95 90\r\n79 79 77 77 74\r\n87 87 87 85 84 86\r\n54 54 51 50 49 46 46 46\r\n36 36 33 31 31 30 26\r\n15 15 15 13 10 4\r\n49 49 46 42 40 37\r\n14 14 10 7 9\r\n27 27 26 22 19 18 18\r\n97 97 94 90 86\r\n49 49 48 46 44 41 37 32\r\n37 37 36 34 29 28 26 24\r\n15 15 8 5 8\r\n87 87 81 78 78\r\n15 15 8 7 3\r\n69 69 68 62 56\r\n88 84 83 82 80 78\r\n51 47 46 43 45\r\n81 77 76 74 73 71 71\r\n74 70 68 67 63\r\n20 16 15 13 12 9 8 1\r\n81 77 76 77 75 74\r\n8 4 3 4 6\r\n45 41 40 38 35 37 34 34\r\n90 86 84 81 83 80 76\r\n94 90 89 90 88 83\r\n44 40 37 36 36 35 32\r\n27 23 23 21 20 23\r\n37 33 33 30 29 26 26\r\n29 25 23 23 21 18 17 13\r\n85 81 79 76 75 75 69\r\n18 14 10 7 5\r\n43 39 38 37 36 33 29 31\r\n33 29 25 22 22\r\n30 26 25 21 19 15\r\n77 73 69 66 63 62 57\r\n67 63 61 60 59 54 53 52\r\n61 57 52 49 51\r\n93 89 83 80 77 74 72 72\r\n32 28 22 21 17\r\n19 15 8 7 2\r\n81 75 73 71 69 67 65\r\n46 40 38 35 32 30 32\r\n57 51 50 47 45 45\r\n30 23 20 17 14 12 9 5\r\n38 32 29 28 23\r\n72 67 70 67 65\r\n14 7 5 4 7 6 7\r\n49 43 42 44 44\r\n14 9 10 9 8 4\r\n46 40 39 40 39 33\r\n73 68 66 66 64 62 59 56\r\n34 27 27 26 27\r\n81 74 72 69 66 66 63 63\r\n82 77 76 76 75 73 69\r\n62 55 54 51 51 49 48 42\r\n60 54 50 47 44 41\r\n65 59 55 52 51 52\r\n31 24 22 18 18\r\n24 18 14 11 9 5\r\n25 20 16 13 7\r\n19 13 8 5 3\r\n83 78 77 72 74\r\n97 90 85 83 83\r\n87 81 79 72 68\r\n34 29 27 25 20 17 11\r\n9 12 14 17 19 21 19\r\n9 10 11 14 16 19 21 21\r\n26 27 28 31 33 37\r\n70 71 72 73 75 78 81 87\r\n2 3 4 5 3 5 6\r\n18 19 16 19 18\r\n8 10 12 11 13 14 14\r\n57 59 56 58 61 64 65 69\r\n72 75 78 75 82\r\n88 90 90 91 94\r\n29 30 30 31 34 36 39 38\r\n43 46 49 49 51 52 52\r\n28 29 30 30 34\r\n28 31 32 33 33 35 41\r\n21 23 26 29 33 36 38\r\n11 13 15 19 21 20\r\n47 48 50 51 55 55\r\n62 63 67 69 72 76\r\n21 22 23 26 29 33 35 42\r\n22 24 26 31 34 37 38\r\n81 84 91 94 93\r\n57 59 61 68 71 72 74 74\r\n36 39 41 47 51\r\n69 71 74 76 78 84 89\r\n56 54 57 59 61 62 63 64\r\n31 29 31 32 31\r\n67 64 66 67 68 69 72 72\r\n52 50 51 52 53 57\r\n6 4 7 10 12 15 17 22\r\n71 69 70 71 72 70 73 74\r\n29 28 29 27 25\r\n35 34 37 38 35 38 40 40\r\n59 58 61 58 59 61 64 68\r\n73 71 74 77 74 75 77 82\r\n50 48 50 50 53\r\n78 77 78 81 83 83 86 85\r\n31 29 29 30 31 34 36 36\r\n53 51 52 53 56 56 60\r\n38 36 38 38 39 45\r\n71 70 72 73 77 78\r\n82 80 81 85 87 89 86\r\n8 5 9 11 14 14\r\n82 81 83 87 91\r\n73 71 74 78 81 82 87\r\n27 26 31 34 37\r\n72 70 72 74 80 77\r\n45 44 47 52 54 54\r\n37 35 36 37 39 46 48 52\r\n80 78 80 81 87 90 92 97\r\n48 48 49 51 52 54\r\n87 87 88 90 91 92 91\r\n67 67 70 73 75 75\r\n57 57 58 60 63 66 70\r\n54 54 55 56 59 61 66\r\n95 95 97 96 97\r\n81 81 82 85 82 85 83\r\n94 94 93 96 99 99\r\n75 75 77 75 79\r\n89 89 86 89 92 98\r\n43 43 43 45 48\r\n84 84 85 88 88 90 87\r\n3 3 3 6 8 11 11\r\n6 6 6 7 10 12 16\r\n71 71 71 74 80\r\n78 78 82 85 87 88\r\n5 5 6 10 8\r\n78 78 80 84 87 89 91 91\r\n27 27 31 32 33 34 38\r\n55 55 59 61 68\r\n14 14 21 24 25 27 28 31\r\n7 7 9 15 18 17\r\n60 60 67 68 70 70\r\n37 37 44 46 47 51\r\n52 52 55 60 65\r\n63 67 68 70 73 74 76 79\r\n16 20 23 24 23\r\n14 18 21 22 25 27 27\r\n34 38 39 42 46\r\n8 12 14 17 23\r\n32 36 39 42 39 42\r\n74 78 77 78 79 80 81 79\r\n42 46 47 45 47 49 49\r\n42 46 49 51 53 51 55\r\n11 15 17 15 18 23\r\n1 5 7 8 11 12 12 14\r\n72 76 78 78 79 82 84 82\r\n74 78 79 80 83 84 84 84\r\n48 52 52 54 55 57 61\r\n77 81 84 84 90\r\n17 21 24 28 29 31\r\n36 40 44 46 48 51 53 52\r\n75 79 80 82 85 89 92 92\r\n24 28 29 32 36 39 41 45\r\n79 83 85 89 95\r\n48 52 59 62 64 67 69 72\r\n74 78 79 82 87 89 88\r\n59 63 70 73 73\r\n76 80 82 83 88 90 91 95\r\n75 79 80 82 88 94\r\n41 47 50 53 56 58 60 63\r\n1 6 8 10 11 13 16 13\r\n54 60 61 62 64 66 67 67\r\n79 85 88 91 92 95 99\r\n64 70 71 72 78\r\n87 94 91 94 96 98\r\n90 96 94 95 96 98 97\r\n6 13 14 16 13 14 14\r\n3 9 10 11 9 11 13 17\r\n41 48 46 49 51 56\r\n42 48 48 50 51 53 56 58\r\n58 64 67 67 70 73 72\r\n60 67 69 70 70 72 74 74\r\n78 85 87 89 89 91 93 97\r\n36 42 42 45 52\r\n9 14 15 18 22 25 26\r\n44 49 51 53 57 60 59\r\n7 12 14 18 21 22 22\r\n71 77 78 79 82 85 89 93\r\n57 64 65 69 75\r\n47 54 56 61 62\r\n32 38 40 45 44\r\n3 8 15 18 21 21\r\n62 69 70 77 79 83\r\n44 50 51 52 59 65\r\n34 32 31 30 29 27 30\r\n91 89 86 84 81 81\r\n74 72 71 68 64\r\n15 12 11 9 8 3\r\n29 28 27 25 26 25 22 20\r\n38 35 36 34 35\r\n60 59 56 55 54 52 53 53\r\n64 63 66 65 64 63 59\r\n98 97 96 94 96 94 92 87\r\n49 46 45 45 44 43\r\n92 89 88 88 89\r\n25 23 22 19 19 19\r\n67 64 64 61 58 56 52\r\n25 23 23 22 15\r\n88 86 82 79 76 73 71 70\r\n80 78 74 73 75\r\n70 69 67 64 60 57 57\r\n48 46 42 41 38 37 34 30\r\n82 80 77 73 70 67 65 58\r\n26 25 24 17 15\r\n50 48 45 38 36 39\r\n48 46 43 41 36 36\r\n67 64 57 54 50\r\n72 70 65 64 61 56\r\n90 91 88 86 84 83 82\r\n30 32 31 29 26 28\r\n34 37 35 33 31 31\r\n69 70 69 66 64 62 59 55\r\n48 49 46 45 40\r\n34 35 33 31 33 30 29 27\r\n49 51 48 50 52\r\n26 27 30 27 27\r\n31 34 31 30 28 30 26\r\n22 23 25 23 21 14\r\n90 91 89 87 87 86\r\n56 58 56 55 55 54 55\r\n24 26 25 25 23 21 18 18\r\n33 34 33 33 32 31 27\r\n27 28 26 24 23 22 22 16\r\n79 80 77 75 71 70 69\r\n33 35 34 33 30 28 24 27\r\n75 78 74 73 71 70 70\r\n55 57 54 52 48 46 43 39\r\n85 87 83 82 79 76 74 67\r\n93 94 87 84 81\r\n24 27 20 18 20\r\n24 26 25 24 23 21 14 14\r\n75 77 70 68 66 62\r\n23 24 23 21 16 13 11 4\r\n41 41 38 36 34\r\n27 27 24 22 20 22\r\n40 40 37 35 35\r\n74 74 72 70 66\r\n14 14 13 10 4\r\n98 98 96 93 91 89 91 89\r\n83 83 85 83 84\r\n19 19 20 19 18 18\r\n33 33 30 33 29\r\n41 41 39 37 36 34 37 30\r\n23 23 23 20 17\r\n42 42 42 40 42\r\n71 71 70 68 66 66 66\r\n70 70 69 66 66 64 60\r\n38 38 37 34 34 31 24\r\n47 47 44 40 37\r\n51 51 49 45 47\r\n67 67 63 61 59 57 57\r\n68 68 64 62 58\r\n62 62 58 55 54 52 47\r\n15 15 13 12 6 5 4 3\r\n49 49 43 42 40 38 39\r\n89 89 88 82 79 79\r\n82 82 77 74 73 70 66\r\n44 44 41 40 38 36 30 25\r\n43 39 36 34 33\r\n47 43 42 39 37 34 33 34\r\n57 53 50 48 45 44 44\r\n58 54 51 50 48 44\r\n31 27 24 22 20 18 11\r\n30 26 27 26 23\r\n14 10 12 9 8 11\r\n59 55 58 57 55 52 49 49\r\n77 73 72 71 72 68\r\n72 68 69 68 61\r\n81 77 77 75 72\r\n99 95 92 89 86 83 83 85\r\n96 92 89 89 87 87\r\n88 84 82 79 79 78 74\r\n30 26 26 24 21 14\r\n18 14 10 7 4\r\n39 35 32 30 26 25 26\r\n67 63 59 57 55 55\r\n59 55 51 48 44\r\n43 39 35 33 28\r\n33 29 28 21 20 17 16\r\n49 45 44 42 35 32 30 33\r\n33 29 24 22 22\r\n76 72 66 64 60\r\n51 47 46 45 44 38 33\r\n27 22 19 18 16 15\r\n49 43 41 39 38 36 34 37\r\n63 57 54 51 48 46 43 43\r\n93 87 85 83 81 78 75 71\r\n42 37 35 34 31 24\r\n52 45 42 39 40 39 37\r\n85 78 77 74 73 74 75\r\n32 27 28 26 23 23\r\n73 67 68 65 61\r\n28 23 22 19 20 18 17 10\r\n42 35 33 31 31 29 27 25\r\n57 52 51 51 50 51\r\n64 59 59 56 55 55\r\n27 20 20 19 15\r\n78 73 71 71 68 61\r\n75 69 65 63 61 58 55\r\n39 32 28 26 28\r\n35 30 26 25 25\r\n53 47 43 42 39 37 35 31\r\n70 64 62 58 52\r\n38 32 27 26 23 20\r\n57 50 48 43 46\r\n94 88 86 79 79\r\n95 89 88 82 78\r\n94 87 80 78 73\r\n17 20 22 23 22\r\n67 69 70 73 73\r\n52 53 56 59 62 66\r\n18 20 21 22 25 28 30 35\r\n7 8 11 9 12 14\r\n73 75 74 75 78 79 77\r\n71 73 75 73 76 78 81 81\r\n8 11 12 9 12 13 15 19\r\n15 18 21 18 21 28\r\n34 36 36 39 41\r\n21 22 23 23 24 26 25\r\n45 46 48 49 52 52 52\r\n27 30 31 31 33 35 36 40\r\n80 83 85 87 88 90 90 95\r\n40 41 43 45 49 50 52\r\n74 77 80 81 84 88 90 89\r\n16 17 20 21 22 26 29 29\r\n4 5 6 10 13 17\r\n11 12 16 19 20 25\r\n46 48 49 50 57 59 62\r\n58 59 64 66 65\r\n61 64 65 66 67 73 73\r\n46 49 52 54 60 63 67\r\n40 42 47 49 55\r\n58 57 60 61 62 64 65 66\r\n41 39 42 45 42\r\n84 83 86 89 92 94 94\r\n80 78 81 82 85 87 91\r\n21 20 23 26 33\r\n15 14 17 16 18\r\n86 83 80 82 79\r\n38 37 40 39 39\r\n51 50 47 48 51 55\r\n53 51 53 56 58 61 59 64\r\n87 84 87 87 90 91\r\n97 96 96 97 95\r\n80 79 82 84 84 85 85\r\n19 17 19 22 25 28 28 32\r\n10 7 7 10 17\r\n3 2 3 7 9 10\r\n15 13 15 18 20 22 26 25\r\n85 84 85 87 91 94 95 95\r\n81 80 82 86 88 89 93\r\n68 67 71 74 80\r\n29 28 30 33 35 41 42\r\n13 12 18 19 17\r\n68 65 67 69 76 79 82 82\r\n66 63 64 67 70 75 79\r\n85 83 85 92 94 99\r\n15 15 17 18 20 22 24\r\n7 7 10 13 16 15\r\n26 26 29 32 35 35\r\n42 42 43 46 50\r\n44 44 46 48 50 51 54 59\r\n33 33 34 36 37 38 37 39\r\n38 38 37 40 42 39\r\n78 78 75 77 77\r\n28 28 25 26 28 32\r\n42 42 43 40 41 44 46 52\r\n70 70 72 75 76 76 77\r\n36 36 38 38 41 38\r\n4 4 5 8 9 9 9\r\n69 69 69 71 75\r\n7 7 7 8 9 14\r\n84 84 88 89 90\r\n43 43 45 46 50 48\r\n87 87 89 93 96 99 99\r\n62 62 65 69 71 75\r\n77 77 78 81 85 92\r\n62 62 69 70 73 76\r\n81 81 83 86 88 94 96 95\r\n56 56 57 62 65 66 66\r\n13 13 15 20 23 27\r\n27 27 33 34 40\r\n3 7 8 11 14 15\r\n5 9 11 13 16 15\r\n44 48 50 52 54 57 57\r\n25 29 31 34 35 38 42\r\n29 33 34 35 37 40 41 47\r\n71 75 78 79 81 80 83\r\n15 19 22 19 21 19\r\n21 25 27 25 27 27\r\n18 22 23 22 26\r\n65 69 66 68 73\r\n41 45 45 46 47\r\n67 71 74 74 75 76 77 75\r\n44 48 48 50 51 51\r\n48 52 55 58 58 60 63 67\r\n86 90 90 92 98\r\n27 31 34 38 41\r\n21 25 29 31 28\r\n7 11 13 17 19 19\r\n41 45 48 52 55 57 61\r\n25 29 33 36 39 46\r\n37 41 42 48 50\r\n29 33 40 42 41\r\n27 31 37 39 40 40\r\n70 74 76 79 85 86 90\r\n67 71 74 75 82 89\r\n45 50 51 53 56 57 59 61\r\n2 7 10 12 13 15 16 13\r\n37 43 44 46 46\r\n70 76 77 78 82\r\n48 55 57 60 66\r\n51 56 59 62 65 62 64\r\n81 86 83 86 89 90 91 89\r\n14 20 18 21 21\r\n57 64 67 68 70 73 71 75\r\n9 14 15 13 16 23\r\n59 64 66 68 68 70 72 75\r\n69 74 77 77 80 79\r\n49 54 56 59 62 62 62\r\n51 56 58 58 59 63\r\n26 33 36 38 38 39 40 46\r\n11 17 21 22 25 26 28 30\r\n48 53 55 58 61 65 67 66\r\n29 35 39 40 40\r\n58 64 66 70 72 73 77\r\n17 22 26 29 36\r\n50 56 59 60 63 68 71 72\r\n16 23 29 32 34 37 35\r\n1 8 14 17 19 19\r\n81 87 88 95 99\r\n67 73 74 75 80 81 82 89\r\n31 29 27 26 23 20 19 21\r\n62 60 58 56 55 53 53\r\n89 87 85 83 79\r\n44 42 39 36 33 32 26\r\n10 8 5 3 6 4 2\r\n56 54 55 54 53 50 49 51\r\n60 57 55 58 57 57\r\n32 31 29 27 28 27 25 21\r\n57 56 53 50 48 49 46 40\r\n29 27 25 25 24\r\n19 17 16 16 19\r\n64 62 60 60 58 56 56\r\n73 70 68 68 65 64 60\r\n81 78 78 77 75 69\r\n68 67 66 62 59 58\r\n39 36 34 30 31\r\n28 26 24 21 18 17 13 13\r\n26 23 21 20 19 18 14 10\r\n40 39 38 37 33 31 26\r\n36 33 31 24 23\r\n91 88 87 84 83 78 79\r\n27 25 24 21 20 13 11 11\r\n96 93 92 87 86 82\r\n79 77 75 70 68 67 61\r\n11 14 12 10 8\r\n11 13 11 8 6 5 8\r\n82 85 82 81 81\r\n70 73 71 69 65\r\n76 77 76 73 68\r\n29 30 28 26 29 28\r\n94 97 98 95 96\r\n46 48 45 42 40 43 40 40\r\n77 78 80 78 76 72\r\n21 22 19 16 19 12\r\n96 97 94 91 91 90 87 86\r\n21 24 22 22 25\r\n97 98 95 95 93 92 92\r\n93 95 92 90 88 86 86 82\r\n21 22 22 19 14\r\n32 33 30 26 24\r\n56 57 53 51 50 47 49\r\n42 45 42 39 35 34 34\r\n49 52 50 46 42\r\n37 39 35 33 30 24\r\n85 87 81 78 75\r\n29 32 30 29 23 24\r\n66 68 65 64 61 55 55\r\n87 89 87 81 78 74\r\n42 45 40 37 35 30\r\n68 68 67 64 62 60\r\n21 21 18 15 13 10 13\r\n45 45 44 41 39 37 37\r\n94 94 92 91 88 84\r\n60 60 58 57 54 52 45\r\n31 31 33 31 28 26 25\r\n20 20 18 20 23\r\n36 36 37 35 35\r\n35 35 36 35 34 33 30 26\r\n68 68 65 66 64 63 56\r\n53 53 51 49 48 48 47\r\n52 52 52 50 47 50\r\n11 11 8 8 6 5 5\r\n35 35 35 32 29 26 22\r\n12 12 12 10 9 8 1\r\n35 35 31 28 27 24\r\n69 69 65 63 62 59 60\r\n89 89 87 83 83\r\n80 80 78 74 73 70 67 63\r\n56 56 52 50 49 42\r\n52 52 47 45 43\r\n84 84 78 75 72 70 67 70\r\n83 83 77 76 76\r\n92 92 87 86 85 83 80 76\r\n50 50 49 44 42 40 37 31\r\n56 52 51 49 48 46\r\n24 20 18 16 15 18\r\n86 82 79 76 75 72 70 70\r\n80 76 75 73 69\r\n77 73 72 70 65\r\n85 81 78 79 76\r\n84 80 79 80 79 80\r\n81 77 75 76 76\r\n43 39 41 40 39 35\r\n83 79 77 79 76 69\r\n29 25 23 20 19 16 16 14\r\n34 30 28 26 26 28\r\n41 37 36 35 35 34 31 31\r\n71 67 67 65 63 62 58\r\n50 46 46 43 38\r\n40 36 34 31 29 25 22\r\n77 73 72 68 71\r\n30 26 22 21 18 18\r\n42 38 37 33 29\r\n43 39 38 34 33 31 24\r\n68 64 57 55 53\r\n46 42 40 34 31 28 31\r\n51 47 45 42 40 39 34 34\r\n23 19 16 11 7\r\n24 20 15 14 9\r\n21 14 12 10 9 6 4\r\n97 91 88 86 84 86\r\n53 46 43 41 40 37 37\r\n41 35 32 30 29 28 27 23\r\n70 63 61 59 56 54 52 46\r\n66 60 61 59 56\r\n52 47 46 45 44 42 45 46\r\n57 51 48 47 49 47 44 44\r\n62 57 55 52 54 50\r\n95 90 88 91 90 83\r\n58 52 50 50 47 45\r\n30 25 22 19 16 16 17\r\n36 30 29 29 27 27\r\n76 70 70 68 66 63 59\r\n98 92 90 90 88 83\r\n58 53 51 47 44\r\n27 21 17 14 16\r\n71 65 62 58 55 52 50 50\r\n44 38 36 33 32 31 27 23\r\n63 57 53 52 46\r\n42 36 29 28 27\r\n36 30 28 21 19 16 14 17\r\n49 42 41 34 33 30 27 27\r\n56 50 48 47 40 37 34 30\r\n45 38 36 30 23\r\n92 92 91 88 89 87 89\r\n24 21 18 21 19 17 15 17\r\n9 7 9 10 11 12 12 14\r\n40 43 42 43 45 45\r\n6 13 14 15 17 18 23\r\n86 83 85 82 79 74\r\n87 84 84 82 80 78 72\r\n71 71 78 80 78\r\n65 60 59 60 59 56 52\r\n81 75 76 75 75\r\n57 61 64 62 63 60\r\n64 64 63 63 60 56\r\n19 19 17 16 13 6 3 3\r\n35 41 41 44 45 52\r\n32 36 39 42 44 46 47 48\r\n69 71 69 68 66 63 56 52\r\n78 75 77 80 81 82\r\n62 61 63 66 65 67 71\r\n80 83 83 81 79 79\r\n32 39 41 44 44 47\r\n60 63 66 70 73 71\r\n20 20 21 27 29 31 31\r\n69 62 56 55 54 52 47\r\n72 72 69 66 64 59\r\n87 89 87 85 83 82 79 73\r\n38 39 38 36 32 35\r\n45 45 45 47 48 50 52 57\r\n52 48 46 43 43 42 35\r\n99 94 93 89 87 87\r\n81 82 81 84 85\r\n2 2 3 5 4 8\r\n59 55 52 49 48 50 46\r\n35 33 32 31 30 27\r\n25 26 28 31 32 35 37\r\n41 40 37 36 35 33\r\n64 65 68 69 70\r\n16 18 20 21 24 25 26\r\n48 49 50 51 53\r\n14 13 12 10 7 6 5\r\n52 50 47 44 43 40 37 36\r\n50 51 53 54 55 57\r\n7 10 13 15 17 19 22 25\r\n99 98 97 94 93\r\n55 54 52 50 49 48 47 45\r\n53 56 59 60 63 65 67 68\r\n82 80 77 76 73 70\r\n79 78 75 74 71 70 69 67\r\n89 86 84 81 79\r\n13 14 17 20 22 25 28 31\r\n91 88 86 83 80 78 75 74\r\n99 98 95 93 91 89\r\n56 53 52 49 46\r\n52 53 55 56 57 58 60 62\r\n38 39 42 43 45 46\r\n79 82 83 86 88 90\r\n74 75 78 81 83 84 86 87\r\n92 90 87 85 82 81 78\r\n55 52 50 48 45 43\r\n79 82 84 87 88\r\n67 65 64 62 59 57\r\n86 88 89 90 92 95\r\n32 31 28 25 22\r\n49 51 52 53 54 56 59\r\n19 20 22 24 27 30\r\n65 62 60 57 54 53 50\r\n43 41 40 39 36 35\r\n15 18 20 21 24\r\n99 96 94 92 89\r\n42 45 46 48 50 52 55 57\r\n97 95 93 90 88\r\n44 45 46 49 50 51 53 54\r\n87 85 82 79 78 75 73 70\r\n92 90 89 87 86 85\r\n32 33 35 37 38 39\r\n47 49 52 54 56 57 59\r\n90 88 85 82 79\r\n78 75 74 72 71 70 69 67\r\n71 69 68 67 64 63\r\n71 70 68 67 65 63\r\n52 54 56 57 58 61\r\n40 37 35 32 29 28 26 25\r\n41 43 44 45 46 47 49\r\n65 64 62 60 57 54\r\n34 31 30 28 26 25\r\n48 45 44 41 39 36 35\r\n56 59 61 63 64 66 69 70\r\n56 53 51 48 47\r\n33 36 39 40 42 43 45 46\r\n56 55 54 52 50 47\r\n58 61 63 65 68 69\r\n75 77 78 79 80\r\n17 18 21 24 26\r\n28 31 34 35 36 39 41 43\r\n58 56 53 52 50 48 46 43\r\n35 32 30 27 25\r\n34 36 37 39 40 43\r\n22 20 17 16 15 12\r\n10 13 15 17 20 22\r\n95 94 93 90 88 86 84\r\n52 49 47 46 45 42 40 37\r\n13 14 17 20 22 24\r\n34 33 32 30 27\r\n15 13 10 9 6 3 2 1\r\n5 7 8 11 13 14\r\n31 29 26 24 22 21 18 17\r\n40 43 45 48 51\r\n25 24 23 21 20 19 17 16\r\n65 68 70 72 73 76\r\n56 58 59 61 64\r\n12 13 14 17 20 21 23\r\n76 74 72 70 67\r\n22 23 26 27 28 30 32\r\n63 60 57 55 54\r\n37 40 43 45 48 49 52\r\n89 91 94 96 97 98 99\r\n70 73 74 77 80 83 85\r\n41 38 36 35 33 30\r\n55 57 59 62 65 66 69 70\r\n32 31 29 27 26 23 20\r\n54 51 49 48 46 45 42\r\n24 21 20 18 17 15 13\r\n74 75 76 78 79\r\n7 10 11 14 16\r\n62 60 57 54 53\r\n32 35 36 39 42 43 44 47\r\n53 50 47 46 44 42 40 39\r\n69 68 65 64 63\r\n70 68 66 63 62\r\n31 32 35 36 38 40 42\r\n23 21 20 19 16 15 13 11\r\n96 94 91 90 89 87\r\n24 23 21 20 18 16 13\r\n62 59 58 55 53\r\n38 39 40 43 45 46 47\r\n51 48 45 44 43 42 40\r\n71 72 74 75 78 80\r\n32 29 28 25 23 20 19 17\r\n71 69 66 63 60\r\n45 43 40 37 36 34 32\r\n22 24 25 26 28\r\n87 89 90 91 93 94 95\r\n39 36 34 31 28 26\r\n86 83 80 78 77 74 72 70\r\n1 3 5 6 7\r\n66 63 61 59 56\r\n20 19 16 14 11 9 6 5\r\n72 70 69 66 64 63 62\r\n61 63 64 66 68\r\n32 31 29 27 25 24 21\r\n74 73 71 68 67 65\r\n29 28 26 23 20 18\r\n20 17 16 14 11\r\n81 80 78 76 75 72\r\n53 55 58 60 62 65 67\r\n20 18 15 13 12 9 7\r\n27 30 33 35 38\r\n38 41 44 47 48 49 52 54\r\n62 65 66 68 70 73 74\r\n8 11 13 15 18 20 21\r\n50 47 44 43 42\r\n84 83 82 80 77 74 72 71\r\n70 67 65 62 59\r\n27 25 23 22 21 20 17 15\r\n3 4 5 6 9\r\n47 50 52 55 56 58 60 63\r\n91 90 88 86 84\r\n8 10 11 13 14\r\n86 87 90 92 94 96 98 99\r\n44 42 40 37 34 31 29\r\n19 18 17 14 13 12\r\n23 25 28 31 34 35 37 40\r\n45 46 49 50 52 53\r\n84 87 90 92 94\r\n1 3 4 6 9\r\n21 19 17 16 14 11\r\n68 66 64 62 61\r\n61 64 65 67 69 72 75 77\r\n67 65 62 61 60\r\n67 66 63 60 58 56 54\r\n83 84 86 88 90\r\n15 17 18 20 21 22 23\r\n61 63 64 65 68 69 70 71\r\n85 86 88 89 91 93 96\r\n92 95 96 97 99\r\n13 16 18 19 20 22 24\r\n84 85 88 91 92 94 97\r\n9 11 13 16 18 20 22 23\r\n65 67 69 70 72 75\r\n67 66 65 64 63 60\r\n79 77 74 73 72 71 70\r\n23 21 20 19 16 15 12\r\n70 68 66 65 62\r\n75 77 79 80 81 82 84 87\r\n88 87 86 84 81 79 77 74\r\n7 10 11 13 14\r\n57 60 61 63 66 69 71 74\r\n58 55 54 51 50 47 44 43\r\n82 81 78 76 73 72 69 67\r\n36 34 33 32 29\r\n80 82 83 86 89 90 92\r\n73 76 78 80 83 85 88\r\n97 94 91 89 88 86\r\n14 17 20 23 26 29 31 32\r\n81 80 78 76 73 71 70 69\r\n53 52 51 50 47 46\r\n41 44 47 50 51\r\n18 15 13 12 9 7 5\r\n31 34 36 37 38\r\n94 91 88 86 84 82 80 79\r\n19 22 25 28 31 34\r\n15 18 20 22 23 25 26\r\n27 24 21 19 16 14\r\n51 49 47 44 41 39\r\n70 68 65 64 61 60\r\n82 81 78 77 76 73 72 71\r\n36 37 39 42 44 45 47\r\n30 32 33 35 37 40 43 46\r\n76 74 71 69 66 65\r\n52 51 50 48 46 43 41\r\n93 92 90 89 86\r\n64 63 61 59 56\r\n30 31 33 36 38\r\n20 17 14 13 11 8 5 4\r\n27 26 24 22 21 18\r\n31 30 29 28 26 25 22\r\n35 38 39 40 42\r\n41 42 45 48 50 53\r\n88 91 92 94 97\r\n66 68 69 72 74 75 76 79\r\n24 26 27 30 31\r\n65 62 60 58 56 53 52\r\n61 63 66 69 71\r\n75 72 71 69 66\r\n39 41 43 46 47 50 51\r\n99 98 96 95 92 89\r\n75 72 71 69 68\r\n98 95 93 92 91 90 87\r\n48 45 44 41 40 37\r\n37 35 34 31 30 29 26\r\n58 59 61 63 66\r\n45 47 48 49 51 54\r\n40 42 45 48 49 52\r\n63 65 68 70 71 72 74\r\n52 50 49 47 46\r\n30 31 33 34 36 39 40\r\n53 50 47 44 43 42 41 39\r\n21 18 17 15 14 12 10 9\r\n57 60 62 63 64 66\r\n36 39 41 44 45 46 47 49\r\n74 77 80 81 84 87 90\r\n83 84 87 88 89 91 92 94\r\n73 71 68 67 66 64 61 60\r\n18 20 23 24 26 28 31\r\n89 87 85 82 81 80 77\r\n95 93 91 88 87 85\r\n48 49 52 55 57 58 60 62";
            for (int i = 1; i <= str.Length - 1; i++)
            {
                if (str[i] == ' ')
                {
                    temp.Add(int.Parse(str.Substring(i - 2, 2)));
                }
                if (str[i] == '\r')
                {
                    temp.Add(int.Parse(str.Substring(i - 2, 2)));
                    int[] temparray = new int[temp.Count];
                    for(int j = 0; j < temp.Count; j++)
                    {
                        temparray[j] = temp[j];
                    }
                    list.Add(temparray);
                    temp = new List<int>();
                    i = i + 2;
                }
            }
            list.Add([48, 49, 52, 55, 57, 58, 60, 62]);
            m_list = list;
        }
        public int star1()
        {
            int Output = 0;
            List<(int[], bool, bool, bool)> Look = new List<(int[], bool, bool, bool)>();
            for (int i = 0; i < m_list.Count; i++)
            {
                bool AllIncreasing = true;
                bool AllDecreasing = true;
                bool LevelsDiffer = true;
                if (m_list[i][0] >= m_list[i][1])
                {
                    AllIncreasing = false;
                }
                if (m_list[i][0] <= m_list[i][1])
                {
                    AllDecreasing = false;
                }
                for (int j = 1; j < m_list[i].Length - 1 && AllIncreasing == true; j++ )
                {
                    if (m_list[i][j] >= m_list[i][j+1])
                    {
                        AllIncreasing = false;
                    }
                }
                for (int j = 1; j < m_list[i].Length - 1 && AllDecreasing == true; j++)
                {
                    if (m_list[i][j] <= m_list[i][j + 1])
                    {
                        AllDecreasing = false;
                    }
                }
                for (int j = 0; j < m_list[i].Length - 1 && LevelsDiffer == true; j++)
                {
                    if (Math.Abs(m_list[i][j] - m_list[i][j + 1]) < 1 || Math.Abs(m_list[i][j] - m_list[i][j + 1]) > 3)
                    {
                        LevelsDiffer = false;
                    }
                }
                Look.Add((m_list[i],AllIncreasing,AllDecreasing,LevelsDiffer));
                if((AllDecreasing == true || AllIncreasing == true ) && LevelsDiffer == true)
                {
                    Output++;
                }
            }
            return Output;
        }
        public int star2()
        {
            int Output = 0;
            List<(int[], bool, bool, bool)> Look = new List<(int[], bool, bool, bool)>();
            for (int i = 0; i < m_list.Count; i++)
            {
                bool AllIncreasing = true;
                bool AllDecreasing = true;
                bool LevelsDiffer = true;
                if (m_list[i][0] >= m_list[i][1])
                {
                    AllIncreasing = false;
                }
                if (m_list[i][0] <= m_list[i][1])
                {
                    AllDecreasing = false;
                }
                for (int j = 1; j < m_list[i].Length - 1 && AllIncreasing == true; j++)
                {
                    if (m_list[i][j] >= m_list[i][j + 1])
                    {
                        AllIncreasing = false;
                    }
                }
                for (int j = 1; j < m_list[i].Length - 1 && AllDecreasing == true; j++)
                {
                    if (m_list[i][j] <= m_list[i][j + 1])
                    {
                        AllDecreasing = false;
                    }
                }
                for (int j = 0; j < m_list[i].Length - 1 && LevelsDiffer == true; j++)
                {
                    if (Math.Abs(m_list[i][j] - m_list[i][j + 1]) < 1 || Math.Abs(m_list[i][j] - m_list[i][j + 1]) > 3)
                    {
                        LevelsDiffer = false;
                    }
                }
                Look.Add((m_list[i], AllIncreasing, AllDecreasing, LevelsDiffer));
                if ((AllDecreasing == true || AllIncreasing == true) && LevelsDiffer == true)
                {
                    Output++;
                }
                else
                {
                    List<int[]> combinations = new List<int[]>();
                    for (int j = 0; j < m_list[i].Length; j++)
                    {
                        int[] temp = new int[m_list[i].Length - 1];
                        int aux = 0;
                        for (int k = 0; k < m_list[i].Length; k++)
                        {
                            if (k != j)
                            {
                                temp[aux] = m_list[i][k];
                                aux++;
                            }
                        }
                        combinations.Add(temp);
                    }
                    bool Found = false;
                    for (int j = 0; j < combinations.Count && Found == false; j++)
                    {
                        AllIncreasing = true;
                        AllDecreasing = true;
                        LevelsDiffer = true;
                        if (combinations[j][0] >= combinations[j][1])
                        {
                            AllIncreasing = false;
                        }
                        if (combinations[j][0] <= combinations[j][1])
                        {
                            AllDecreasing = false;
                        }
                        for (int k = 1; k < combinations[j].Length - 1 && AllIncreasing == true; k++)
                        {
                            if (combinations[j][k] >= combinations[j][k + 1])
                            {
                                AllIncreasing = false;
                            }
                        }
                        for (int k = 1; k < combinations[j].Length - 1 && AllDecreasing == true; k++)
                        {
                            if (combinations[j][k] <= combinations[j][k + 1])
                            {
                                AllDecreasing = false;
                            }
                        }
                        for (int k = 0; k < combinations[j].Length - 1 && LevelsDiffer == true; k++)
                        {
                            if (Math.Abs(combinations[j][k] - combinations[j][k + 1]) < 1 || Math.Abs(combinations[j][k] - combinations[j][k + 1]) > 3)
                            {
                                LevelsDiffer = false;
                            }
                        }
                        Look.Add((combinations[j], AllIncreasing, AllDecreasing, LevelsDiffer));
                        if ((AllDecreasing == true || AllIncreasing == true) && LevelsDiffer == true)
                        {
                            Output++;
                            Found = true;
                        }
                    }
                }
            }
            return Output;
        }
    }
}
