# Development Document

## Project

Project name: Stitch & Angel: Island Stack

Course and assignment: CS120 Application Development – Week 10 Game Development

Developer or team: Desiree Kamerer Fuentes (Individual Project)

Date started: July 28, 2026

Technology or language: Visual Basic .NET (WPF)

--------------------------------------------------

## Brief

Stitch & Angel: Island Stack is a retro-inspired puzzle game where players choose to play as Stitch or Angel and arrange falling tropical-themed puzzle pieces to clear rows, earn points, and survive as long as possible.

### Story

After one of Jumba's experiments scattered colorful island supplies across Hawaii, Stitch and Angel work together to organize everything before the island becomes overwhelmed. Players clear rows of tropical items, earn Friendship Energy, and activate special powers to keep the board from filling up.

### Goal

Choose Stitch or Angel, clear rows of tropical puzzle pieces, earn points, activate power-ups, and survive as the game becomes faster.

### User or Player

The player chooses either Stitch or Angel before the game begins. The selected character remains on screen throughout the game while the player controls falling puzzle pieces and earns the highest score possible.

### Controls

- Mouse Click = Select Stitch or Angel
- Left Arrow = Move piece left
- Right Arrow = Move piece right
- Up Arrow = Rotate piece
- Down Arrow = Drop piece faster
- Space Bar = Activate power-up

### Win Condition

Earn the highest score possible by clearing rows and surviving as long as you can.

### Lose Condition

The game ends when the puzzle pieces stack to the top of the game board.

### Required Deliverables

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

--------------------------------------------------

## Story or Context

Jumba's latest experiment accidentally scattered tropical supplies across the island. Players choose either Stitch or Angel to organize the falling puzzle pieces before they completely cover the island. Every completed row earns points and fills the Friendship Meter, allowing players to activate special island-themed abilities.

--------------------------------------------------

## Product Definition

The first working version of the game includes a title screen, character selection screen, puzzle board, falling puzzle pieces, scoring, row clearing, a Friendship Meter, and tropical-themed power-ups.

--------------------------------------------------

## Reference Study and Adaptation

| What I Noticed | Keep, Change, or Replace? | Why? | Update Needed in My Plan |
|----------------|---------------------------|------|--------------------------|
| The tutorial begins with a title screen before gameplay starts. | Keep | Players need a clear starting point before beginning the game. | Create a tropical title screen with Stitch & Angel: Island Stack. |
| The player controls falling pieces using the keyboard. | Keep | Simple controls are easy to learn and fit a retro puzzle game. | Use the arrow keys to move and rotate puzzle pieces. |
| The tutorial clears completed rows. | Keep | Clearing rows is the main objective of the game. | Use tropical-themed puzzle pieces instead of standard blocks. |
| The tutorial uses classic block graphics. | Change | My game will use Lilo & Stitch inspired tropical items. | Replace blocks with seashells, flowers, pineapples, and experiment capsules. |
| The tutorial uses retro-style graphics. | Keep | Retro graphics match the assignment requirements. | Create colorful tropical pixel-inspired artwork. |

--------------------------------------------------

## Systems and Screens

| System or Screen | Input | Action | Output |
|------------------|-------|--------|--------|
| Title Screen | Start Button | Begins the game | Character Selection screen appears |
| Character Selection | Mouse Click | Player chooses Stitch or Angel | Selected character is saved |
| Puzzle Board | Arrow Keys | Move and rotate puzzle pieces | Pieces move around the board |
| Puzzle Piece System | Timer | Drops puzzle pieces | Pieces fall automatically |
| Row Clearing | Completed Row | Removes completed row | Score increases |
| Friendship Meter | Clear rows | Charges power meter | Power-up becomes available |
| Power-Up System | Space Bar | Activates selected power | Special ability is used |
| Game Over Screen | Board fills to the top | Ends the game | Restart option appears |

--------------------------------------------------

## Information Containers

| Variable, Property, List, Table | Data Type | Purpose | Example Value |
|---------------------------------|-----------|---------|---------------|
| SelectedCharacter | String | Stores the selected character | Stitch |
| PlayerScore | Integer | Stores the player's score | 1500 |
| CurrentLevel | Integer | Stores the current level | 2 |
| FriendshipMeter | Integer | Stores power-up progress | 75 |
| CurrentPiece | String | Stores the active puzzle piece | Seashell |
| NextPiece | String | Stores the upcoming puzzle piece | Hibiscus |
| GameRunning | Boolean | Tracks whether the game is active | True |

--------------------------------------------------

## Actions

| Function, Procedure, Method, or Event | Purpose | Input | Result |
|----------------------------------------|---------|-------|--------|
| SelectCharacter | Saves the selected character | Mouse Click | Character is selected |
| StartGame | Begins gameplay | Start Button | Puzzle board loads |
| MovePiece | Moves puzzle piece | Arrow Keys | Piece moves |
| RotatePiece | Rotates puzzle piece | Up Arrow | Piece rotates |
| DropPiece | Drops puzzle piece faster | Down Arrow | Piece falls quickly |
| ClearRows | Removes completed rows | Completed row | Score increases |
| ChargeFriendshipMeter | Builds power meter | Cleared rows | Power meter fills |
| ActivatePower | Uses selected power-up | Space Bar | Special ability activates |
| CheckGameOver | Checks if board is full | Board status | Game Over screen appears |

--------------------------------------------------

## Environment

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

The WPF project builds successfully and opens the application window.

--------------------------------------------------

## Assets

Asset Manifest:

ASSET_MANIFEST.md

Planned assets:

- Stitch portrait
- Angel portrait
- Title screen background
- Character selection background
- Tropical gameplay background
- Seashell puzzle block
- Hibiscus puzzle block
- Pineapple puzzle block
- Experiment capsule puzzle block
- Friendship Meter
- Wave power-up icon
- Sparkle power-up icon
- Experiment power-up icon
- Play button
- Back button
- Next Piece frame
- Game Over artwork
- High Score screen

--------------------------------------------------

## Milestones

| Milestone | Definition of Done | Target Date | Status |
|------------|-------------------|-------------|--------|
| Project Setup | WPF project builds and runs successfully | Week 10 | Complete |
| Development Document | All required sections completed | Week 10 | Complete |
| Asset Manifest | Planned assets documented | Week 10 | In Progress |
| GitHub Repository | Repository created and organized | Week 10 | Complete |
| First Playable Version | Puzzle board, movement, scoring, Friendship Meter, and power-ups work correctly | Week 11 | Planned |

--------------------------------------------------

## Questions and Decisions

| Date | Question or Problem | Source Used | Decision or Answer | Next Action |
|------|----------------------|-------------|--------------------|-------------|
| July 28, 2026 | How can I make my game different from the tutorial? | Week 10 assignment instructions | I decided to create a tropical puzzle game inspired by Stitch & Angel with original artwork and power-ups. | Begin designing puzzle pieces and UI. |
| July 28, 2026 | What features should be included in the first version? | Development Document template | Focus on puzzle gameplay, scoring, row clearing, the Friendship Meter, and power-ups. | Build the puzzle board. |
| July 28, 2026 | What assets are needed before programming? | Asset planning | I identified the backgrounds, characters, puzzle blocks, power-up icons, buttons, and UI graphics needed. | Create the Asset Manifest. |

--------------------------------------------------

## Risks

- Learning WPF game programming.
- Implementing puzzle piece movement and rotation.
- Debugging collision detection and row clearing.
- Balancing the Friendship Meter and power-ups.
- Managing time while completing the project.
- Completing all required documentation before submission.