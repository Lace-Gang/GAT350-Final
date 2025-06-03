# Game 
This is a game of plinko programmed in Unity for a Game Physics class Final. 

## Features
In this game, players will be given three different ball types with different masses and "bounciness" to choose from:
* Nomral - Mass: 1   Bounciness: 0.75
* Heavy - Mass: 2    Bounciness: 0.5
* Bouncy: Mass: 1.5  Bounciness: 1

## Ball Types and Spawners
Buttons on the side will allow players to switch ball type at will, and the "balls" at the top of the plinko board will 
spawn a ball of the corresponding type when clicked on. These spawn points are placed at relatively short intervals to 
give the player more variation in the potential path of the ball. Raytracing is used to make these spawners clickable. 
One ball may be spawned in per round. 

## Targets and Points
At the start of each round, one goal at random will be highlighted. This is the target. The target will never be the 
furthest goal at either end. Depending on how difficult each goal is to reach, they are each worth a different number of 
points. 

## Rounds and Game Over
If a player sucessfully gets a ball into the target, the corresponding number of points will be distributed, and the number 
of remaining rounds will go up by one. If the ball fails to reach the target, no points are distributed and the number of 
remaining rounds will go down by one. If there are no new rounds remaining, the game ends. Once the game ends, the player's 
final score will be displayed, and the player will have the option to reset. 

## Resetting
Upon resetting, the score will be set to zero, the number of rounds left will be set to five, the ball type will be set 
to Normal, and a new target will be selected. Players may also choose to Reset at any time using the reset button at the 
bottom left corner. This will yeild the same effects as reseting at the end of the game.


### Note:
The game is small but very fun. Please enjoy! (Please do not claim as your own though)
