using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());
            
            // String to contain the compass directional output
            string directionX = "";
            string directionY = "";
            
            // Integer to store the initial position of Thor
            int thorX = initialTX;
            int thorY = initialTY;
            
            // Determine output for Thor X coordinate
            if (thorX > lightX)
            {
                directionX = "W";
                initialTX = initialTX - 1;
            }
            else if (thorX < lightX)
            {
                directionX = "E";
                initialTX = initialTX + 1;
            }
            
            // Determine output for Thor Y coordinate
            if (thorY > lightY)
            {
                directionY = "N";
                initialTY = initialTY - 1;
            }
            else if (thorY < lightY)
            {
                directionY = "S";
                initialTY = initialTY + 1;
            }

            Console.WriteLine(directionY + directionX); // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }
}
