<p align="center"><img img width="900" height="564" src="" xalign="mid"></p>

<br>

## About
TDPlane is a simple plane shooter survival game. Control the plane to dodge enem attack, attack back at enemy, and collect drops from enem.

## Controls

Arrows to move
ESC to pause

##  Scripts

|  Scripts | Description |
| --- | --- |
| `Movement` | This folder contains all scripts related to movement. Movement limit and boundary are also here.|
| `Object` | This folder has scripts that are related to object in this game. Coin and Heart are here with script to pool object and object lifetime before despawn.|
| `UI`| Contains UI scripts like Life and Menu.|
| `PlayerController.cs` | Handles the movement control of player plane.|
| `Weapon.cs`| This script is used for enemy weapon and also player weapon. It control the firerate and projectile the weapon gonna shoot. Interact with fireratemodifier script to edit firerate.|
|`InvisibleFrame.cs`| This script give plane that got hit a grace period of invisibility.| 
|`AutoShoot.cs`| Script that make object with weapon.cs shoot automatically.|
|`ContainItems.cs`| Script for enemy to be able to have multiple drop items.|
| `EnemySpawner.cs`| Script to spawn random enemy when the game is playing. Has delay and customable X limit range.|
| `GameManager.cs`| Manage many different things inside the game like controlling if the game is playing or not, menuUI interaction, Item and object reset, etc.|
| `TriggerEvent.cs`| This script control the trigger when objects collides with certain objects and then trigger certain action.|
| `Destroyable.cs`| Script when called will destroy game object.|
| `ExplosionBehavior.cs`| Script for setting up explosion animation.|
| `ExplosionEffect.cs`| Script to call explosion.|
| `LifeEditor.cs`| This script add custom editor when using life.cs script on an object.|
| `LookToPlayer.cs`| Script to make enemy weapon target the player.|
| `WeaponSetController.cs`| This script handle the weapon set change when player got upgrade.|



## Contributors
Clifftoven Wicaksono - Game Programmer


