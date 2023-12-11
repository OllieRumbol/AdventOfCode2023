using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023;

public class Day3
{
    public string Part1()
    {
        List<string> lines = File.ReadLines(@"InputFiles\Day3.txt").ToList();

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        int total = 0;

        for (int i = 0; i < lines.Count; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                HashSet<int> numbersFound = new HashSet<int>();

                if (lines[i][j] != '.' && char.IsNumber(lines[i][j]) == false)
                {
                    //Top left
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j - 1));
                        }
                    }
                    catch { }

                    //Top
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j));
                        }
                    }
                    catch { }

                    //TopRight
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j + 1));
                        }
                    }
                    catch { }

                    //left
                    try
                    {
                        if (char.IsNumber(lines[i][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i], j - 1));
                        }
                    }
                    catch { }

                    //Right
                    try
                    {
                        if (char.IsNumber(lines[i][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i], j + 1));
                        }
                    }
                    catch { }

                    //Bottom Left 
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j - 1));
                        }
                    }
                    catch { }

                    //Bottom
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j));
                        }
                    }
                    catch { }

                    //BottomRight
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j + 1));
                        }
                    }
                    catch { }

                    // Add to total
                    foreach(int number  in numbersFound)
                    {
                        total = total + number;
                    }

                }
            }
        }

        return total.ToString();
    }

    public string Part2()
    {
        List<string> lines = File.ReadLines(@"InputFiles\Day3.txt").ToList();

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        int total = 0;

        for (int i = 0; i < lines.Count; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                HashSet<int> numbersFound = new HashSet<int>();

                if (lines[i][j] == '*')
                {
                    //Top left
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j - 1));
                        }
                    }
                    catch { }

                    //Top
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j));
                        }
                    }
                    catch { }

                    //TopRight
                    try
                    {
                        if (char.IsNumber(lines[i - 1][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i - 1], j + 1));
                        }
                    }
                    catch { }

                    //left
                    try
                    {
                        if (char.IsNumber(lines[i][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i], j - 1));
                        }
                    }
                    catch { }

                    //Right
                    try
                    {
                        if (char.IsNumber(lines[i][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i], j + 1));
                        }
                    }
                    catch { }

                    //Bottom Left 
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j - 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j - 1));
                        }
                    }
                    catch { }

                    //Bottom
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j));
                        }
                    }
                    catch { }

                    //BottomRight
                    try
                    {
                        if (char.IsNumber(lines[i + 1][j + 1]))
                        {
                            numbersFound.Add(FindNumberInLine(lines[i + 1], j + 1));
                        }
                    }
                    catch { }

                    if(numbersFound.Count == 2)
                    {
                        int temp = 1;

                        // Add to total
                        foreach (int number in numbersFound)
                        {
                            temp = temp * number;
                        }

                        total = total + temp;
                    }
                }
            }
        }

        return total.ToString();
    }

    private int FindNumberInLine(string line, int index)
    {
        string leftSide = "";
        for (int i = index - 1; i >= 0; i--)
        {
            if (char.IsNumber(line[i]))
            {
                leftSide = $"{line[i]}{leftSide}";
            }
            else
            {
                break;
            }
        }

        string rightSide = "";
        for (int i = index + 1; i < line.Length; i++)
        {
            if (char.IsNumber(line[i]))
            {
                rightSide = rightSide + line[i];
            }
            else
            {
                break;
            }
        }

        return int.Parse($"{leftSide}{line[index]}{rightSide}");
    }
}
