\# Development Document md style



\## Project



Project name: Lilo \& Stitch: Island Adventure



Course and assignment: CS120 Application Development – Week 10 Game Development



Developer or team: Desiree Kamerer Fuentes (Individual Project)



Date started: July 28, 2026



Technology or language: Visual Basic .NET (WPF)



\--------------------------------------------------



\## Brief



Lilo \& Stitch: Island Adventure is a retro arcade-style catching game where the player controls Stitch or Angel to collect seashells and experiment capsules while avoiding enemies.





\### Story



After a powerful storm scattered experiment capsules and seashells across the island, Stitch and Angel work together to restore the beaches. The player chooses one character and collects as many items as possible while avoiding dangerous enemies.



\### Goal



Choose a character, collect enough seashells and experiment capsules to reach the target score, and avoid enemies before losing all three waves.



\### User or player



The player chooses either Stitch or Angel before the game begins. The selected character explores the island, collects important items, avoids hazards, and completes the level.



\### Controls


\- Mouse Click = Select Stitch or Angel
\- Left Arrow = Move Left

\- Right Arrow = Move Right



\### win Condition



Reach the target score



\### Lose Condition



Lose all three waves



\### Required deliverables



☐ Review the Week 10 context and retro game study.

☐ Create a Visual Basic WPF project.

☐ Complete the Development Document.

☐ Complete the Reference Study and Adaptation section.

☐ Create an Asset Manifest.

☐ Prepare at least three game assets.

☐ Create a GitHub repository.

☐ Save screenshots showing project setup.

☐ Create a README.

☐ Submit the GitHub repository link.

☐ Post the required Discord update.



Submission destination:

Canvas using the GitHub repository link.



\--------------------------------------------------



\## Story or context



A peaceful tropical island has become scattered with supplies after a powerful storm. The player explores beaches, forests, caves, and island paths to recover the missing supplies needed to repair a damaged boat. Along the way, the player must avoid obstacles, collect important items, and successfully complete the adventure before leaving the island.



\--------------------------------------------------



\## Product definition



The first working version of the game includes a character selection screen, one playable map, player movement, collectible items, simple obstacles, and a victory screen after all required items have been collected.


\--------------------------------------------------



\## Reference study and adaptation

|What I noticed|Keep, Change, or Replace?|Why?|Update Needed in My Plan|
|-|-|-|-|
|The tutorial begins with a title screen before gameplay starts.|Keep|Players need a clear starting point before beginning the game.|Add a title screen with Lilo \& Stitch: Island Adventure and a Start button.|
|The player moves using keyboard controls.|Keep|Simple keyboard controls fit a retro-style game and are easy to learn.|Use the arrow keys to move Stitch around the island.|
|The game uses collectible items to complete objectives.|Change|My game will use island-themed collectibles instead of dungeon treasure.|Replace treasure with seashells, experiment capsules, and Ohana Tokens.|
|The tutorial uses a dungeon environment.|Replace|My game takes place on a Hawaiian island inspired by Lilo \& Stitch.|<br />Create beaches, forests, caves, and Jumba's laboratory instead of dungeon rooms.|
|The tutorial uses retro-style graphics.|Keep|The assignment focuses on creating a retro game.|Use retro-inspired pixel graphics throughout the game.|





\--------------------------------------------------



\## Systems and screens



|System or Screen|Input|Action|Output|
|-|-|-|-|

| Character Selection | Mouse Click | Player chooses Stitch or Angel | Selected character is saved and Play becomes available |
|Title Screen|Start button|Starts the game|Game screen appears|
|Player Movement|Left and right arrow keys|Moves Stitch horizontally|Stitch moves across the bottom|
|Falling Items|Game timer|Moves items downward|Capsules, seashells, and enemies fall|
|Collectible System|Stitch touches capsule or seashell|Collects item|Score increases|
|Enemy System|Stitch touches enemy|Removes one wave|Health display updates|
|Missed Item System|Item reaches bottom|Removes item from screen|New item can appear|
|Victory Screen|Target score reached|Ends the level|Victory message appears|
|Game Over Screen|Hearts reach zero|Ends the game|Restart option appears|



\--------------------------------------------------

\## Information containers

|Variable, Property, List, Table|Data Type|Purpose|Example Value|
|-|-|-|-|
| SelectedCharacter | String    | Stores the player's selected character | Stitch  |
|PlayerScore|Integer|Stores the current score|150|
|PlayersHearts|Integer|Stores remaining waves|3|
|TargetScore|Integer|Stores score needed to win|500|
|PlayerSpeed|Double|Controls Stitch's movement speed|8.0|
|ItemFallSpeed|Double|Controls how fast items fall|5.0|
|GameRunning|Boolean|Tracks whether the game is active|True|
|CurrentItemType|String|Stores the type of falling item|Seashell|



\--------------------------------------------------

\## Actions

|Funntion, Procedure, Method, or Event|Purpose|Input|Result|
|-|-|-|-|
| SelectCharacter | Saves the chosen character | Mouse Click | Stitch or Angel becomes the active player |
|StartGame|Starts a new game|Start button|Game begins|
|MovePlayer|Moves Stitch left or right|Arrow keys|Player postion changes|
|SpawnItem|Creates a falling item|Game timer|New item appears|
|MoveItems|Moves items downward|Timer tick|Items fall|
|CollectItem|Handles capsules and seashells|Collision|Score increases|
|HitEnemy|Handles enemy collision|Collision|One heart is removed|
|CheckWin|Checks target score|Current score|Victory screen appears|
|CheckGameOver|Checks remaining hearts|Heart count|Game-over screen appears|



\--------------------------------------------------

\## Environment



Required editor:

Visual Studio 2022



Required workload or SDK:

.NET Desktop Development



Project template:

Visual Basic WPF Application (.NET)



Required packages or libraries:

Standard .NET libraries



Operating system or device:

Windows 10 or Windows 11



Proof that setup works:

The empty WPF project builds successfully and opens the application window.



\--------------------------------------------------



\## Assets



Asset Manifest:

AssetManifest.txt



Planned assets:



\- Stitch player sprite
\- Angel player sprite
\- Character selection background
\- Gameplay background
\- Seashell collectible
\- Wave icon
\- Title screen artwork


\--------------------------------------------------



\## Milestones



|Milestones|Definition of Done|Target Date|Status|
|-|-|-|-|
|Project Setup|Empty WPF project builds and runs successfully|Week 10|In Progress|
|Development Document|All required sections completed|Week 10|Complete|
|Asset Manifest|Planned assets documented|Week 10|In Progress|
|GitHub Repository|Repository created and organized|Week 10|In Progress|
|First Playable Version|Stitch can move around one island area and collect items|Week 11|Planned|



\----------------------------------------------------



\## Questions and decisions



|Date|Question or Problem|Source Used|Decision or Answer|Next Action|
|-|-|-|-|-|
|July 28, 2026|How can I make my game feel different from the tutorial while still following the assignment requirements?|Week 10 assignment instructions and retro game tutorial|I decided to keep the retro gameplay but change the story and setting to a tropical island adventure inspired by Lilo \& Stitch.|Continue developing the game's story and map.|
|July 28, 2026|What features should I include in the first playable version so the project stays manageable?|Development Document template and assignment requirements|The first version will focus on player movement, one island area, collectible items, simple obstacles, and one mission.|Create the Build Map and begin planning the game screens.|
|July 28, 2026|What assets will I need before I start programming the game?|Asset planning and course requirements|I identified the main assets needed, including character sprites, island backgrounds, collectibles, and menu graphics.|Create the Asset Manifest and organize the Assets folder.|



\--------------------------------------------------



\## Risks



\- Learning WPF game programming.

\- Finding appropriate retro game assets.

\- Managing time while completing the project.

\- Debugging player movement and collision detection.

\- Completing all required documentation before submission.

