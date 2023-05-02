// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// "Введите значение X для координаты точки А X="
// A (3,6,8); B (2,1,-7), -> 15.84   

// A (7,-5, 0); B (1,-1,9) -> 11.53

//Функция.
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//Массив.
string[] str =
{"Введите значение X для координату точки А| X=",
 "Введите значение Z для координату точки А| Z=",
 "Введите значение Y для координату точки А| Y=",
 "Введите значение X для координату точки B| X=",
 "Введите значение Y для координату точки B| Y=",
 "Введите значение Z для координату точки B| Z=",
 "-------------------------------------------------------------------------------------------------------"
 };

System.Console.WriteLine("                 Программа нахождения расстояния между двумя точками А и В, по трем значениям (X,Y,Z)");
System.Console.WriteLine(str[6]);

int[] CoordinateA = new int[3];
CoordinateA[0] = ReadInt(str[0]);
CoordinateA[1] = ReadInt(str[1]);
CoordinateA[2] = ReadInt(str[2]);

int[] CoordinateB = new int[3];
CoordinateB[0] = ReadInt(str[3]);
CoordinateB[1] = ReadInt(str[4]);
CoordinateB[2] = ReadInt(str[5]);

double Dlina = Math.Sqrt(Math.Pow(CoordinateB[0] - CoordinateA[0], 2) + Math.Pow(CoordinateB[1] - CoordinateA[1], 2) + Math.Pow(CoordinateB[2] - CoordinateA[2], 2));

System.Console.WriteLine(str[6]);
Console.WriteLine($"Ответ такой: AB={Math.Round(Dlina, 2)}");
System.Console.WriteLine(str[6]);
