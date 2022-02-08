class Result
{
    public static long repeatedString(string s, long n)
    {
        int smallCounter = 0;
        if (n < s.Length){
            for (int i = 0; i < n; i++){
                if (s[i].Equals('a')){
                smallCounter++;
                }
            }
            return smallCounter;
        }
        
        int counter = 0;
        for (int i = 0; i < s.Length; i++){
            if (s[i].Equals('a')){
                counter++;
            }
        }
        if (n % s.Length == 0){
            return counter * (n / s.Length);
        }
        else{
            return counter * (n / s.Length) + repeatedString(s, n % s.Length);
        }
    }
}
