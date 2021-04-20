static int[] GetElementsOfOddCountSubArray(int[] a)
{
    Dictionary<int, bool> evenFlags = new Dictionary<int, bool>();
    for (int i = 0; i < a.Length; i++)
    {
        if (!evenFlags.ContainsKey(a[i]))
        {
            evenFlags.Add(a[i], false);
        }
        else
        {
            evenFlags[a[i]] = !evenFlags[a[i]];
        }
    }

    List<int> cutList = new List<int>();
    for (int i = 0; i < a.Length; i++)
    {
        if (!(evenFlags.ContainsKey(a[i]) && evenFlags[a[i]]))
        {
            cutList.Add(a[i]);
        }
    }

    return cutList.ToArray<int>();
}