    Console.WriteLine(Palindrome("shelloannakkalkpatatessetatapasdashjksannasmith2sananananaananananas2sadsadsadaskdjksaljdklasdkasl"));
    
    //returns longest palindrome substring
    static string Palindrome(string input) 
    {
        var result = "";
        var temp = "";
        var t = 0;
        for (var index = 2; index < input.Length; index++) 
        {

                while (index+t< input.Length && index - (t + 1)>=0  &&  input[index+t] == input[index - (t+1)]) 
                {
                    temp = input[index - (t + 1)] + temp + input[index + t];
                    t++;
                }
                if (result =="" || temp.Length > result.Length) 
                {
                    result = temp;
                }
                temp = "";
                t = 0;
        }
        return result.Length > 2 ? result: "none";
    }
