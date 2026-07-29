\# Test and Readiness Log



\## Test environment



\- \*\*Project version or commit:\*\* Initial project setup

\- \*\*Computer or device:\*\* Windows PC

\- \*\*Operating system:\*\* Windows 11

\- \*\*Date:\*\* July 28, 2026



\## Preparation checks



| Check ID | Action | Expected result | Actual result | Pass or fail | Fix or next action | Evidence file |

|---|---|---|---|---|---|---|

| P01 | Open the project | Correct editor opens the project | Project opened successfully in Visual Studio 2022. | Pass | None | `evidence/OpenProject.png` |

| P02 | Run the empty or current build | Expected window or output appears | Project builds successfully and opens the application window. | Pass | Continue adding gameplay features. | `evidence/RunProject.png` |

| P03 | Review required folders | Files are in the planned locations | Repository contains `src`, `assets`, `docs`, `evidence`, `.gitignore`, and `README.md`. | Pass | Continue adding project files as development progresses. | `evidence/RepositoryStructure.png` |

| P04 | Open the submitted link while signed out | Repository and README are visible | Repository opens successfully and README is displayed on the main page. | Pass | None | `evidence/GitHubRepository.png` |



\## Build test cases



Add feature tests here when development begins.



| Test ID | Action | Expected result | Actual result | Pass or fail | Fix or next action | Evidence file |

|---|---|---|---|---|---|---|

| T01 | Launch the application | Main game window opens successfully. | Application launches correctly. | Pass | Continue implementing gameplay mechanics. | `evidence/RunProject.png` |



\## Known issues



The game is currently under development. Core gameplay features such as player movement, collision detection, scoring, collectibles, and sound effects are still being implemented. These features will be tested again after development is complete.



\## Final check



\- \[x] Required preparation checks were completed.

\- \[x] Failed checks were repeated after the fix.

\- \[x] Evidence filenames match the README map.

\- \[x] The project was tested from a fresh start.

