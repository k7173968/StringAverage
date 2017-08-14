using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Stringaverage
{
        class Kata
    {
        public static string AverageString(string str)
    {
    if (str != "")
    {
	 char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
	 //string text = "one two three four";
	 string[] words = str.Split(delimiterChars);
	 double count = 0;
	 double f =0;
	 string num = "";
	 foreach(string s in words)
	 {
         if (s == "zero")
         {
             count += 0;
         }
		 else if(s=="one")
		 {
			 count+=1;
		 }
		 else if(s=="two")
		 {
			 count+=2;
		 }
		 else if(s=="three")
		 {
			 count+=3;
		 }
		 else if(s=="four")
		 {
			 count+=4;
		 }
		 else if(s=="five")
		 {
			 count+=5;
		 }
		 else if(s=="six")
		 {
			 count+=6;
		 }
		 else if(s=="seven")
		 {
			 count+=7;
		 }
		 else if(s=="eight")
		 {
			 count+=8;
		 }
         else if (s == "nine")
         {
             count += 9;
         }
         else 
         {
             return "n/a";
         }
		 
	 }
		f = Math.Floor(count/words.Length);
		switch((int)f)
		{
            case 0:
                num = "zero";
                break;	
			case 1:
				num="one";
				break;				
			case 2:
				num="two";
				break;
			case 3:
				num="three";
				break;
			case 4:
				num="four";
				break;
			case 5:
				num="five";
				break;
			case 6:
				num="six";
				break;
			case 7:
				num="seven";
				break;
			case 8:
				num="eight";
				break;
			case 9:
				num="nine";
				break;
			default:
                num = "n/a";
				break;
		}
			return num;
	 }
	 else
	 {
         return "n/a";
	 }
}
    }
}



/*
for(int i=0;i<chars.Length;i++)
		{
			//count +=i;
			switch(chars[i])
			{
				case 'one':
				{
					count +=1;
				}
				case 'two':
				{
					count +=2;
				}
				case 'three':
				{
					count +=3;
				}
				case 'four':
				{
					count +=4;
				}
				case 'five':
				{
					count +=5;
				}
				case 'six':
				{
					count +=6;
				}
				case 'seven':
				{
					count +=7;
				}
				case 'eight':
				{
					count +=8;
				}
				case 'nine':
				{
					count +=9;
				}
				default:
				{
					count +=0; // I don't sure
				}
			}
		}*/