// See https://aka.ms/new-console-template for more information

RubiksCube cube = RubiksCube.Solved();

RubiksCube whatWeWant = RubiksCube.Solved();
whatWeWant.FaceWhite[4] = Color.Red;

/*cube.M2();
cube.E2();
cube.S2();*/

whatWeWant.Solve();

cube.Scramble();

Console.WriteLine($"{cube.FaceWhite[0]} {cube.FaceWhite[1]} {cube.FaceWhite[2]}");
Console.WriteLine($"{cube.FaceWhite[3]} {cube.FaceWhite[4]} {cube.FaceWhite[5]}");
Console.WriteLine($"{cube.FaceWhite[6]} {cube.FaceWhite[7]} {cube.FaceWhite[8]}");
Console.WriteLine();
Console.WriteLine($"{cube.FaceYellow[0]} {cube.FaceYellow[1]} {cube.FaceYellow[2]}");
Console.WriteLine($"{cube.FaceYellow[3]} {cube.FaceYellow[4]} {cube.FaceYellow[5]}");
Console.WriteLine($"{cube.FaceYellow[6]} {cube.FaceYellow[7]} {cube.FaceYellow[8]}");
Console.WriteLine();
Console.WriteLine($"{cube.FaceRed[0]} {cube.FaceRed[1]} {cube.FaceRed[2]}");
Console.WriteLine($"{cube.FaceRed[3]} {cube.FaceRed[4]} {cube.FaceRed[5]}");
Console.WriteLine($"{cube.FaceRed[6]} {cube.FaceRed[7]} {cube.FaceRed[8]}");
Console.WriteLine();
Console.WriteLine($"{cube.FaceOrange[0]} {cube.FaceOrange[1]} {cube.FaceOrange[2]}");
Console.WriteLine($"{cube.FaceOrange[3]} {cube.FaceOrange[4]} {cube.FaceOrange[5]}");
Console.WriteLine($"{cube.FaceOrange[6]} {cube.FaceOrange[7]} {cube.FaceOrange[8]}");
Console.WriteLine();
Console.WriteLine($"{cube.FaceBlue[0]} {cube.FaceBlue[1]} {cube.FaceBlue[2]}");
Console.WriteLine($"{cube.FaceBlue[3]} {cube.FaceBlue[4]} {cube.FaceBlue[5]}");
Console.WriteLine($"{cube.FaceBlue[6]} {cube.FaceBlue[7]} {cube.FaceBlue[8]}");
Console.WriteLine();
Console.WriteLine($"{cube.FaceGreen[0]} {cube.FaceGreen[1]} {cube.FaceGreen[2]}");
Console.WriteLine($"{cube.FaceGreen[3]} {cube.FaceGreen[4]} {cube.FaceGreen[5]}");
Console.WriteLine($"{cube.FaceGreen[6]} {cube.FaceGreen[7]} {cube.FaceGreen[8]}");