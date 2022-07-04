<!--
This README.md template was NOT orginally created by me(notbeer)! This is a fork of:
https://github.com/othneildrew/Best-README-Template
-->


<!-- PROJECT LOGO -->
<br />
<p align="center">
<a href="https://github.com/BricksVR-Modding/BricksVR-Modding-Guide">
    <img src="https://avatars.githubusercontent.com/u/94014912?s=200&v=4" alt="Logo" width="80" height="80">
  </a>
  <h3 align="center"><u>BricksVR Modding</u></h3>

  <p align="center">
    A simple repo that explains the basics, anyone can upload their mods here!
    <br />
    <br />
    <br />
    <a href="https://github.com/zakmasood/BricksVRModding">Github</a>
    ·
    <a href="https://github.com/zakmasood/BricksVRModding/issues/new">Report An Issue</a>
    ·
    <a href="https://github.com/zakmasood/BricksVRModding/issues/new">Request A Feature</a>
  </p>
</p>

  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]
  [![Issues][issues-shield]][issues-url]
  [![MIT License][license-shield]][license-url]

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Modding Types</h2></summary>
  <ol>
    <li>
      <a>Clientside</a>
       <ul>
        <li><a>UI objects such as making the menu dark (darkemod)</a></li>
       </ul>
       <ul>
        <li><a>Adding a cool FPS counter (AXTL's UI Mod)</a></li>
       </ul>
       <ul>
        <li><a>Possibly adding new menus and such!</a></li>
       </ul>
       <ul>
        <li><a>And way more!</a></li>
       </ul>
    </li>
    <li>
      <a>Serverside</a>
       <ul>
        <li><a>Movable bricks as well as new types of bricks!</a></li>
       </ul>
       <ul>
        <li><a>Drivable cars?!</a></li>
       </ul>
       <ul>
        <li><a>A new way to mess with your friends!</a></li>
       </ul>
       <ul>
        <li><a>And again, too much to explain here.</a></li>
       </ul>
    </li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
<br />

## How to start modding

Step 1: Download MelonLoader from https://github.com/LavaGang/MelonLoader and run it.
 - Once you run it, it will ask you to select a MONO (or .exe) application
 - Select BricksVR.exe and hit run / install
 - Once MelonLoader is done installing you are good to go!

### Debugging:

  Exploring the mechanics and workings of the game can be very difficult at times. UnityExplorer helps us to debug the game and modify some behaviours in real time!

Step 1: In order to begin debugging install https://github.com/sinai-dev/UnityExplorer/releases
 - Unity explorer is not necessary for modding, but is a nice QOL application

Step 3: Unzip Unity explorer
 - There should be a file called UnityExplorer.MelonLoader.IL2CPP.zip 
 - Go into said folder and take out the .dll
 - Access the mod folder (Location will vary for alot of people)
 - Once done put the .dll you took out, and drop it into the mods folder.
 
You are now done! Enjoy searching the game.

## Creating mods
Now on to creating your own mods!

Step 1: Download the [TestMod](https://github.com/LavaGang/TestMod/archive/refs/heads/master.zip) example, after that you can move the master.zip folder to wherever you like, just make sure you can find it in the future!

Step 2: Once unzipped, open the Testmod.csproj file in Visual Studio, do NOT use any other code editors!
- Once done you can get to coding, check out the Scripts directory on how to use some of these features!
- Coding is fairly simple although you do need knowledge of c#
- When you are done coding your amazing new mod, press ctrl + b to build!
- Take the compiled .dll from the build file, and put it in the Mods directory (this will likely be `C:\Program Files (x86)\Steam\steamapps\common\BricksVR\Mods` for you)!
- Any new mods you create will need to be put in the Mods folder.

<!-- LICENSE -->
<br />

## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
<br />

## Contact

Discord - Message us at [BelugaTheAxolotl#2134](https://discordapp.com/users/566770844286844953/), [Darkcryi#7345](https://discordapp.com/users/782864543637700608/) or contact the community through the [BricksVR](https://discord.gg/smD8uxHjxU) Discord server.

Project Link: [https://github.com/zakmasood/BricksVRModding](https://github.com/zakmasood/BricksVRModding)

<br />

## Acknowledgements

* [BricksVR Source Code](https://github.com/d12/bricksvr-game)
* [Readme based off of notbeer's gametest framework readme](https://github.com/notbeer/Gametest-API-Wrapper)

[contributors-shield]: https://img.shields.io/github/contributors/zakmasood/BricksVRModding.svg?style=for-the-badge
[contributors-url]: https://github.com/zakmasood/BricksVRModding/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/zakmasood/BricksVRModding.svg?style=for-the-badge
[forks-url]: https://github.com/https://github.com/zakmasood/BricksVRModding/network/members
[stars-shield]: https://img.shields.io/github/stars/zakmasood/BricksVRModding.svg?style=for-the-badge
[stars-url]: https://github.com/zakmasood/BricksVRModdingstargazers
[issues-shield]: https://img.shields.io/github/issues/zakmasood/BricksVRModding.svg?style=for-the-badge
[issues-url]: https://github.com/zakmasood/BricksVRModding
[license-shield]: https://img.shields.io/github/license/zakmasood/BricksVRModding.svg?style=for-the-badge
[license-url]: https://github.com/zakmasood/BricksVRModding/blob/main/LICENSE
