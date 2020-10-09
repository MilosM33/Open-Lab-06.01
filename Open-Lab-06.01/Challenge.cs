using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length> i+1)
                {
                    for (int x = 0; x < int.Parse(str[i+1].ToString()); x++)
                    {
                        temp += str[i];
                    }
                }
                i++;
            }
            return temp;
        }
    }
}
