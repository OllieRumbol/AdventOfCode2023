using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023;

public class Day1
{
    public string Part1()
    {
        List<string> inputs = File.ReadAllText(@"InputFiles\Day1.txt").Split('\n').ToList();
        int total = 0;

        foreach (string input in inputs)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            foreach (char character in input)
            {
                if(int.TryParse(character.ToString(), out firstNumber))
                {
                    break;
                }
            }

            foreach (char character in input.Reverse())
            {
                if (int.TryParse(character.ToString(), out secondNumber))
                {
                    break;
                }
            }

            total = total + int.Parse($"{firstNumber}{secondNumber}");
        }

        return total.ToString();
    }

    public string Part2()
    {
        List<string> inputs = File.ReadAllText(@"InputFiles\Day1.txt").Split('\n').ToList();
        int total = 0;

        foreach (string input in inputs)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string cleanInput = input.Replace("\r", "");

            for (int i = 0; i < cleanInput.Length; i++)
            {
                char character = cleanInput[i];
                if (int.TryParse(character.ToString(), out firstNumber))
                {
                    break;
                }

                string value = cleanInput.Substring(0, i + 1);
                if (value.Contains("one", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 1;
                    break;
                }
                if (value.Contains("two", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 2;
                    break;
                }
                if (value.Contains("three", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 3;
                    break;
                }
                if (value.Contains("four", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 4;
                    break;
                }
                if (value.Contains("five", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 5;
                    break;
                }
                if (value.Contains("six", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 6;
                    break;
                }
                if (value.Contains("seven", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 7;
                    break;
                }
                if (value.Contains("eight", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 8;
                    break;
                }
                if (value.Contains("nine", StringComparison.InvariantCultureIgnoreCase))
                {
                    firstNumber = 9;
                    break;
                }
            }

            for (int i = cleanInput.Length-1; i >= 0; i--)
            {
                char character = cleanInput[i];

                if (int.TryParse(character.ToString(), out secondNumber))
                {
                    break;
                }
              
                string value = cleanInput.Substring(i, cleanInput.Length - i);
                if (value.Contains("one", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 1;
                    break;
                }
                if (value.Contains("two", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 2;
                    break;
                }
                if (value.Contains("three", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 3;
                    break;
                }
                if (value.Contains("four", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 4;
                    break;
                }
                if (value.Contains("five", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 5;
                    break;
                }
                if (value.Contains("six", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 6;
                    break;
                }
                if (value.Contains("seven", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 7;
                    break;
                }
                if (value.Contains("eight", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 8;
                    break;
                }
                if (value.Contains("nine", StringComparison.InvariantCultureIgnoreCase))
                {
                    secondNumber = 9;
                    break;
                }
            }

            total = total + int.Parse($"{firstNumber}{secondNumber}");
        }

        return total.ToString();
    }
}
