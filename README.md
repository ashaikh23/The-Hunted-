# The Hunted!

## Objective
The objective of the game is to capture 15 hiders and avoid getting caught by the evil robot seekers.

## How to Play
To control the player:
- Point using the mouse pointer.
- Move using WASD keyboard controls.

## Components

### The Player
- Controlled through keyboard and mouse inputs.
- Starts with a speed of 190.
- Speed increases by 10 when a hider is caught.
- Receives a temporary speed boost that doubles the speed.
- Keeps track of the number of hiders caught.

### The Seekers
- Seekers aim to find and eliminate the player.
- Their speed increases over time following a logarithmic function.

### The Hiders
- Hiders attempt to escape the player.
- Utilize an AI that calculates the player's position and plans their escape.

## Citations
- [Unity Movement AI](https://github.com/antonpantev/unity-movement-ai)
- Assets: LowPoly Environment Pack by Korveen
  - [Unity Asset Store Link](https://assetstore.unity.com/packages/3d/environments/landscapes/lowpoly-environment-pack-99479)

Made with Unity.
