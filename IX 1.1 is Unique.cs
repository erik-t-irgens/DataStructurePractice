// Given a string, return whether the string is complete made of unique characters (true) or not (false)

// tool
// grant
// component

// Brute force, no other data structure
public bool IsUnique(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i + 1; j < str.Length; j++)
        {
            if (str[j] == str[i])
            {
                return false;
            }
        }
    }
    return true;
}

// Data structures

public bool isUniqueDictionary(string str)
{
    Dictionary<char, bool> stringDictionary = new Dictionary<char, bool>();
    for (int i = 0; i < str.Length; i++)
    {
        if (stringDictionary.ContainsKey(str[i]))
        {
            return false;
        }
        stringDictionary.Add(str[i], true);
    }
    return true;
}