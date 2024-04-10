using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj;

public struct Coordinates
{
    public Letters letter;
    public int number;
    /// <summary>
    /// Constructs a new Coordinates object from the given string
    /// </summary>
    /// <param name="text"></param>
    public Coordinates(string? text)
    {
        if (text.Length == 2 && char.IsLetter(text[0]) && text[0] >= 'a' && text[0] <= 'h'
            && char.IsDigit(text[1]) && text[1] >= '1' && text[1] <= '8')
        {
            text = text.ToUpper();
            Letters.TryParse(text[0].ToString(), out letter);
            int.TryParse(text[1].ToString(), out number);
        }
        else
        {
            throw new ArgumentException("You entered invalid coordinate!");
        }
    }
    public override string ToString()
    {
        return $" {letter}{number}";
    }
}
public enum Letters
{
    A, B, C, D, E, F, G, H
}
