# GameDevProject2

This game is titled "Maze Brew." 

The intent of this game is to allow players an experience to explore a maze that has 4 different ends.

The narrative of this game is that the player is someone who is in an area where "they're not supposed to be". Then, the wizard, who is the only other character, asks you to get his coffee ingredients for him from the maze.

The mechanics in this game that take in player input are relatively straight-forward. The player moves around with WASD and interacts with the E key. The player does not need to interact with the ingredients, whih are instead automatically picked up when they get close enough. The castle walls and boxes are objects that the player cannot walk through, along with the torches.

The aesthetics of this game are pretty simplistic. It is all pixel art in a medival/fantasy setting (as seen by the player character being a knight and the NPC being a wizard). The music is also a retro 8-bit sounding tune. The ingredients for the coffee are from a seperate asset pack than the background and other items, but they are still pixel art. Additionally, the font used is a pixel font.

Fin's Joys and Struggles -

Joys:

It was nice to spend more time looking into assets this time around compared to the previous lab. I also enjoyed making the maze, though that's not at all coding related.

Struggles:

The same thing happened with the code breaking when I downloaded it at times, but I was able to make it work. When I was working on the particle effect, I kept redoing it because I wanted to make a prefab that both had particles rise from the fire and a glowing effect. It took me a while to figure out that the particles had to be the parent object and the glow had to be the child object, otherwise the cone shape for the particles would look like a sphere (act like the game was 3D), which feels like an oversight.

Haydens's Joys and Struggles -

Joys:

While making this game, I used the dialogue technique that Dr. Goadrich showed us in class, which differed from other ways I had implemented dialogue in the past. It was cool to see how different implementations can give the same results and their respective strengths and weaknesses.

Struggles:

While implementing the dialogue, I had issues with global variables to check if players had talked to certain NPCs and picked up certain items. Figuring out the issue was a struggle, but once it was solved, it felt good to have a new implementation of dialogue.

Assets:
- Base game art(Tilemap and Characters): (https://kenney.nl/assets/tiny-dungeon)
- Coffee ingredients art: https://ghostpixxells.itch.io/pixel-mart
- Background music: https://assetstore.unity.com/packages/audio/music/8bit-music-062022-225623
- Font: https://www.fontspace.com/pixelletters-font-f22954

Fin's contributions:

I figured out the ingredients that would be what the player was seeking, which is admittedly a small part. I also made the maze and then fixed some ingredients that were listed incorrectly in the wizard's dialogue. The last thing I really did was create the particle and glow effects of the torches.

Hayden's contributions:

I created the repo, set up the player, all the scripts, set up the tile map, set up all the components for the ingredients, set up the camera to follow the player, set up different dialogue options for when the player has gained all the ingredients, the background music, and uploaded to itch.
