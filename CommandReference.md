_<sup>Copied from the original uEssentials Repository</sup>_

# Commands

> **TIP**: Use **Ctrl + F _(⌘ + F on mac)_** to find a specific command.
**Argument syntax: ```<optional> [required]```**

## Quick links:
**[A](#a)**

[Ascend](#ascend)
<br><br>

**[B](#b)**

[Back](#back)  |  [Boom](#boom)  
<br><br>

**[C](#c)**

[Clear](#clear)  |  [Clearinventory](#clearinventory)  |  [Createkit](#createkit)  
<br><br>

**[D](#d)**

[Deletekit](#deletekit)  |  [Delwarp](#delwarp)  |  [Descend](#descend)  |  [Dropkit](#dropkit)  
<br><br>

**[E](#e)**

[Editkit](#editkit)  |  [Essentials](#essentials)  |  [Experience](#experience)  
<br><br>

**[F](#f)**


[Freeze](#freeze)  |  [Home](#home)
<br><br>

**[I](#i)**


[Item](#item)  |  [Itemfeatures](#itemfeatures)  |  [Iteminfo](#iteminfo)  
<br><br>

**[J](#j)**


[Jump](#jump)  
<br><br>

**[K](#k)**


[Kickall](#kickall)  |  [Kill](#kill)  |  [Killanimals](#killanimals)  |  [Killzombies](#killzombies)  |  [Kit](#kit)  |  [Kits](#kits)  |  
<br><br>

**[M](#m)**


[Maxskills](#maxskills)  
<br><br>

**[O](#o)**


[Online](#online)  
<br><br>

**[P](#p)**


[Ping](#ping)  |  [Poll](#poll)  |  [Position](#position)  |  [Pvp](#pvp)  
<br><br>

**[R](#r)**


[Refuelgenerator](#refuelgenerator)  |  [Refuelvehicle](#refuelvehicle)  |  [Repair](#repair)  |  [Repairvehicle](#repairvehicle)  |  [Reply](#reply)  |  [Reputation](#reputation)  |  [Requesturl](#requesturl)  |  [Resetplayer](#resetplayer)  |  [Respawnanimals](#respawnanimals)  |  [Respawnitems](#respawnitems)  |  [Respawnvehicles](#respawnvehicles)  | [Respawnzombies](#respawnzombies)  
<br><br>

**[S](#s)**


[Setwarp](#setwarp)  |  [Shutdown](#shutdown)  |  [Skill](#skill)  |  [Spawnitem](#spawnitem)  |  [Spawnvehicle](#spawnvehicle)  |  [Spypm](#spypm)  |  [Sudo](#sudo)  |  [Suicide](#suicide)  |  [Systemtime](#systemtime)  
<br><br>

**[T](#t)**


[Tell](#tell)  |  [Tellraw](#tellraw)  |  [Tp](#tp)  |  [Tpa](#tpa)  |  [Tpall](#tpall)  |  [Tps](#tps)  |  
<br><br>

**[U](#u)**

[Unfreeze](#unfreeze)
<br>
<br>

**[V](#v)**


[Vehicle](#vehicle)  |  [Vehiclefeatures](#vehiclefeatures)  |  [Vote](#vote)  
<br>
<br>

**[W](#w)**

[Warp](#warp)  |  [Warps](#warps)
<br>
<br>


## Commands
<br>

### A
--- 
#### /ascend
**Description:** Ascend X "meters".</code><br>
**Usage** <code>/ascend [amount]</code><br>
**Aliases:**<br>
\- <code>/asc</code><br>
**Permissions**<br>
\- <code>/essentials.command.ascend</code><br>
<br>

### B
--- 
#### /back
**Description:** Return to position of your death.</code><br>
**Aliases:**<br>
\- <code>/ret</code><br>
**Permissions**<br>
\- <code>/essentials.command.back</code><br>
<br>

#### /boom
**Description:** Create an explosion on player's/given position</code><br>
**Usage** <code>/boom [player | * | x, y, z]</code><br>
**Aliases:**<br>
\- <code>/explode</code><br>
**Permissions**<br>
\- <code>/essentials.command.boom</code><br>
<br>

### C
--- 
#### /clear
**Description:** Clear things</code><br>
**Usage** <code>/clear [i = items, ev = empty vehicles] <distance></code><br>
**Permissions**<br>
\- <code>/essentials.command.clear</code><br>
<br>

#### /clearinventory
**Description:** Clear your/player's inventory</code><br>
**Usage** <code>/clearinventory <player | *></code><br>
**Aliases:**<br>
\- <code>/ci</code><br>
**Permissions**<br>
\- <code>/essentials.command.clearinventory</code><br>
\- <code>/essentials.command.clearinventory.all</code> **(Allow to clear inventory of everyone)** <br>
\- <code>/essentials.command.clearinventory.other</code> **(Allow to clear inventory of another player)** <br>
<br>

#### /createkit
**Description:** Create a kit using your inventory items.</code><br>
**Usage** <code>/createkit [name] \<cooldown\> <resetCooldownWhenDie> <cost></code><br>
**Aliases:**<br>
\- <code>/ckit</code><br>
**Permissions**<br>
\- <code>/essentials.command.createkit</code><br>
<br>

### D
--- 
#### /deletekit
**Description:** Delete a kit.</code><br>
**Usage** <code>/deletekit [name]</code><br>
**Aliases:**<br>
\- <code>/dkit</code><br>
**Permissions**<br>
\- <code>/essentials.command.deletekit</code><br>
<br>

#### /delwarp
**Description:** Delete an existing warp</code><br>
**Usage** <code>/delwarp [warp_name]</code><br>
**Aliases:**<br>
\- <code>/deletewarp</code><br>
**Permissions**<br>
\- <code>/essentials.command.delwarp</code><br>
<br>

#### /descend
**Description:** Descend X "meters".</code><br>
**Usage** <code>/descend [amount]</code><br>
**Aliases:**<br>
\- <code>/desc</code><br>
**Permissions**<br>
\- <code>/essentials.command.descend</code><br>
<br>

#### /dropkit
**Description:** Drop a kit at given player/position</code><br>
**Usage** <code>/dropkit [kit] <player | x y z></code><br>
**Aliases:**<br>
\- <code>/dk</code><br>
**Permissions**<br>
\- <code>/essentials.command.dropkit</code><br>
<br>

### E
--- 
#### editkit
**Description:** Edit a kit</code><br>
**Usage** <code>/editkit [kit] [view | additem | delitem | set]</code><br>
**Aliases:**<br>
\- <code>/ekit</code><br>
**Permissions**<br>
\- <code>/essentials.command.editkit</code><br>
<br>

#### /essentials
**Description:** Plugin commands</code><br>
**Usage** <code>/essentials <commands/help/info/reload/savedata></code><br>
**Aliases:**<br>
\- <code>/ess</code><br>
\- <code>/?</code><br>
\- <code>/uessentials</code><br>
**Permissions**<br>
\- <code>/essentials.command.essentials</code><br>
<br>

#### /experience
**Description:** Give experience to you/player</code><br>
**Usage** <code>/experience [amount] <target/*></code><br>
**Aliases:**<br>
\- <code>/exp</code><br>
**Permissions**<br>
\- <code>/essentials.command.experience</code><br>
<br>

### F
--- 
#### /freeze
**Description:** Freeze a player/everyone</code><br>
**Usage** <code>/freeze [player/*]</code><br>
**Permissions**<br>
\- <code>/essentials.command.freeze</code><br>
<br>

### H
--- 
#### /home
**Description:** Teleport to your bed.</code><br>
**Aliases:**<br>
\- <code>/h</code><br>
**Permissions**<br>
\- <code>/essentials.command.home</code><br>
<br>

### I
--- 
#### /item
**Description:** Give an item to you/another player</code><br>
**Usage** <code>/item [item] <amount> or [player|* = all] [item] [amount]</code><br>
**Aliases:**<br>
\- <code>/i</code><br>
**Permissions**<br>
\- <code>/essentials.command.item</code><br>
<br>

#### /itemfeatures
**Description:** Item features</code><br>
**Usage** <code>/itemfeatures [autoreload | autorepair | all] [on | off]</code><br>
**Aliases:**<br>
\- <code>/if</code><br>
**Permissions**<br>
\- <code>/essentials.command.itemfeatures</code><br>
<br>

#### /iteminfo
**Description:** See information on an item.</code><br>
**Usage** <code>/iteminfo <item id></code><br>
**Aliases:**<br>
\- <code>/ii</code><br>
**Permissions**<br>
\- <code>/essentials.command.iteminfo</code><br>
<br>

### J
--- 
#### /jump
**Description:** Teleport to a position that you are looking towards.</code><br>
**Usage** <code>/jump <max_distance></code><br>
**Permissions**<br>
\- <code>/essentials.command.jump</code><br>
<br>

### K
--- 
#### /kickall
**Description:** Kick all players</code><br>
**Usage** <code>/kickall <reason></code><br>
**Permissions**<br>
\- <code>/essentials.command.kickall</code><br>
<br>

#### /kill
**Description:** Kill a player</code><br>
**Usage** <code>/kill [player/*]</code><br>
**Permissions**<br>
\- <code>/essentials.command.kill</code><br>
<br>

#### /killanimals
**Description:** Kill all animals</code><br>
**Aliases:**<br>
\- <code>/clearanimals</code><br>
**Permissions**<br>
\- <code>/essentials.command.killanimals</code><br>
<br>

#### /killzombies
**Description:** Kill all zombies</code><br>
**Aliases:**<br>
\- <code>/clearzombies</code><br>
**Permissions**<br>
\- <code>/essentials.command.killzombies</code><br>
<br>

#### /kit
**Description:** Get a kit</code><br>
**Usage** <code>/kit [kit_name] <player | *></code><br>
**Permissions**<br>
\- <code>/essentials.command.kit</code><br>
<br>

#### /kits
**Description:** View available kits</code><br>
**Permissions**<br>
\- <code>/essentials.command.kits</code><br>
<br>

### M
--- 
#### /maxskills
**Description:** Set to max level all of your/player skills</code><br>
**Usage** <code>/maxskills <overpower[true|false]> <player | *></code><br>
**Permissions**<br>
\- <code>/essentials.command.maxskills</code><br>
<br>

### O
--- 
#### /online
**Description:** View the number of online players</code><br>
**Permissions**<br>
\- <code>/essentials.command.online</code><br>
<br>

### P
--- 
#### /ping
**Description:** View your/player ping</code><br>
**Usage** <code>/ping <player></code><br>
**Permissions**<br>
\- <code>/essentials.command.ping</code><br>
<br>

#### /poll
**Description:** Start/Stop a poll</code><br>
**Usage** <code>/poll [start | stop | list | info]</code><br>
**Permissions**<br>
\- <code>/essentials.command.poll</code><br>
<br>

#### /position
**Description:** View your/another player position.</code><br>
**Usage** <code>/position <player></code><br>
**Aliases:**<br>
\- <code>/pos</code><br>
\- <code>/coords</code><br>
**Permissions**<br>
\- <code>/essentials.command.position</code><br>
<br>

#### /pvp
**Description:** Enable or disable server pvp.</code><br>
**Usage** <code>/pvp [on|off]</code><br>
**Permissions**<br>
\- <code>/essentials.command.pvp</code><br>
<br>

### R
--- 
#### /refuelgenerator
**Description:** Refuel generators in specific radius (default 20).</code><br>
**Usage** <code>/refuelgenerator <radius> <percentage></code><br>
**Aliases:**<br>
\- <code>/refuelgen</code><br>
**Permissions**<br>
\- <code>/essentials.command.refuelgenerator</code><br>
<br>

#### /refuelvehicle
**Description:** Refuel current/all vehicles</code><br>
**Usage** <code>/refuelvehicle <all></code><br>
**Aliases:**<br>
\- <code>/refuel</code><br>
**Permissions**<br>
\- <code>/essentials.command.refuelvehicle</code><br>
<br>

#### /repair
**Description:** Repair all items in your inventory.</code><br>
**Aliases:**<br>
\- <code>/fix</code><br>
**Permissions**<br>
\- <code>/essentials.command.repair</code><br>
<br>

#### /repairvehicle
**Description:** Repair current/all vehicle</code><br>
**Usage** <code>/repairvehicle <all></code><br>
**Aliases:**<br>
\- <code>/repairveh</code><br>
\- <code>/repv</code><br>
**Permissions**<br>
\- <code>/essentials.command.repairvehicle</code><br>
<br>

#### /reply
**Description:** Reply to the most recent private message</code><br>
**Usage** <code>/reply [message]</code><br>
**Aliases:**<br>
\- <code>/r</code><br>
**Permissions**<br>
\- <code>/essentials.command.reply</code><br>
<br>

#### /reputation
**Description:** Give reputation to you/player</code><br>
**Usage** <code>/reputation [amount] <target/*></code><br>
**Aliases:**<br>
\- <code>/rep</code><br>
**Permissions**<br>
\- <code>/essentials.command.reputation</code><br>
<br>

#### /requesturl
**Description:** Request player to open an URL.</code><br>
**Usage** <code>/requesturl [player/*] [message] [url]</code><br>
**Aliases:**<br>
\- <code>/requrl</code><br>
**Permissions**<br>
\- <code>/essentials.command.requesturl</code><br>
<br>

#### /resetplayer
**Description:** Reset all player data.</code><br>
**Usage** <code>/resetplayer [player/playerid]</code><br>
**Permissions**<br>
\- <code>/essentials.command.resetplayer</code><br>
<br>

#### /respawnanimals
**Description:** Respawn all animals</code><br>
**Permissions**<br>
\- <code>/essentials.command.respawnanimals</code><br>
<br>

#### /respawnitems
**Description:** Respawn all items.</code><br>
**Permissions**<br>
\- <code>/essentials.command.respawnitems</code><br>
<br>

#### /respawnvehicles
**Description:** Respawn all vehicles.</code><br>
**Usage** <code>/respawnvehicles <maximum></code><br>
**Permissions**<br>
\- <code>/essentials.command.respawnvehicles</code><br>
<br>

#### /respawnzombies
**Description:** Respawn all zombies</code><br>
**Permissions**<br>
\- <code>/essentials.command.respawnzombies</code><br>
<br>

### S
--- 
#### /setwarp
**Description:** Set a warp.</code><br>
**Usage** <code>/setwarp [warp_name] <x> <y> <z></code><br>
**Permissions**<br>
\- <code>/essentials.command.setwarp</code><br>
<br>

#### /shutdown
**Description:** Shutdown server</code><br>
**Usage** <code>/shutdown <delay in seconds> <reason></code><br>
**Aliases:**<br>
\- <code>/stop</code><br>
**Permissions**<br>
\- <code>/essentials.command.shutdown</code><br>
<br>

#### /skill
**Description:** Edit skill of a player|you</code><br>
**Usage** <code>/skill [skill] [value|max] or [player|*] [skill] [value|max]</code><br>
**Permissions**<br>
\- <code>/essentials.command.skill</code><br>
<br>

#### /spawnitem
**Description:** Spawn an item at given position</code><br>
**Usage** <code>/spawnitem [item] <amount> <x> <y> <z></code><br>
**Aliases:**<br>
\- <code>/dropitem</code><br>
**Permissions**<br>
\- <code>/essentials.command.spawnitem</code><br>
<br>

#### /spawnvehicle
**Description:** Spawn a vehicle on player's/given position</code><br>
**Usage** <code>/spawnvehicle [id] [player] or [x] [y] [z]</code><br>
**Aliases:**<br>
\- <code>/spawnveh</code><br>
**Permissions**<br>
\- <code>/essentials.command.spawnvehicle</code><br>
<br>

#### /spypm
**Description:** Allows you to see private messages.</code><br>
**Permissions**<br>
\- <code>/essentials.command.spypm</code><br>
<br>

#### /sudo
**Description:** Make player or console execute a command</code><br>
**Usage** <code>/sudo [player/*/*console*/]</code><br>
**Permissions**<br>
\- <code>/essentials.command.sudo</code><br>
<br>

#### /suicide
**Description:** Kill yourself</code><br>
**Permissions**<br>
\- <code>/essentials.command.suicide</code><br>
<br>

#### /systemtime
**Description:** Show system time.</code><br>
**Aliases:**<br>
\- <code>/stime</code><br>
**Permissions**<br>
\- <code>/essentials.command.systemtime</code><br>
<br>

### T
--- 
#### /tell
**Description:** Send private message to a player</code><br>
**Usage** <code>/tell [player] [message]</code><br>
**Aliases:**<br>
\- <code>/msg</code><br>
\- <code>/pm</code><br>
**Permissions**<br>
\- <code>/essentials.command.tell</code><br>
<br>

#### /tellraw
**Description:** Send raw message to a player.</code><br>
**Usage** <code>/tellraw [player/*console*] [message]</code><br>
**Permissions**<br>
\- <code>/essentials.command.tellraw</code><br>
<br>

#### /tp
**Description:** Teleport to a player or place.</code><br>
**Usage** <code>/tp [player|place|x y z] or [player] [player|place|x y z]</code><br>
**Permissions**<br>
\- <code>/essentials.command.tp</code><br>
<br>

#### /tpa
**Usage** <code>/tpa [player/accept/deny/cancel]</code><br>
**Permissions**<br>
\- <code>/essentials.command.tpa</code><br>
\- <code>/essentials.command.tpa.send</code><br>
\- <code>/essentials.command.tpa.accept</code><br>
\- <code>/essentials.command.tpa.deny</code><br>
\- <code>/essentials.command.tpa.cancel</code><br>
<br>

#### /tpall
**Description:** Teleport all players to a player/position</code><br>
**Usage** <code>/tpall [player/x y z]</code><br>
**Permissions**<br>
\- <code>/essentials.command.tpall</code><br>
<br>

#### /tps
**Description:** Show tps.</code><br>
**Permissions**<br>
\- <code>/essentials.command.tps</code><br>
<br>


### U
--- 
#### /unfreeze
**Description:** Unfreeze a player/everyone</code><br>
**Usage** <code>/unfreeze [player/*]</code><br>
**Permissions**<br>
\- <code>/essentials.command.unfreeze</code><br>
<br>


### V
--- 
#### /vehicle
**Usage** <code>/vehicle [vehicle] or [player|* = all] [vehicle]</code><br>
**Aliases:**<br>
\- <code>/v</code><br>
**Permissions**<br>
\- <code>/essentials.command.vehicle</code><br>
<br>

#### /vehiclefeatures
**Description:** Vehicle features</code><br>
**Usage** <code>/vehiclefeatures [autorefuel | autorepair | all] [on|off]</code><br>
**Aliases:**<br>
\- <code>/vehfeatures</code><br>
\- <code>/vf</code><br>
**Permissions**<br>
\- <code>/essentials.command.vehiclefeatures</code><br>
<br>

#### /vote
**Description:** Vote in a poll</code><br>
**Usage** <code>/vote [yes/no] [poll_name]</code><br>
**Permissions**<br>
\- <code>/essentials.command.vote</code><br>

> Note: *If your server uses a voting system like 'IceVoteUI' then you will need to disable this command in order to use that plugin.*

<br>


### W
--- 
#### /warp
**Description:** Teleport you to given warp.</code><br>
**Usage** <code>/warp [warp_name]</code><br>
**Permissions**<br>
\- <code>/essentials.command.warp</code><br> 
<br>

#### /warps
**Description:** View available warps</code><br>
**Permissions**<br>
\- <code>/essentials.command.warps</code><br>
<br>
