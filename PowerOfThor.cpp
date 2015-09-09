#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    int lightX; // the X position of the light of power
    int lightY; // the Y position of the light of power
    int initialTX; // Thor's starting X position
    int initialTY; // Thor's starting Y position
    cin >> lightX >> lightY >> initialTX >> initialTY; cin.ignore();

    // game loop
    while (1) {
        int remainingTurns;
        cin >> remainingTurns; cin.ignore();
        
        // String variables to contain compass direction output
        string directionX = "";
        string directionY = "";
        
        // Integers to store the initial cartesian coordinates of Thor
        int thorX = initialTX;
        int thorY = initialTY;
        
        // Determine the output for Thor X coordinate
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
        
        // Determine the output for Thor Y coordinate
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
        
        // Output to console
        cout << directionY + directionX << endl;
    }
}
