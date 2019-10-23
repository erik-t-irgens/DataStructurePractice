public void URLify(char[] chararr, int length)
{
    for (int i = length - 1, j = chararr.Length - 1; i > chararr.Length; i--)
    {
        if (chararr[i] != ' ')
        {
            // j-- uses 10 first, THEN redefines j as 9. --j would redefine first, then use the value.
            chararr[j--] = chararr[i];
        }
        else
        {
            chararr[j--] = '0';
            chararr[j--] = '2';
            chararr[j--] = '%';
        }
    }
}