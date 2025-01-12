﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisFunzioni
{
    public struct Matrice
    {
        public string Colonna;
        public int Riga;
        public TextBox Casella;
        public Color ColoreSfondo;
        public BorderStyle TipoBordi;
    }

    public struct MatriceRandom
    {
        public string Colonna;
        public int Riga;
        public TextBox Casella;
        public Color ColoreSfondo;
        public BorderStyle TipoBordi;
    }

    public enum Pezzi
    {
        IBlock, JBlock, LBlock, OBlock, SBlock, TBlock, ZBlock
    }

    internal class Lib
    {

        public static int GeneraPezzo(Matrice[] ele, int[] elePosizioni)
        {
            Random random = new Random();
            int randomNumero = random.Next(6);
            int[] posizioni = { 60, 61, 80, 81, 100, 101, 120, 121 };
            switch (randomNumero)
            {
                case 0:
                    ele[60].Casella.BackColor = Color.LightBlue;
                    ele[60].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[80].Casella.BackColor = Color.LightBlue;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.LightBlue;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.LightBlue;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[0];
                    elePosizioni[1] = posizioni[2];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[6];
                    return (int)Pezzi.IBlock;
                case 1:
                    ele[80].Casella.BackColor = Color.Blue;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[81].Casella.BackColor = Color.Blue;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Blue;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Blue;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    return (int)Pezzi.JBlock;
                case 2:
                    ele[81].Casella.BackColor = Color.Gold;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Gold;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.Gold;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Gold;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[5];
                    elePosizioni[2] = posizioni[6];
                    elePosizioni[3] = posizioni[7];
                    return (int)Pezzi.LBlock;
                case 3:
                    ele[80].Casella.BackColor = Color.Yellow;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[81].Casella.BackColor = Color.Yellow;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Yellow;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Yellow;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[3];
                    elePosizioni[2] = posizioni[4];
                    elePosizioni[3] = posizioni[5];
                    return (int)Pezzi.OBlock;
                case 4:
                    ele[81].Casella.BackColor = Color.LightGreen;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.LightGreen;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.LightGreen;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[120].Casella.BackColor = Color.LightGreen;
                    ele[120].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[6];
                    return (int)Pezzi.SBlock;
                case 5:
                    ele[81].Casella.BackColor = Color.Purple;
                    ele[81].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Purple;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Purple;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Purple;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[3];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    return (int)Pezzi.TBlock;
                case 6:
                    ele[80].Casella.BackColor = Color.Red;
                    ele[80].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[100].Casella.BackColor = Color.Red;
                    ele[100].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[101].Casella.BackColor = Color.Red;
                    ele[101].Casella.BorderStyle = BorderStyle.Fixed3D;
                    ele[121].Casella.BackColor = Color.Red;
                    ele[121].Casella.BorderStyle = BorderStyle.Fixed3D;
                    elePosizioni[0] = posizioni[2];
                    elePosizioni[1] = posizioni[4];
                    elePosizioni[2] = posizioni[5];
                    elePosizioni[3] = posizioni[7];
                    return (int)Pezzi.ZBlock;
            }
            return -1;
        }

        public static void Scendi(Matrice[] ele, int[] elePosizioni, int Pezzo)
        {
            for (int x = 0; x < elePosizioni.Length; x++)
            {
                switch (Pezzo)
                {
                    case 0:
                        ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                        elePosizioni[x] = elePosizioni[x] + 1;
                        ele[elePosizioni[x]].Casella.BackColor = Color.LightBlue;
                        ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    case 1:
                        if (x != 1)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Blue;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;
                    case 2:
                        if (x != 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Gold;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;
                    case 3:
                        if (x != 1 && x != 3)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Yellow;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;
                    case 4:
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.LightGreen;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;
                    case 5:
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Purple;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;
                    case 6:
                        if (x != 2)
                        {
                            ele[elePosizioni[x]].Casella.BackColor = Color.Black;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.None;
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            elePosizioni[x] = elePosizioni[x] + 1;
                            ele[elePosizioni[x]].Casella.BackColor = Color.Red;
                            ele[elePosizioni[x]].Casella.BorderStyle = BorderStyle.Fixed3D;
                        }
                        break;

                }

            }

        }
    }
}
