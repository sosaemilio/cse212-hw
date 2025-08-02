public static List<int> CustomIntersection(List<int> set1, List<int> set2)
{
    List<int> result = new List<int>();
    foreach (int item in set1)
    {
        if (set2.Contains(item) && !result.Contains(item))
        {
            result.Add(item);
        }
    }
    return result;
}

public static List<int> CustomUnion(List<int> set1, List<int> set2)
{
    List<int> result = new List<int>();
    foreach (int item in set1)
    {
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }
    foreach (int item in set2)
    {
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }
    return result;
}

