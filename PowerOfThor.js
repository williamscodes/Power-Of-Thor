var inputs = readline().split(' ');
var lightX = parseInt(inputs[0]); // the X position of the light of power
var lightY = parseInt(inputs[1]); // the Y position of the light of power
var initialTX = parseInt(inputs[2]); // Thor's starting X position
var initialTY = parseInt(inputs[3]); // Thor's starting Y position



// game loop
while (true) {
    var remainingTurns = parseInt(readline());

    // Declare variables to store X and Y movement
    var directionX = '';
    var directionY = '';
    
    // Declare variables storing the light starting position
    lightX = parseInt(inputs[0]);
    lightY = parseInt(inputs[1]);
    
    // Set Thor initial position
    var thorX = initialTX;
    var thorY = initialTY;
    
    // Change Thor X location based on comparison to light X
    if (thorX > lightX)
    {
        directionX = 'W';
        initialTX = initialTX - 1;
    }
    else if (thorX < lightX)
    {
        directionX = 'E';
        initialTX = initialTX + 1;
    }
    
    // Change Thor Y location based on comparison to light y
    if (thorY > lightY)
    {
        directionY = 'N';
        initialTY = initialTY - 1;
    }
    else if (thorY < lightY)
    {
        directionY = 'S';
        initialTY = initialTY + 1;
    }

    print(directionY + directionX); // A single line providing the move to be made: N NE E SE S SW W or NW
}
