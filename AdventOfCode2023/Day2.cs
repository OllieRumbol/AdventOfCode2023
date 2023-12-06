using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023;

public class Game
{
    public int Id { get; set; }

    public int HighestRedCubeCount;

    public int HighestBlueCubeCount;

    public int HighestGreenCubeCount;

    public string Print()
    {
        return $"Game {Id}: {HighestRedCubeCount} reds were used, {HighestBlueCubeCount} blues were used, {HighestGreenCubeCount} greens were used";
    }

    public Game(string game)
    {
        Id = int.Parse(game.Split(':').First().Split(" ").Last().ToString());

        List<string> rounds = game.Split(':')[1].Split(';').ToList();
        foreach (string round in rounds)
        {
            foreach (string cubes in round.Split(','))
            {
                int number = int.Parse(cubes.Trim().Split(' ').First());

                if (cubes.Contains("red", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (number > HighestRedCubeCount)
                    {
                        HighestRedCubeCount = number;
                    }
                }
                if (cubes.Contains("green", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (number > HighestGreenCubeCount)
                    {
                        HighestGreenCubeCount = number;
                    }
                }
                if (cubes.Contains("blue", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (number > HighestBlueCubeCount)
                    {
                        HighestBlueCubeCount = number;
                    }
                }
            }
        }
    }
}

public class Day2
{
    public string Part1()
    {
        List<string> inputs = File.ReadAllText(@"InputFiles\Day2.txt").Split('\n').ToList();

        List<Game> results = new List<Game>();

        foreach (string game in inputs)
        {
            results.Add(new Game(game));
        }

        List<Game> validGames = new List<Game>();

        int maxNumberOfRedCubes = 12;
        int maxNumberOfGreenCubes = 13;
        int maxNumberOfBlueCubes = 14;


        foreach (Game game in results)
        {
            if (game.HighestRedCubeCount <= maxNumberOfRedCubes && game.HighestGreenCubeCount <= maxNumberOfGreenCubes && game.HighestBlueCubeCount <= maxNumberOfBlueCubes)
            {
                validGames.Add(game);
            }
        }

        return validGames.Sum(g => g.Id).ToString();
    }

    public string Part2()
    {
        int total = 0;
        List<string> inputs = File.ReadAllText(@"InputFiles\Day2.txt").Split('\n').ToList();

        List<Game> results = new List<Game>();

        foreach (string game in inputs)
        {
            results.Add(new Game(game));
        }



        foreach (Game game in results)
        {
            total = total + (game.HighestRedCubeCount * game.HighestGreenCubeCount * game.HighestBlueCubeCount);
        }

        return total.ToString();
    }
}
