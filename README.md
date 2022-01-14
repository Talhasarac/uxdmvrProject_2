# UXDMVRProject
## City Destruction VR Game
### Who is in the team?
Caroline Kendrick and Paul Schramm
### Idea / Motivation / Proposed Outcome
Sandbox Godzilla-like 1st person destruction game: Players take the form of a giant monster (such as a giant lizard or robot), intent on causing damage to a level.
### Requirements:
Software: Unity 3D 2020.3.19f  
Hardware: Oculus Rift S + Various Gaming Systems  
Input: Rift S Controllers


### Outline of Planned Implementation:
*Italicized content indicates additions past MVP*

###### Environment /Setting:
- City comprised of stationary buildings, cars, and planes/helicopters, *people*
(similar visual style to [Katamari Damacy](https://www.youtube.com/watch?v=BAtuIRy2mL4), inspired by the scale of [Giant Cop](https://store.steampowered.com/app/451080/Giant_Cop_Justice_Above_All/))
- Buildings could be comprised of multiple brick-like elements to make them easier to destroy
- Moving aspects- cars, people, planes follow tracks around city *and react or run away from Godzilla*
- *The more destroyed the city becomes, the darker the mood. More fires, darker clouds and more fog could be added. Influenced by amount of destruction or just over time.*
- *Background music, sound effects*
###### Player Model:
- Big chunky monster or robot hands. *Finger/Claw movement according to how the player is holding the controller. Make use of the touch sensitive buttons of the Rift Controllers.*
- *Player has a laser eye beam that destroys the scenery when the player is looking through the world. It takes time to recharge. Recharge could also be achieved by eating objects to gain energy.*
###### Goal of the game:
- Having fun while destroying the city as much as possible within a given timeframe
- *Player is victorious once a certain level of destruction has been reached*
###### Movement Options:
- Teleportation: Teleport user to a certain location by pressing the trigger forward. A beam would appear that would indicate where the player ends up after the teleport. The highlighted location could be marked by paw imprints or robot footprints (according to player model)
- Jump: A teleport-like movement without breaking immersion - player would be able to traverse larger distance quickly by launching themselves at a targeted area and leaping ( large, two handed drag motion )
- Locomotion: Moving by bringing the controller in front of the body, holding a button and then dragging the controller alongside the body. This type of movement can be seen in the game [Gorn](https://store.steampowered.com/app/578620/GORN/).
###### Additional Optional Details:
- *Have the ground shakes when godzilla teleports/jumps*
- *Game Logic: A detailed destruction score, attaching value to (potentially ) object collisions, objects removed from their original spot*
- *A menu that appears at the start of the game*
- *Different game modes*
-- *Reverse Godzilla - “Goodzilla” - you put the city back together*
-- *Mode without time limit*
