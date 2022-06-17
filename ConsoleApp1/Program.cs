
// 48-57 0-9 -> 10 karakter
// 65-90 A-Z -> 26 karakter
// 97-122 a-z -> 26 karakter
// 62*62*62*62*62*62 kombinasyon

void charChecker(ref int letter)
{
    if (letter == 57)
    {
        letter = 64;
    }
    else if (letter == 90)
    {
        letter = 96;
    }
}

void reset (ref int x, int index)
{
    if(index == 61)
    {
        x = 48;       
    }
}
bool tryConnection(string pass)
{
    return true;
}

string cracker()
{
    char[] chars = new char[6];
    string pass = string.Empty;
    int[] asc = new int[6];
    asc[0] = 48;
    asc[1] = 48;
    asc[2] = 48;
    asc[3] = 48;
    asc[4] = 48;
    asc[5] = 48;
 
    for (int bir = 0; bir < 62; bir++)
    {
        chars[0] = (char)asc[0];
        for (int iki = 0; iki < 62; iki++)
        {
            chars[1] = (char)asc[1];
            for (int uc = 0; uc < 62; uc++)
            {
                chars[2] = (char)asc[2];
                for (int dort = 0; dort < 62; dort++)
                {
                    chars[3] = (char)asc[3];
                    for (int bes = 0; bes < 62; bes++)
                    {
                        chars[4] = (char)asc[4];
                        for (int alti = 0; alti < 62; alti++)
                        {                                                                                                                                     
                            chars[5] = (char)asc[5];
                            pass = new String(chars);
                            Console.WriteLine(pass);
                            //if (tryConnection(pass) == true)
                            //{
                            //    return pass;
                            //}
                            charChecker(ref asc[5]);
                            asc[5]++;
                            reset(ref asc[5], alti);
                        }
                        charChecker(ref asc[4]);
                        asc[4]++;
                        reset(ref asc[4], bes);
                    }
                    charChecker(ref asc[3]);
                    asc[3]++;
                    reset(ref asc[3], dort);
                }
                charChecker(ref asc[2]);
                asc[2]++;
                reset(ref asc[2], uc);
            }
            charChecker(ref asc[1]);
            asc[1]++;
            reset(ref asc[1], iki);
        }
        charChecker(ref asc[0]);
        asc[0]++;
        reset(ref asc[0], bir);
    }
    return "failed";
}

cracker();
Console.ReadLine();
