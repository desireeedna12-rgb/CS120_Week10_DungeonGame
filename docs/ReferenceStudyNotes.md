# Reference Study Notes

Use this document when an assignment asks you to study an existing application, game, tutorial, client example, or product before development.

## Reference

- **Title:** Retro Game Playlist
- **Link:** https://www.youtube.com/playlist?list=PLsvXBxgtEE5nGvERTEVgupe4jaiwiw-bm
- **Date reviewed:** July 28, 2026
- **Why this reference was assigned:** To study the design, gameplay mechanics, project structure, and user interface of retro games before creating my own game.

## What I noticed

| Area | Observation | Why it matters |
|---|---|---|
| Screen or interface | The games use simple title screens, score displays, level progression, and game over screens. | A clean interface makes the game easy to understand and play. |
| User or player action | Players use simple keyboard controls to move game pieces, and many retro games begin with a menu or selection screen before gameplay. | A character selection screen gives players a personalized experience before the puzzle game begins. |
| Data or state | The games keep track of score, levels, and game progress. | Tracking game data gives players feedback and creates progression. |
| Asset or media | The games use colorful sprites, sound effects, music, and themed backgrounds. | Visual and audio assets improve the player's experience and make the game more engaging. |
| Code or project structure | The projects separate gameplay, scoring, user input, and graphics into organized sections. | Organizing the code makes the project easier to build, test, and expand. |

## Keep, Change, or Replace

| Element from the reference | Decision | Reason | Update to my Development Document |
|---|---|---|---|
| Simple keyboard controls | Keep | Easy for players to learn and responsive during gameplay. | Continue using keyboard controls to move and rotate puzzle pieces. |
| Score tracking and level progression | Keep | Gives players goals and shows their progress. | Include score tracking and level progression. |
| Character selection screen | Change | I want players to choose between Stitch and Angel before the game begins. | Add a character selection screen before loading the puzzle board. |
| Classic falling puzzle gameplay | Keep | Puzzle gameplay fits the retro style and provides a fun challenge. | Build a tropical-themed puzzle game inspired by Stitch and Angel. |
| Standard puzzle blocks | Change | I want the game to match the tropical island theme. | Replace standard blocks with seashells, flowers, pineapples, and experiment capsules. |
| Generic game menus | Replace | I want menus that match the tropical island theme. | Create custom title, character selection, game over, and high score screens. |

## Questions to Investigate

1. How can I create falling puzzle pieces in Visual Basic WPF?

2. What is the best way to detect completed rows and remove them?

3. How can I rotate puzzle pieces while keeping them inside the game board?

4. How should I organize the game board, Friendship Meter, and power-ups so the project is easy to expand later?

5. How can I save the player's selected character so it appears throughout the game?

## My Revised Direction

After studying the retro game examples, I decided to create a tropical puzzle game inspired by Stitch and Angel. Players will first choose their character before starting the game. I will keep the simple keyboard controls, score tracking, level progression, and retro puzzle gameplay because they make the game fun and easy to learn. I will add a Friendship Meter that charges as rows are cleared, allowing players to activate special power-ups. I will customize the graphics, sounds, menus, puzzle pieces, and power-ups with tropical island artwork and Stitch-inspired elements so the game has its own unique style while following the design principles demonstrated in the reference material.