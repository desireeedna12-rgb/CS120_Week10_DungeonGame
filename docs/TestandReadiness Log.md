# Test and Readiness Log

## Test Environment

- Project version or commit: Initial project setup and character selection screen
- Computer or device: Windows PC
- Operating system: Windows 11
- Date: July 28, 2026

## Preparation Checks

| Check ID | Action | Expected Result | Actual Result | Pass or Fail | Fix or Next Action | Evidence File |
|---|---|---|---|---|---|---|
| P01 | Open the project | Project opens in Visual Studio 2022 without errors. | The project opened successfully in Visual Studio 2022. | Pass | None | `evidence/screenshots/P01-Open-Empty-Project.png` |
| P02 | Run the current build | The application launches successfully. | The application builds and displays the the emtpy screen. | Pass | Contains the empty project when ran. | `evidence/screenshots/P02-Run-Empty-Environment.png` |
| P03 | Review repository structure | The project folders and required files are present. | The repository contains the project folders, documentation, evidence, `.gitignore`, `.gitattributes`, and `README.md`. | Pass | Continue organizing project files as development progresses. | `evidence/screenshots/P03-Repository-Structure.png` |
| P04 | Verify GitHub repository | Repository and README are visible while signed out. | The repository is public and the README displays correctly on the main page. | Pass | None | `evidence/screenshots/P04-GitHub-Repository.png` |

## Build Test Cases

| Test ID | Action | Expected Result | Actual Result | Pass or Fail | Fix or Next Action | Evidence File |
|---|---|---|---|---|---|---|
| T01 | Launch the application | The WPF application launches successfully without errors. | The application launches successfully and displays the default WPF window. | Pass | Begin implementing the title screen and user interface. | `evidence/Screenshots/P02-Run the empty environment.png` |
| T02 | Build the project | The project builds successfully in Visual Studio 2022. | The project builds successfully with no build errors. | Pass | Continue implementing the game features. | `evidence/Screenshots/P02-Run the empty environment.png` |
| T03 | Verify project readiness | The project is ready for game development. | The project structure, documentation, assets, and GitHub repository have been prepared for future development. | Pass | Begin implementing the title screen, character selection, and puzzle gameplay. | `evidence/Screenshots/P03-Review repository (folder) structure.png` |

## Known Issues

The project is currently in the early stages of development. The project has been successfully created and prepared for development, but gameplay features have not yet been implemented.

The title screen, character selection screen, puzzle board, falling puzzle pieces, piece movement and rotation, collision detection, completed-row clearing, scoring, Friendship Meter, power-ups, sound effects, level progression, and game-over condition are planned and will be implemented during future development milestones.

The game will not use a lives system. Instead, the game will end when the puzzle pieces stack to the top of the board and a new piece can no longer enter the playing area.

## Final Check

- [x] Required preparation checks were completed.
- [x] Failed checks were repeated after the fix.
- [x] Evidence filenames match the README map.
- [x] The current project build was tested from a fresh start.
- [x] The project is ready for future game development.