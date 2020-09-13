using System;
 
public class reversePalindrome
{


    public static bool checkPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if ( text[0] != text[ text.Length - 1 ] )
                return false;
            else
                return checkPalindrome( text.Substring( 1, text.Length-2 ) );
        }   
    }  

 
    public static void Main()
    {

      string mystr, word1 = ""; 
      int i,l;
	  bool tf;
		
      Console.Write(" Input a string : ");
      mystr = Console.ReadLine();
      Console.Write("\n");
      tf=checkPalindrome(mystr);

      l = mystr.Length-1;
      for (i=l;i>=0;i--)
        {
            word1 = word1 + mystr[i];
        
        }

      if (tf==true)
      {
      Console.WriteLine(word1 + "-->" + "True");
      }
      else
      {
       Console.WriteLine(word1 + "-->" + "False");
      }
    }
}