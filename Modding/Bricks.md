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
    Bricks, good ol' bricks!
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
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#all-about-the-bricks">All About the Bricks</a>
    </li>
    <li>
      <a href="#setup">Setup</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

## All About the Bricks

Bricks, bricks, brickity brick. Bricks it's in the name of the game, it would be nothing about the glorius bricks! The manipulation of bricks is usual goal for those beginning their modding journey. So, I'll help you through this journey. Let's begin!

Here's a few requirements:
* A computer
* A Mod setup
* A VR Headset (OPTIONAL)

## Setup
So... Let's get out our TestMod, make sure to change it to look like this, we don't need the extra clutter.
```cs
using MelonLoader;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "TestMod"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for Testing"; // Description for the Mod.  (Set as null if none)
        public const string Author = "TestAuthor"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TestMod : MelonMod
    {
        public override void OnUpdate() // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {

        }
}
```

# Two Components, One Truth.
The source-code of BricksVR can be, strange, at times. Anyway there are two crucial scripts that you must run for a Brick to be created properly.

- `BrickServerInterface.cs`
- `BrickSwapper.cs`

## BrickServerInterface.cs

The BrickServerInterface is a pathway to many abilities some consider unnatural. The purpose of this script is to interact with BricksVR's API. It can be used to change the brick amount in the room. It can be used to either remove or increase the count.

This example will add a brick to the API, this won't actually add a brick into the game however it will increase the number of bricks in the recent rooms list.
```cs
    public override void OnUpdate() // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
    {
        //When the user presses p the following code will run
        if(!Input.GetKeyDown("p")) return;
        var realtime = GameObject.Find("MetaObjects/Realtime").GetComponent<Realtime>();

        var brick = new NormcoreRPC.Brick { uuid = "test", matId = 93, color = 23, type = "2x2", pos = new Vector3(0, 0, 0), rot = new Quaternion(0f, 0f, 0f, 0f), usingNewColor = false, headClientId = -1, usingHeadStuff = true };

        BrickServerInterface.GetInstance().sendBrick(brick, realtime);
    }
```

Here's another example on how you would remove one of these bricks.

```cs
    public override void OnUpdate() // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
    {
        //When the user presses p it will send a request to remove the brick
        if(!Input.GetKeyDown("p")) return;
        var realtime = GameObject.Find("MetaObjects/Realtime").GetComponent<Realtime>();

        BrickServerInterface.GetInstance().RemoveBrick("test", realtime);
    }
```

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
