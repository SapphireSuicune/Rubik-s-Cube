using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksSolver
{
    public class RubiksCube
    {
        public Color[] FaceWhite { get; set; } // Center is White      In the front.
        public Color[] FaceYellow { get; set; } // Center is Yellow     In the back.
        public Color[] FaceRed { get; set; } // Center is Red        On the top.
        public Color[] FaceOrange { get; set; } // Center is Orange     On the bottom.
        public Color[] FaceBlue { get; set; } // Center is Blue       On the left.
        public Color[] FaceGreen { get; set; } // Center is Green      On the right.

        public RubiksCube(Color[] f1, Color[] f2, Color[] f3, Color[] f4, Color[] f5, Color[] f6)
        {
            FaceWhite = f1;
            FaceYellow = f2;
            FaceRed = f3;
            FaceOrange = f4;
            FaceBlue = f5;
            FaceGreen = f6;
        }

        public static RubiksCube Solved()
        {
            Color[] whiteFace = { Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White };
            Color[] yellowFace = { Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow };
            Color[] redFace = { Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red };
            Color[] orangeFace = { Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange, Color.Orange };
            Color[] blueFace = { Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue, Color.Blue };
            Color[] greenFace = { Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Green };

            return new RubiksCube(whiteFace, yellowFace, redFace, orangeFace, blueFace, greenFace);
        }

        public static RubiksCube Checkerboard()
        {
            Color[] whiteFace = { Color.White, Color.Yellow, Color.White, Color.Yellow, Color.White, Color.Yellow, Color.White, Color.Yellow, Color.White };
            Color[] yellowFace = { Color.Yellow, Color.White, Color.Yellow, Color.White, Color.Yellow, Color.White, Color.Yellow, Color.White, Color.Yellow };
            Color[] redFace = { Color.Red, Color.Orange, Color.Red, Color.Orange, Color.Red, Color.Orange, Color.Red, Color.Orange, Color.Red };
            Color[] orangeFace = { Color.Orange, Color.Red, Color.Orange, Color.Red, Color.Orange, Color.Red, Color.Orange, Color.Red, Color.Orange };
            Color[] blueFace = { Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue };
            Color[] greenFace = { Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green, Color.Blue, Color.Green };

            return new RubiksCube(whiteFace, yellowFace, redFace, orangeFace, blueFace, greenFace);
        }

        public void U()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceWhite[0] = green_c[0];
            FaceWhite[1] = green_c[1];
            FaceWhite[2] = green_c[2];

            FaceGreen[0] = yellow_c[0];
            FaceGreen[1] = yellow_c[1];
            FaceGreen[2] = yellow_c[2];

            FaceYellow[0] = blue_c[0];
            FaceYellow[1] = blue_c[1];
            FaceYellow[2] = blue_c[2];

            FaceBlue[0] = white_c[0];
            FaceBlue[1] = white_c[1];
            FaceBlue[2] = white_c[2];

            FaceRed[0] = red_c[6];
            FaceRed[1] = red_c[3];
            FaceRed[2] = red_c[0];
            FaceRed[3] = red_c[7];
            FaceRed[4] = red_c[4]; // yeah i know it's redundant
            FaceRed[5] = red_c[1];
            FaceRed[6] = red_c[8];
            FaceRed[7] = red_c[5];
            FaceRed[8] = red_c[2];
        }

        public void U2()
        {
            U();
            U();
        }

        public void U_Prime()
        {
            U();
            U();
            U();
        }

        public void R()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceWhite[2] = orange_c[2];
            FaceWhite[5] = orange_c[5];
            FaceWhite[8] = orange_c[8];

            FaceOrange[2] = yellow_c[6];
            FaceOrange[5] = yellow_c[3];
            FaceOrange[8] = yellow_c[0];

            FaceYellow[6] = red_c[2];
            FaceYellow[3] = red_c[5];
            FaceYellow[0] = red_c[8];

            FaceRed[2] = white_c[2];
            FaceRed[5] = white_c[5];
            FaceRed[8] = white_c[8];

            FaceGreen[0] = green_c[6];
            FaceGreen[1] = green_c[3];
            FaceGreen[2] = green_c[0];
            FaceGreen[3] = green_c[7];
            FaceGreen[4] = green_c[4]; // yeah i know it's redudant
            FaceGreen[5] = green_c[1];
            FaceGreen[6] = green_c[8];
            FaceGreen[7] = green_c[5];
            FaceGreen[8] = green_c[2];
        }

        public void R2()
        {
            R();
            R();
        }

        public void R_Prime()
        {
            R();
            R();
            R();
        }

        public void F()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceRed[6] = blue_c[8];
            FaceRed[7] = blue_c[5];
            FaceRed[8] = blue_c[2];

            FaceGreen[0] = red_c[6];
            FaceGreen[3] = red_c[7];
            FaceGreen[6] = red_c[8];

            FaceOrange[0] = green_c[6];
            FaceOrange[1] = green_c[3];
            FaceOrange[2] = green_c[0];

            FaceBlue[2] = orange_c[0];
            FaceBlue[5] = orange_c[1];
            FaceBlue[8] = orange_c[2];

            FaceWhite[0] = white_c[6];
            FaceWhite[1] = white_c[3];
            FaceWhite[2] = white_c[0];
            FaceWhite[3] = white_c[7];
            FaceWhite[4] = white_c[4]; // yeah i know it's redudant
            FaceWhite[5] = white_c[1];
            FaceWhite[6] = white_c[8];
            FaceWhite[7] = white_c[5];
            FaceWhite[8] = white_c[2];
        }

        public void F2()
        {
            F();
            F();
        }

        public void F_Prime()
        {
            F();
            F();
            F();
        }

        public void D()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceWhite[6] = blue_c[6];
            FaceWhite[7] = blue_c[7];
            FaceWhite[8] = blue_c[8];

            FaceGreen[6] = white_c[6];
            FaceGreen[7] = white_c[7];
            FaceGreen[8] = white_c[8];

            FaceYellow[6] = green_c[6];
            FaceYellow[7] = green_c[7];
            FaceYellow[8] = green_c[8];

            FaceBlue[6] = yellow_c[6];
            FaceBlue[7] = yellow_c[7];
            FaceBlue[8] = yellow_c[8];

            FaceOrange[0] = orange_c[6];
            FaceOrange[1] = orange_c[3];
            FaceOrange[2] = orange_c[0];
            FaceOrange[3] = orange_c[7];
            FaceOrange[4] = orange_c[4]; // yeah i know it's redudant
            FaceOrange[5] = orange_c[1];
            FaceOrange[6] = orange_c[8];
            FaceOrange[7] = orange_c[5];
            FaceOrange[8] = orange_c[2];
        }

        public void D2()
        {
            D();
            D();
        }
        public void D_Prime()
        {
            D();
            D();
            D();
        }

        public void L()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceWhite[0] = red_c[0];
            FaceWhite[3] = red_c[3];
            FaceWhite[6] = red_c[6];

            FaceOrange[0] = white_c[0];
            FaceOrange[3] = white_c[3];
            FaceOrange[6] = white_c[6];

            FaceYellow[8] = orange_c[0];
            FaceYellow[5] = orange_c[3];
            FaceYellow[2] = orange_c[6];

            FaceRed[0] = yellow_c[8];
            FaceRed[3] = yellow_c[5];
            FaceRed[6] = yellow_c[2];

            FaceBlue[0] = blue_c[6];
            FaceBlue[1] = blue_c[3];
            FaceBlue[2] = blue_c[0];
            FaceBlue[3] = blue_c[7];
            FaceBlue[4] = blue_c[4]; // yeah i know it's redudant
            FaceBlue[5] = blue_c[1];
            FaceBlue[6] = blue_c[8];
            FaceBlue[7] = blue_c[5];
            FaceBlue[8] = blue_c[2];
        }

        public void L2()
        {
            L();
            L();
        }

        public void L_Prime()
        {
            L();
            L();
            L();
        }

        public void B()
        {
            Color[] white_c = (Color[])FaceWhite.Clone();
            Color[] yellow_c = (Color[])FaceYellow.Clone();
            Color[] red_c = (Color[])FaceRed.Clone();
            Color[] orange_c = (Color[])FaceOrange.Clone();
            Color[] blue_c = (Color[])FaceBlue.Clone();
            Color[] green_c = (Color[])FaceGreen.Clone();

            FaceBlue[0] = red_c[2];
            FaceBlue[3] = red_c[1];
            FaceBlue[6] = red_c[0];

            FaceRed[0] = green_c[2];
            FaceRed[1] = green_c[5];
            FaceRed[2] = green_c[8];

            FaceGreen[2] = orange_c[8];
            FaceGreen[5] = orange_c[7];
            FaceGreen[8] = orange_c[6];

            FaceOrange[6] = blue_c[0];
            FaceOrange[7] = blue_c[3];
            FaceOrange[8] = blue_c[6];

            FaceYellow[0] = yellow_c[6];
            FaceYellow[1] = yellow_c[3];
            FaceYellow[2] = yellow_c[0];
            FaceYellow[3] = yellow_c[7];
            FaceYellow[4] = yellow_c[4]; // yeah i know it's redudant
            FaceYellow[5] = yellow_c[1];
            FaceYellow[6] = yellow_c[8];
            FaceYellow[7] = yellow_c[5];
            FaceYellow[8] = yellow_c[2];
        }

        public void B2()
        {
            B();
            B();
        }

        public void B_Prime()
        {
            B();
            B();
            B();
        }



        public void M()
        {
            R();
            L_Prime();
        }

        public void M2()
        {
            M();
            M();
        }

        public void M_Prime()
        {
            M();
            M();
            M();
        }


        public void E()
        {
            U();
            D_Prime();
        }

        public void E2()
        {
            E();
            E();
        }

        public void E_Prime()
        {
            E();
            E();
            E();
        }

        public void S()
        {
            F_Prime();
            B();
        }

        public void S2()
        {
            S();
            S();
        }
        public void S_Prime()
        {
            S();
            S();
            S();
        }

        public void MoveToState(RubiksCube expectedResult)
        {
            if (this.FaceWhite[4] != Color.White || this.FaceYellow[4] != Color.Yellow || this.FaceRed[4] != Color.Red || this.FaceOrange[4] != Color.Orange || this.FaceBlue[4] != Color.Blue || this.FaceGreen[4] != Color.Green)
            {
                throw new InvalidCubeException("Input cube's centers are duplicated or do not match.");
            }

            if (expectedResult.FaceWhite[4] != Color.White || expectedResult.FaceYellow[4] != Color.Yellow || expectedResult.FaceRed[4] != Color.Red || expectedResult.FaceOrange[4] != Color.Orange || expectedResult.FaceBlue[4] != Color.Blue || expectedResult.FaceGreen[4] != Color.Green)
            {
                throw new InvalidCubeException("Result's centers are duplicated or do not match.");
            }
        }

        public void Solve()
        {
            MoveToState(Solved());
        }

        public string[] ScrambleMoves = { "R", "R2", "R'", "U", "U2", "U'", "F", "F2", "F'", "L", "L2", "L'", "D", "D2", "D'", "B", "B2", "B'" };

        public void Scramble()
        {
            Random rand = new();
            int len = rand.Next(8, 20);
            string[] moves = new string[len];
            for(int i = 0; i < len; i++)
            {
                moves[i] = ((char)(i + 33)).ToString();
            }
            for(int i = 0; i < len; i++)
            {
                string move;

                try
                {
                    do
                    {
                        move = ScrambleMoves[rand.Next(ScrambleMoves.Length)];
                        moves[i] = move;
                    }
                    while (moves[i][0] == moves[i - 1][0]);
                }
                
                catch
                {
                    move = ScrambleMoves[rand.Next(ScrambleMoves.Length)];
                }

                moves[i] = move;
            }

            foreach(string move in moves)
            {
                switch (move)
                {
                    case "R":
                        R();
                        break;
                    case "R2":
                        R2();
                        break;
                    case "R'":
                        R_Prime();
                        break;
                    case "U":
                        U();
                        break;
                    case "U2":
                        U2();
                        break;
                    case "U'":
                        U_Prime();
                        break;
                    case "F":
                        F();
                        break;
                    case "F2":
                        F2();
                        break;
                    case "F'":
                        F_Prime();
                        break;
                    case "L":
                        L();
                        break;
                    case "L2":
                        L2();
                        break;
                    case "L'":
                        L_Prime();
                        break;
                    case "D":
                        D();
                        break;
                    case "D2":
                        D2();
                        break;
                    case "D'":
                        D_Prime();
                        break;
                    case "B":
                        B();
                        break;
                    case "B2":
                        B2();
                        break;
                    case "B'":
                        B_Prime();
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", moves));
        }
    }
}