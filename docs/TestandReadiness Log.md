# Test and Readiness Log

## Test Environment

- Project version or commit: Initial project setup and character selection screen
- Computer or device: Windows PC
- Operating system: Windows 11
- Date: July 28, 2026

## Preparation Checks

| Check ID | Action | Expected Result | Actual Result | Pass or Fail | Fix or Next Action | Evidence File |
|---|---|---|---|---|---|---|
| P01 | Open the project | Project opens in Visual Studio 2022 without errors. | The project opened successfully in Visual Studio 2022. | Pass | None | `evidence/Run the empty environment.png` |
| P02 | Run the current build | The application launches successfully. | The application builds and displays the character selection screen. | Pass | Add the planned title screen before the character selection screen. | `evidence/02-character screen.png` |
| P03 | Review repository structure | The project folders and required files are present. | The repository contains the project folders, documentation, evidence, `.gitignore`, `.gitattributes`, and `README.md`. | Pass | Continue organizing project files as development progresses. | *(Repository screenshot recommended)* |
| P04 | Verify GitHub repository | Repository and README are visible while signed out. | The repository is public and the README displays correctly on the main page. | Pass | None | *(GitHub repository screenshot recommended)* |

## Build Test Cases

| Test ID | Action | Expected Result | Actual Result | Pass or Fail | Fix or Next Action | Evidence File |
|---|---|---|---|---|---|---|
| T01 | Launch the application | The current character selection screen displays correctly with Stitch, Angel, and the Play button. | The application launches successfully and displays the character selection screen. | Pass | Add a title screen that loads before character selection. | `evidence/02-character screen.png` |
| T02 | Select a character | Clicking Stitch or Angel selects and highlights the chosen character. | The selected character is saved, and the Play button becomes available. | Pass | Connect the selected character to the puzzle gameplay screen. | `evidence/02-character screen.png` |
| T03 | Open the title screen | The title screen displays the game name and a Start button before character selection. | The title screen has not been implemented yet. | Not Tested | Create the title screen and connect the Start button to the character selection screen. | *(Evidence will be added after implementation)* |

## Known Issues

The project is currently in the early stages of development. The character selection screen has been completed. The title screen still needs to be created and connected to the character selection screen.

Gameplay features such as the puzzle board, falling puzzle pieces, piece movement and rotation, collision detection, completed-row clearing, scoring, the power meter, power-ups, sound effects, level progression, and the game-over condition will be implemented during future development milestones.

The game will not use a lives system. The game will end when the puzzle pieces stack to the top of the board and a new piece can no longer enter the playing area.

## Final Check

- [x] Required preparation checks were completed.
- [x] Failed checks were repeated after the fix.
- [x] Evidence filenames match the README map.
- [x] The current project build was tested from a fresh start.
- [ ] The title screen has been created and tested.