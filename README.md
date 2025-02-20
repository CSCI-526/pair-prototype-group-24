# Descriptive Document

## GraviFlip

## Team Members

| Name | GitHub Username |
| :---- | :---- |
| Shujie Chen | shujiejune |
| Zixuan Xu | hobb8t |
| Deep Shah | deepshah08 |

## Logline

*Platformer \+ Gravity Shifting*  
A 2D-platformer game where you can shift the direction of gravity to control the jump trajectories of the protagonist to land on the target platforms.

## Genre Research

Research done on three genre titles that are a platformer:

1. [Mobius](https://papercookies.itch.io/mobius)  
2. [Astral Ascent](https://alice-bottino.itch.io/astral-ascent)  
3. [Self](https://dev-dwarf.itch.io/self)

### Tropes:

When looking at the games listed above, we find common elements of these games that are shared by many others in the platformer genre. The jump mechanic is one of the most common elements found in platformers. These games feature different jump mechanics in addition to the zero initial velocity vector, traditional vertical gravity and consequent parabolic trajectory:

* *Mobius* features Mobius strips instead of flat platforms. The player is subject to move on a platform with continuously altering slope, in other words, it's also bearing bending gravity relative to its translation direction.  
* *Astral Ascent* features a mouse-defined drag force when launching each jump of the star, simulating a pellet shot by a catapult. The player can set the initial velocity vector (arbitrary direction, arbitrary value within a limit) of the star, therefore controlling the jump trajectory.  
* *Self* features additional horizontal and vertical boosts at the beginning of jump, enabling the player to skillfully jump in an altered parabolic trajectory to collect pellets, to avoid mortal zones and to land on the target platforms.


### Twist:

Instead of conventional jumping mechanics, the player can manipulate gravity's direction mid-motion, altering the jump trajectory. 

* Gravity can be shifted to four different angles (0°, 90°, 180°, 270° flips), allowing complex movement strategies.   
* Certain zones limit gravity changes, adding a puzzle-solving layer to platforming.   
* The Player must utilize its control of gravity direction dynamically to adapt to the spatial obstacles.

### Why gravity shifting is innovative for a platformer:

Our core mechanic is to control the direction of gravity to alter the jump trajectory. Instead of exerting a one-off boost at the beginning of jump, either using curvant spatial logics, or switching the gravity direction to “up” and “down” and linearly pulling the protagonist towards the ceiling, players must solve gravity-based puzzles, master momentum shifts, and adapt to dynamically changing perspectives. It makes the game more challenging and disorienting.

## Prototype Description

**GraviFlip** is a 2D-platformer featuring a gravity-shifting mechanic that allows the player to change the gravity direction in multiples of 90° mid-movement. As the player, the goal is to collect all the pellets and reach the exit without landing on the mortal zones. 

## Mechanic Matrices

### Twist & Mechanics Matrix

| Mechanic | Description | Interaction with Twist | Affected Genre Elements | Type of Genre Innovation |
| :---- | :---- | :---- | :---- | :---- |
| Gravity shift (Core Mechanic) | The direction of gravity can be shifted to 0°, 90°, 180°, 270° relative to the original direction | Player can press the arrow keys to shift the direction of gravity during movements | Player movement | shift |

## GitHub Repository

[GraviFlip](https://github.com/CSCI-526/pair-prototype-group-24)

*(Note: The Github link you provide should consist of your Unity project and **not** the WebGL build. Please use Github not just for the sake of submission, but to collaborate with your teammate/s. Make sure you add and update the .gitignore file for Unity projects when you create your repository.)*

## Individual Contributions

| Shujie Chen | *Mechanics fleshing, Documentation, Player movement and Physics implementation* |
| :---- | :---- |
| **Zixuan Xu** | *Core Mechanics Design, Layout Design, Level Design for level 1-2, Documentation* |
| **Deep Shah** | *Level design for level 3-4 , Documentation, UI design, home screen implementation and logic* |
