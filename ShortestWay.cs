using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    internal class ShortestWay
    {
        public void Run()
        {
            Board board = new Board();
            Console.WriteLine("Welcome to Knight Game!\n Enter start coordinate");
            Coordinates start = new Coordinates(Console.ReadLine());
            Console.WriteLine("Enter end coordinate");
            Coordinates end = new Coordinates(Console.ReadLine());
            board.CreateBoard(start, end);
            List<Coordinates> coordinates = BFS(start, end);
            foreach (var c in coordinates)
            {
                Console.WriteLine(c);
            }
        }
        /// <summary>
        /// Algorithm for finding the shortest path
        /// </summary>
        /// <param name="startCoord"></param>
        /// <param name="endCoord"></param>
        /// <returns></returns>
        public List<Coordinates> BFS(Coordinates startCoord, Coordinates endCoord)
        {
            Knight knight = new Knight();
            Queue<Coordinates> coordQueue = new Queue<Coordinates>();
            List<Coordinates> visited = new List<Coordinates>();
            Dictionary<Coordinates, Coordinates> parent = new Dictionary<Coordinates, Coordinates>();
            coordQueue.Enqueue(startCoord);
            visited.Add(startCoord);
            while (coordQueue.Count > 0)
            {
                Coordinates current = coordQueue.Dequeue();
                if (current.Equals(endCoord))
                {
                    break;
                }
                List<Coordinates> possibleSteps = knight.CheckingPossibleSteps(current);

                foreach (var step in possibleSteps)
                {
                    if (!visited.Contains(step))
                    {
                        coordQueue.Enqueue(step);
                        parent[step] = current;
                        visited.Add(step);
                    }
                }
            }
            List<Coordinates> shortestPath = new List<Coordinates>();
            Coordinates coord = endCoord;
            while (!coord.Equals(null))
            {
                shortestPath.Add(coord);
                if (coord.Equals(startCoord))
                {
                    break;
                }
                coord = parent[coord];
            }
            shortestPath.Reverse();
            return shortestPath;
        }
    }
}
