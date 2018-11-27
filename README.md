# ItemMagnetPlus

![Icon](https://raw.githubusercontent.com/direwolf420/ItemMagnetPlus/master/icon.png)


Terraria Forum link: https://forums.terraria.org/index.php?threads/itemmagnetplus-customizable-item-magnet.74425/

ItemMagnetPlus adds a single item called "Item Magnet" that does the obvious thing: Sucking in items around you so you don't have to run around and collect them yourself.

Adds:
Item Magnet (and corresponding buff) that
* can be crafted with simple materials (Iron/Lead)
* works while in your inventory (doesn't waste an accessory slot)
* can be toggled on and off
* has adjustable range and item succ speed
* has increased stats after killing bosses
* customizable via config (\Documents\My Games\Terraria\ModLoader\Mod Configs) to fit your playstyle

How to use:
* Left click cycles through its ranges
* Right click shows current range
* Killing bosses improves its stats
* If you want it to either be off or on, there is a config entry called "scale", set it to 0
* If you plan on using this in multiplayer, make sure that everyone has the same config

Progression: (default config)
 Starts with:
 Range = 10 (Blocks in each direction)
 Velocity = 8
 Acceleration = 8

Ends with: (killing Moonlord)
 Range = 120 (one and a half screens)
 Velocity = 32
 Acceleration = 32

 About the config:
* Range starts from 10, but can be as big as you want
* Velocity can also be as big as you want, but acceleration is capped at 40 to prevent items wobbling around the player too much
* Beware of lag when increasing these values, especially range
* If the difference between velocity and acceleration is too big, items will go in circles around you
* If you change the version number, your config might get reset, so don't touch it 


 Changelog:

 v0.1.1: Fixed incompatibility with Even More Modifiers, changed acceleration values (updating will set it back to default)

 v0.1: Initial release