// Найти расстояние между точками в пространстве 2D/3D
bool IsDot(int len1, int len2)
{
    if (len1 != len2)
        return false;
    if (len1 < 2 || len1 > 3)
        return false;
    if (len2 < 2 || len2 > 3)
        return false;
    return true;
}

double distance_dot(int[] dot1, int[] dot2)
{
    int len1 = dot1.Length;
    int len2 = dot2.Length;
    if (!IsDot(len1, len2))
        return -1;
    if (len1 == 2)
    {
        int x = (dot1[0] - dot2[0]);
        int y = (dot1[1] - dot2[1]);
        return Math.Sqrt(x * x + y * y);
    }
    else
    {
        int x = (dot1[0] - dot2[0]);
        int y = (dot1[1] - dot2[1]);
        int z = (dot1[2] - dot2[2]);
        return Math.Sqrt(x * x + y * y + z * z);
    }
}

int[] dot1 = { 1, 2, 8 };
int[] dot2 = { 5, 5, 0 };
Console.WriteLine(distance_dot(dot1, dot2));
int[] dot3 = { 1, 1, 1 };
int[] dot4 = { 3, 4, 7 };
Console.WriteLine(distance_dot(dot3, dot4));
int[] dot5 = { 5, 7 };
int[] dot6 = { 1, 4 };
Console.WriteLine(distance_dot(dot5, dot6));
