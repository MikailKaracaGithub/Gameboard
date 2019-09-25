using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboard
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfRows = 8;
            int numberOfColumns = 9;

            int cellNumber = 8;


           Console.WriteLine("Number of columns is " + numberOfColumns);
           int cellRownumber = (cellNumber - 1) / numberOfColumns + 1;
           int cellColumnNumber = (cellNumber - 1) % numberOfColumns + 1;

           Console.WriteLine("Cell" + cellNumber + " is at row" + cellRownumber + " and column " + cellColumnNumber);

            cellNumber = 16;
            cellRownumber = (cellNumber - 1) / numberOfColumns + 1;
            cellColumnNumber = (cellNumber - 1) % numberOfColumns + 1;
            
            Console.WriteLine("Cell" + cellNumber + " is at row" + cellRownumber + " and column " + cellColumnNumber);

            cellNumber = 17;
            cellRownumber = (cellNumber - 1) / numberOfColumns + 1;
            cellColumnNumber = (cellNumber - 1) % numberOfColumns + 1;

            Console.WriteLine("Cell" + cellNumber + " is at row" + cellRownumber + " and column " + cellColumnNumber);

            cellNumber = 23;
            cellRownumber = (cellNumber - 1) / numberOfColumns + 1;
            cellColumnNumber = (cellNumber - 1) % numberOfColumns + 1;

            Console.WriteLine("Cell" + cellNumber + " is at row" + cellRownumber + " and column " + cellColumnNumber);
            Console.ReadLine();


        }
    }
}
