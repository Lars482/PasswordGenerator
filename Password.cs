using System;
using System.Text;

namespace MySecondProject
{
	class Password
	{
		string passwordChar = "njchsjs8w882jsjsn????wjjnsj";

		Random rand = new Random();
        private object randomChar = "";

    
        public string passwordGen(int length)
		{
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                char randomChar = passwordChar[rand.Next(0, passwordChar.Length)];
                sb.Append(randomChar);
              
            }

            
            return sb.ToString();
            


        }
		
    }
}

