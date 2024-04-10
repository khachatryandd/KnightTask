using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj;

internal class Knight
{
    /// <summary>
    /// Checks if knight can go to the second coordinate or not
    /// </summary>
    /// <param name="startCoord"></param>
    /// <param name="endCoord"></param>
    /// <returns></returns>
    public bool Move(Coordinates startCoord, Coordinates endCoord)
    {
        int number = Math.Abs(startCoord.number - endCoord.number);
        int letter = Math.Abs((int)startCoord.letter - (int)endCoord.letter);
        if ((number == 1 && letter == 2) || (number == 2 && letter == 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// <summary>
    /// Generates the list of all posible steps for knight from the given coordinate
    /// </summary>
    /// <param name="startCoord"></param>
    /// <returns> A list of coordinates representing all possible steps for the knight</returns>
    public List<Coordinates> CheckingPossibleSteps(Coordinates startCoord)
    {
        int number = startCoord.number;
        Letters letter = startCoord.letter;
        List<Coordinates> steps = new List<Coordinates>();

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                Coordinates nextStep = new Coordinates();
                nextStep.number = i;
                nextStep.letter = (Letters)j;
                if (Move(startCoord, nextStep))
                {
                    steps.Add(nextStep);
                }
            }
        }
        return steps;
    }
}
