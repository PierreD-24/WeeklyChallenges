using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool b in vals)
            {
                if (b == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
                        
            int sumOfOdds = 0;
                
            foreach (int num in numbers)
            {
                if (num%2!=0)
                {
                    sumOfOdds += num;
                }
            }
            return sumOfOdds%2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            
            foreach (char c in password)
            {
                if (char.IsUpper(c)) 
                { 
                    hasUpper = true;
                }
                else if (char.IsLower(c)) 
                { 
                    hasLower = true;
                }
                else if (char.IsNumber(c))
                {
                    hasNumber = true;
                }
            }
            if (hasUpper && hasLower && hasNumber) 
            { 
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
               return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            
            for (int i = 1; i < 100; i +=2)
            {
                odds.Add(i);
            }
            
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
