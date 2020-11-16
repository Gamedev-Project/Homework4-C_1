## Jumper Frog Unity Game created by avi haimov and niv tal
![](https://i.imgur.com/iTrGN7B.png)
## [Game link !](https://aviniv.itch.io/jumper-frog)  
The homework assigminet which we follows is [right here!](https://github.com/gamedev-at-ariel/gamedev-5781/blob/master/04-unity-triggers/homework.pdf)
### In this game the player is the famous crazy frog who in order to earn points has to cross the road full of cars without getting hit at all.

#### Score:  
![](https://i.imgur.com/ZAfKgco.png)  
At each good crossing of the road at the end the player gets one point for his SCORE and then straight starts a new session and so the player can score many points.  
The code we used to execute it is in several places. First we created a canvas variable called "SCORE" where we created a static variable called CurrentScore that initializes to 0.  
There is an element called "GOAL" where there has a trigger, if something touches it then the CurrentScore goes up in 1 and the frog starts again from the beginning of the road.



The code of [Goal](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/Goal.cs)  
The code of [SCORE](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/Score.cs) 
#### Movement:  
![](https://i.imgur.com/7pieJZ5.png)

The movement of the frog is with the help of the arrow keys, or with the help of the buttons (W, A, S, D).
Audio: The game has nostalgic background music of the crazy frog to put the player in the right mood. To cancel the sounds, there is a button at the top of the screen.  
The movement in the game is limited, it is done by a "CAR" tag to all the vehicles, and also a trigger in the frog itself that if it hits a CAR component then the score is reset and the game resets and starts again.  
The code of [Movement](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/Frog.cs ) 

#### Boundaries:  
The game has clear boundaries. The frog cannot move beyond the given screen and cannot exit it.
In addition, the vehicles that are created in the game will be destroyed when they go beyond the screen when they will touch a boarder.   
The code of [Boundaries of cars ](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/Car.cs )  

We added 3 box-colider gameobject boarders and edit them on layer "Boarder".
we inserted raycasthit object which tells us if our frog has hit something with the Layer "Boarder" and if it does hit something it will not let it pass and just let it move the other directions but not pass the boarder.
We did the same thing on horizontly walls and vertically walls.     
The code of [Boundaries of the Frog ](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/Frog.cs ) 

#### Sounds:  
![](https://i.imgur.com/sLTT1Rs.png)  
We created the sounds in the game using a component called "Audio Source" and created a "Tuggle" button inside the canvas that allows you to mute the music and play it again with the click of a button in the game.

#### car spawner: 
![](https://i.imgur.com/oEWqqwY.png)  

There are three car spawns for each lane.  
why? To create difficulty and interest in the game and make the game more challenging.  
The vehicles came out in sets of threes and after a while there will be a small delay of a break and only then will the frog be able to pass.
The code of [car spawner](https://github.com/Gamedev-Project/Homework4-C_1/blob/main/Assets/CarSpawner.cs )  

To write part of the code above, we used tutorial video on YouTube.  
###Hope you Like it! Niv & Avi!!






 
