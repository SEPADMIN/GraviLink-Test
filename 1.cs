static int GetMaxDistance(int[] a)
{
    int x = 0;
    int currentDistance = 1;
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (a[i] == a[i + 1])
        {
            currentDistance++;
        }
        else
        {
            x = Math.max(x, currentDistance);
            currentDistance = 1;
        }
    }
    x = Math.max(x, currentDistance);
    return x;
}