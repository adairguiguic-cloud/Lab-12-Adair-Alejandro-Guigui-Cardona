using System;
class Program
{
    static void Main()
    {
        Console.Write("Nombre: ");
        string n = Console.ReadLine();
        Console.WriteLine("Hola " + n);
        Console.WriteLine();

        Console.WriteLine("=== 1 ===");
        int[,] m1 = new int[4, 4];
        llenar1(m1);

        Console.Write("Fila: ");
        int f = int.Parse(Console.ReadLine());
        Console.Write("Col: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Fila " + f + ": " + sumaF(m1, f));
        Console.WriteLine("Col " + c + ": " + sumaC(m1, c));
        Console.WriteLine();

        Console.WriteLine("=== 2 ===");
        float[,] m2 = new float[3, 5];
        llenar2(m2);
        Console.WriteLine("Mayor: " + mayor(m2));
        Console.WriteLine();

        Console.WriteLine("=== 3 ===");
        int[,] A = new int[3, 2];
        int[,] B = new int[3, 2];
        int[,] R = new int[3, 2];

        llenarA(A);
        llenarB(B);
        multi(A, B, R);

        Console.WriteLine("Resultado:");
        mostrar(R, 3, 2);
        Console.WriteLine();

        Console.WriteLine("=== 4 ===");
        int[,] m4 = new int[5, 5];
        llenar4(m4);

        Console.WriteLine("Diag P: " + d1(m4));
        Console.WriteLine("Diag S: " + d2(m4));
    }

    static void llenar1(int[,] m)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int sumaF(int[,] m, int f)
    {
        int s = 0;
        for (int j = 0; j < 4; j++) s += m[f, j];
        return s;
    }

    static int sumaC(int[,] m, int c)
    {
        int s = 0;
        for (int i = 0; i < 4; i++) s += m[i, c];
        return s;
    }

    static void llenar2(float[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float mayor(float[,] m)
    {
        float x = m[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (m[i, j] > x) x = m[i, j];
            }
        }
        return x;
    }

    static void llenarA(int[,] m)
    {
        Console.WriteLine("A:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("A[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void llenarB(int[,] m)
    {
        Console.WriteLine("B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("B[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void multi(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    R[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }

    static void mostrar(int[,] m, int f, int c)
    {
        for (int i = 0; i < f; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void llenar4(int[,] m)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("[" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int d1(int[,] m)
    {
        int s = 0;
        for (int i = 0; i < 5; i++) s += m[i, i];
        return s;
    }

    static int d2(int[,] m)
    {
        int s = 0;
        for (int i = 0; i < 5; i++) s += m[4 - i, i];
        return s;
    }
}