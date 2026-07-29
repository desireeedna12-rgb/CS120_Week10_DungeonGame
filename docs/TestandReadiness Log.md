# Test and Readiness Log

## Test environment

- Project version or commit: Initial project setup and character selection screen
- Computer or device: Windows PC
- Operating system: Windows 11
- Date: July 28, 2026

## Preparation checks

| Check ID | Action | Expected result | Actual result | Pass or fail | Fix or next action | Evidence file |
|---|---|---|---|---|---|---|
| P01 | Open the project | Project opens in Visual Studio 2022 without errors. | The project opened successfully in Visual Studio 2022. | Pass | None | `evidence/Run the empty environment.png` |
| P02 | Run the current build | The application launches successfully. | The application builds and displays the character selection screen. | Pass | Continue implementing gameplay features. | `evidence/02-gameplay-background.png` |
| P03 | Review repository structure | Required folders and files are present. | The repository contains `src`, `assets`, `docs`, `evidence`, `.gitignore`, `.gitattributes`, and `README.md`. | Pass | Continue organizing project files as development progresses. | *(Repository screenshot recommended)* |
| P04 | Verify GitHub repository | Repository and README are visible while signed out. | Repository is public and the README displays correctly on the main page. | Pass | None | *(GitHub repository screenshot recommended)* |

## Build test cases

| Test ID | Action | Expected result | Actual result | Pass or fail | Fix or next action | Evidence file |
|---|---|---|---|---|---|---|
| T01 | Launch the application | Character selection screen displays correctly with the background, Stitch, Angel, and Play button. | Character selection screen launches successfully and user can select a character. | Pass | Continue implementing gameplay mechanics. | `evidence/02-gameplay-background.png` |

## Known issues

The project is currently in the early stages of development. The character selection screen has been completed, while gameplay features such as player movement, collision detection, collectibles, scoring, sound effects, and win/lose conditions will be implemented in future development milestones.

## Final check

- [x] Required preparation checks were completed.
- [x] Failed checks were repeated after the fix.
- [x] Evidence filenames match the README map.
- [x] The project was tested from a fresh start.
