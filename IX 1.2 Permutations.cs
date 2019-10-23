public bool Permutations(string str1, string st2)
{
    if (str1.Length != str2.Length)
    {
        return false;
    }
    Dictionary<char, int> permutation = new Dictionary<char, int>();
    for (int i = 0; i < str1.Length; i++)
    {
        if (permutation.ContainsKey(str1[i]))
        {
            int newaValue = permutation.GetValue(str1[i]) + 1;
            permutation.Add(str1[i], newValue);
        }
        else
        {
            permutation.Add(str1[i], 1);
        }
    }
    for (int i = 0; i < str2.Length; i++)
    {
        if (!permutation.ContainsKey(str2[i]))
        {
            return false;
        }
        else
        {
            int newValue = permutation.GetValue(str2[i]) - 1;
            if (newValue == 0)
            {
                permutation.Remove(str2[i]);
            }
            else
            {
                permutation.Add(str2[i], newValue);
            }
        }
        if (permutation.Count() != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}