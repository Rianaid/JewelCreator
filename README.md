# JewelCreator
`Server side only` mod that allows you to create your own jewels with your chosen skill and skill modifier..

<details>
<summary>Changelog</summary>

0.1.2

Thanks [Sens'](https://github.com/pedro-bale/JewelCreator/tree/master) for these changes.
- Added admin only use configuration. 
- Fix internal names types.

0.1.1
- FIx internal error.

0.1.0
- Initial public release of the mod.

</details>

## Installation
* Install [BepInEx](https://v-rising.thunderstore.io/package/BepInEx/BepInExPack_V_Rising/)
* Install [VampireCommandFramework](https://v-rising.thunderstore.io/package/deca/VampireCommandFramework/)
* Extract _JewelCreator.dll_ into _(VRising server folder)/BepInEx/plugins_

## Commands

Mod have only 1 command: `.jewelcreator [SkillName] [Mods]`

`.jewelcreator ?` -give basic help. 

## Configuration
```ini
[JewelCreator]

## Enable command "JewelCreator".
# Setting type: Boolean
# Default value: true
Enabled = true

## Enable command "JewelCreator". only for Admins
# Setting type: Boolean
# Default value: true
AdminOnly = true

## Setup (1-4) tier of jewels.
# Setting type: Int32
# Default value: 4
TierLevel = 4

## Setup (0.0 - 1.0) jewels skill modification power.
# Setting type: Single
# Default value: 1
SkillModPower = 1

```

### Credits

Please vote and suggest your ideas [here](https://ideas.vrisingmods.com/).

[V Rising Mod Community](https://discord.gg/vrisingmods) is the best community of mods for V Rising.

[@Deca](https://github.com/decaprime), thank you for the exceptional frameworks [VampireCommandFramework](https://github.com/decaprime/VampireCommandFramework).

