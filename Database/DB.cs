using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace JewelCreator.Database
{
    internal class DB
    {
        public static float SkillPower = 0;
        public static int JewelTier = 0;
        public static bool EnebledCommand = false;
        public static ConcurrentDictionary<string, ConcurrentDictionary<string, CreateJevelLegendStruct>> SkillModList = new ConcurrentDictionary<string, ConcurrentDictionary<string, CreateJevelLegendStruct>>();
        public static ImmutableDictionary<string, List<string>> SkillClass = ImmutableDictionary.Create<string, List<string>>()
            .Add("blood", new List<string> { "bloodfountain", "bloodrage", "bloodrite", "sanguinecoil", "shadowbolt", "veilofblood" })
            .Add("chaos", new List<string> { "aftershock", "chaosbarrier", "powersurge", "void", "volley", "veilofchaos" })
            .Add("frost", new List<string> { "coldsnap", "crystallance", "frostbarrier", "frostbat", "icenova", "veiloffrost" })
            .Add("illusion", new List<string> { "misttrance", "mosquito", "phantomaegis", "spectralwolf", "wraithspear", "veilofillusion" })
            .Add("storm", new List<string> { "balllightning", "cyclone", "discharge", "lightningwall", "polarityshift", "veilofstorm" })
            .Add("unholy", new List<string> { "corpseexplosion", "corruptedskull", "deathknight", "soulburn", "wardofthedamned", "veilofbones" })
;
        public static ImmutableDictionary<string, string> abilityNames = ImmutableDictionary.Create<string, string>()
            .Add("bloodfountain", "AB_Blood_BloodFountain_AbilityGroup").Add("bloodrage", "AB_Blood_BloodRage_AbilityGroup").Add("bloodrite", "AB_Blood_BloodRite_AbilityGroup").Add("sanguinecoil", "AB_Blood_SanguineCoil_AbilityGroup").Add("shadowbolt", "AB_Blood_Shadowbolt_AbilityGroup").Add("veilofblood", "AB_Vampire_VeilOfBlood_Group")
            .Add("aftershock", "AB_Chaos_Aftershock_Group").Add("chaosbarrier", "AB_Chaos_Barrier_AbilityGroup").Add("powersurge", "AB_Chaos_PowerSurge_AbilityGroup").Add("void", "AB_Chaos_Void_AbilityGroup").Add("volley", "AB_Chaos_Volley_AbilityGroup").Add("veilofchaos", "AB_Vampire_VeilOfChaos_Group")
            .Add("coldsnap", "AB_Frost_ColdSnap_AbilityGroup").Add("crystallance", "AB_Frost_CrystalLance_AbilityGroup").Add("frostbarrier", "AB_FrostBarrier_AbilityGroup").Add("frostbat", "AB_Frost_FrostBat_AbilityGroup").Add("icenova", "AB_Frost_IceNova_AbilityGroup").Add("veiloffrost", "AB_Vampire_VeilOfFrost_Group")
            .Add("misttrance", "AB_Illusion_MistTrance_AbilityGroup").Add("mosquito", "AB_Illusion_Mosquito_AbilityGroup").Add("phantomaegis", "AB_Illusion_PhantomAegis_AbilityGroup").Add("spectralwolf", "AB_Illusion_SpectralWolf_AbilityGroup").Add("wraithspear", "AB_Illusion_WraithSpear_AbilityGroup").Add("veilofillusion", "AB_Vampire_VeilOfIllusion_AbilityGroup")
            .Add("balllightning", "AB_Storm_BallLightning_AbilityGroup").Add("cyclone", "AB_Storm_Cyclone_AbilityGroup").Add("discharge", "AB_Storm_Discharge_AbilityGroup").Add("lightningwall", "AB_Storm_LightningWall_AbilityGroup").Add("polarityshift", "AB_Storm_PolarityShift_AbilityGroup").Add("veilofstorm", "AB_Vampire_VeilOfStorm_Group")
            .Add("corpseexplosion", "AB_Unholy_CorpseExplosion_AbilityGroup").Add("corruptedskull", "AB_Unholy_CorruptedSkull_AbilityGroup").Add("deathknight", "AB_Unholy_DeathKnight_AbilityGroup").Add("soulburn", "AB_Unholy_Soulburn_AbilityGroup").Add("wardofthedamned", "AB_Unholy_WardOfTheDamned_AbilityGroup").Add("veilofbones", "AB_Vampire_VeilOfBones_AbilityGroup");
        public static void inits()
        {

            //----------------------------------------------------BLOOD--------------------------------------------\\
            //----------------------------------------------------BloodFountainMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> BloodFountainMods = SkillModList.GetOrAdd("bloodfountain", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            BloodFountainMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_BloodFountain_FirstImpactApplyLeech", SkillPower, "The initial hit inflicts Leech."));
            BloodFountainMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_BloodFountain_FirstImpactDispell", SkillPower, "Removes all negative effects from self and nearby allies on the initial hit."));
            BloodFountainMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_BloodFountain_FirstImpactFadingSnare", SkillPower, "The initial impact inflicts a fading snare lasting (0,7-1,2)sec."));
            BloodFountainMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_BloodFountain_FirstImpactHealIncrease", SkillPower, "Increases healing of the initial hit by (19-30)%."));
            BloodFountainMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_BloodFountain_RecastLesser", SkillPower, "Recast to conjure a lesser blood fountain. The initial hit heals allies for (23-30)%, the eruption hit heals for (29-40)% and deals damage."));
            BloodFountainMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_BloodFountain_SecondImpactDamageIncrease", SkillPower, "Eruption impact deals (14-25)% bonus damage."));
            BloodFountainMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_BloodFountain_SecondImpactHealIncrease", SkillPower, "Increases healing of the eruption impact by (31-50)%"));
            BloodFountainMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_BloodFountain_SecondImpactKnockback", SkillPower, "The eruption hit knocks enemies back (2-3) meters."));
            BloodFountainMods.TryAdd("9", new CreateJevelLegendStruct("SpellMod_BloodFountain_SecondImpactSpeedBuff", SkillPower, "The eruption hit increases target ally movement speed by 18% for 3s."));
            //----------------------------------------------------BloodRageMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> BloodRageMods = SkillModList.GetOrAdd("bloodrage", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            BloodRageMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_BloodRage_DamageBoost", SkillPower, "Increases physical damage output by (11-15)% during the effect."));
            BloodRageMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_BloodRage_HealOnKill", SkillPower, "Killing an enemy unit during the effect heals you or (1,4-2,5)% of your maximum health."));
            BloodRageMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_BloodRage_IncreaseLifetime", SkillPower, "Increases the duration of the effect by (19-30)%."));
            BloodRageMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_BloodRage_IncreaseMoveSpeed", SkillPower, "Increases movement speed by (4,3-8)%."));
            BloodRageMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_BloodRage_Shield", SkillPower, "Shield self and nearby allies for (45-60)% of your spell power."));
            BloodRageMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_ApplyFadingSnare_Medium", SkillPower, "Inflicts a fading snare on enemies hit lasting (0,9-1,5)sec."));
            BloodRageMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_DispellDebuffs", SkillPower, "Removes all negative effects."));
            //----------------------------------------------------BloodRiteMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> BloodRiteMods = SkillModList.GetOrAdd("bloodrite", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            BloodRiteMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_BloodRite_ApplyFadingSnare", SkillPower, "Inflict a fading snare on enemies hit lasting (1,8-2,5)sec."));
            BloodRiteMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_BloodRite_BonusDamage", SkillPower, "Increases damage by (19-30)%."));
            BloodRiteMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_BloodRite_DamageOnAttack", SkillPower, "When triggered your next primary attack used within 5sec deals (31-50)% bonus damage."));
            BloodRiteMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_BloodRite_HealOnTrigger", SkillPower, "When triggered heals self for (35-50)% of your spell power."));
            BloodRiteMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_BloodRite_IncreaseLifetime", SkillPower, "Increases immaterial duration by (18-25)%."));
            BloodRiteMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_BloodRite_Stealth", SkillPower, "Turn invisible during the immaterial duration."));
            BloodRiteMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_BloodRite_TossDaggers", SkillPower, "Throw up to (4—5) daggers towards nearby enemies when triggered, each dagger dealing (35-50)% damage and inflicting Leech."));
            BloodRiteMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_High", SkillPower, "Increases movement speed when channeling by (24-35)%."));
            //----------------------------------------------------SanguineCoilMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> SanguineCoilMods = SkillModList.GetOrAdd("sanguinecoil", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            SanguineCoilMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_SanguineCoil_AddBounces", SkillPower, "Bounces towards an additional target after first hit dealing (29—40)% of the initial damage or healing. Can bounce back towards owner."));
            SanguineCoilMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_SanguineCoil_BonusDamage", SkillPower, "Increases damage by (10-15)%."));
            SanguineCoilMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_SanguineCoil_BonusHealing", SkillPower, "Increases ally healing by (19--30)%"));
            SanguineCoilMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_SanguineCoil_BonusLifeLeech", SkillPower, "Increases life drain by (31-50)%"));
            SanguineCoilMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_SanguineCoil_KillRecharge", SkillPower, "Lethal attacks restore 1 charge."));
            SanguineCoilMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_SanguineCoil_LeechBonusDamage", SkillPower, "Hitting a target affected by Leech deals (18-25)% bonus damage."));
            SanguineCoilMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_AddCharges", SkillPower, "Increases maximum charges by 1."));
            SanguineCoilMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------ShadowboltMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> ShadowboltMods = SkillModList.GetOrAdd("shadowbolt", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            ShadowboltMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shadowbolt_ExplodeOnHit", SkillPower, "Explodes on hit dealing (19-30)% damage and inflicting Leech on nearby enemies."));
            ShadowboltMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Shadowbolt_LeechBonusDamage", SkillPower, "Hitting a target affected by Leech deals (31-50)% bonus damage."));
            ShadowboltMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shadowbolt_VampiricCurse", SkillPower, "Inflicts Vampiric Curse dealing (158-180)% damage and leeching (19-30)% health after 3sec but reduces damage done by the initial impact by 140%."));
            ShadowboltMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Blood_ConsumeLeechSelfHeal_Small", SkillPower, "Hitting a target affected by Leech heals self for (0,6-1)% of your maximum health."));
            ShadowboltMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_CastRate", SkillPower, "Increases cast rate by (14-25)%."));
            ShadowboltMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Cooldown_Medium", SkillPower, "Reduces cooldown by (8-12)%."));
            ShadowboltMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_KnockbackOnHit_Medium", SkillPower, "Knock targets back (1,9-3) meters on hit."));
            ShadowboltMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------VeilOfBloodMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfBloodMods = SkillModList.GetOrAdd("veilofblood", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfBloodMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_VeilOfBlood_AttackInflictFadingSnare", SkillPower, "Next primary attack inflicts a fading snare lasting (1,4-2)sec."));
            VeilOfBloodMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_VeilOfBlood_DashInflictLeech", SkillPower, "Dashing through an enemy inflicts Leech."));
            VeilOfBloodMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_VeilOfBlood_Empower", SkillPower, "Hitting an enemy affected by Leech increases your physical damage output by (11-15)% for 4s."));
            VeilOfBloodMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_VeilOfBlood_SelfHealing", SkillPower, "Increases maximum healing percentage by (1,3-2)%."));
            VeilOfBloodMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14-25)%."));
            VeilOfBloodMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%."));
            //----------------------------------------------------CHAOS----------------------------------------\\
            //----------------------------------------------------AftershockMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> AftershockMods = SkillModList.GetOrAdd("aftershock", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            AftershockMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Chaos_Aftershock_BonusDamage", SkillPower, "Increases damage by (14-25)%."));
            AftershockMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Chaos_Aftershock_InflictSlowOnProjectile", SkillPower, "The initial wave inflicts a fading snare on enemies hit lasting (1.2-1.8)sec."));
            AftershockMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Chaos_Aftershock_KnockbackArea", SkillPower, "Knocks nearby enemies back (1.9-3) meters on cast."));
            AftershockMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Chaos_ConsumeIgniteAgonizingFlames", SkillPower, "Hitting a target affected by Ignite engulfs the target in agonizing flames dealing (4-6)% damage and healing self for(8-12)% of your speel power 5 times."));
            AftershockMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Cooldown_Medium", SkillPower, "Reduces cooldown by (8-12)%."));
            AftershockMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_IncreaseRange_Medium", SkillPower, "Increases projectile range by (15-25)%."));
            //----------------------------------------------------ChaosBarrierMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> ChaosBarrierMods = SkillModList.GetOrAdd("chaosbarrier", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            ChaosBarrierMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Chaos_Barrier_BonusDamage", SkillPower, "Increaces damage per charge by (9-15)%."));
            ChaosBarrierMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Chaos_Barrier_ConsumeAttackReduceCooldownXTimes", SkillPower, "Absorbing an attack reduces cooldown by (0.5-0.8)sec. from up to 3 attacks."));
            ChaosBarrierMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Chaos_Barrier_ExplodeOnHit", SkillPower, "Expodes on hit dealing (31-50)% damage and inflicting Ignite on nearby enemies."));
            ChaosBarrierMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Chaos_Barrier_LesserPowerSurge", SkillPower, "When fully charged, gain a lesser Power Surge lasting for (3.3-4)sec."));
            ChaosBarrierMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Chaos_Barrier_StunOnHit", SkillPower, "A charged chaos bolt stuns target on hit for (0,8-1,2)sec."));
            ChaosBarrierMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_Low", SkillPower, "Increases movement speed when channeling by (8-12)%."));
            //----------------------------------------------------PowerSurgeMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> PowerSurgeMods = SkillModList.GetOrAdd("powersurge", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            PowerSurgeMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_PowerSurge_AttackSpeed", SkillPower, "Increases attack speed by (6-10)%."));
            PowerSurgeMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_PowerSurge_EmpowerPhysical", SkillPower, "Increases physical damage output by (11-15)% during the effect."));
            PowerSurgeMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_PowerSurge_Haste", SkillPower, "Increases movement speed by (4-8)%."));
            PowerSurgeMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_PowerSurge_IncreaseDurationOnKill", SkillPower, "Lethal attacks during the effect increases diration by 1sec. Can trigger up to (2-4) times."));
            PowerSurgeMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_PowerSurge_Lifetime", SkillPower, "Increases the duration of the effect by (19-30)%"));
            PowerSurgeMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_PowerSurge_RecastDestonate", SkillPower, "Recast to consume the effect triggering an explosion dealing (48-70)% damage and inflicting Ignite."));
            PowerSurgeMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_PowerSurge_Shield", SkillPower, "Shield target for (45-60)% of your spell power."));
            PowerSurgeMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_DispellDebuffs", SkillPower, "Removes all negative effects."));
            //----------------------------------------------------VoidMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VoidMods = SkillModList.GetOrAdd("void", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VoidMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Chaos_Void_BonusDamage", SkillPower, "Increases damage by (11-20)%."));
            VoidMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Chaos_Void_BurnArea", SkillPower, "Flames engulf the area dealing (10-15) damage up to 3 times to enemies in the area."));
            VoidMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Chaos_Void_FragBomb", SkillPower, "Spawns 3 exploding fragments dealing (18-25)% damage and Inflicting Ignite."));
            VoidMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Chaos_Void_ReduceChargeCD", SkillPower, "Increases the rate charges recharge by (11-20)%."));
            VoidMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Chaos_ConsumeIgniteAgonizingFlames", SkillPower, "Hitting a target affected by Ignite engulfs the target in agonizing flames dealing (4-6)% damage and healing self for(8-12)% of your speel power 5 times."));
            VoidMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_TargetAoE_IncreaseRange_Medium", SkillPower, "Increases range by (11-20)%."));
            //----------------------------------------------------VolleyMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VolleyMods = SkillModList.GetOrAdd("volley", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VolleyMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Chaos_Volley_BonusDamage", SkillPower, "Increaces damage by (13-20)%."));
            VolleyMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Chaos_Volley_SecondProjectileBonusDamage", SkillPower, "Hitting a different target with the second projectile deals (31-50)% additional damage."));
            VolleyMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Chaos_ConsumeIgniteAgonizingFlames", SkillPower, "Hitting a target affected by Ignite engulfs the target in agonizing flames dealing (4-6)% damage and healing self for(8-12)% of your speel power 5 times."));
            VolleyMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Cooldown_Medium", SkillPower, "Reduces cooldown by (8-12)%."));
            VolleyMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_KnockbackOnHit_Light", SkillPower, "Knock targets back (0,9-1,5) meters on hit."));
            VolleyMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------VeilOfChaosMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfChaosMods = SkillModList.GetOrAdd("veilofchaos", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfChaosMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_VeilOfChaos_ApplySnareOnExplode", SkillPower, "Inflicts a fading snare lasting (0,9-1,5)sec when an illusion explodes."));
            VeilOfChaosMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_VeilOfChaos_BonusDamageOnExplode", SkillPower, "Increases damage done when an illusion explodes by (14-25)%."));
            VeilOfChaosMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_VeilOfChaos_BonusIllusion", SkillPower, "Spawns a second illusion when recasting dealing (50-80)% of the original damage."));
            VeilOfChaosMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Chaos_ConsumeIgniteAgonizingFlames_OnAttack", SkillPower, "Hitting a target affected by Ignite engulfs the target in agonizing flames dealing (4-6)% damage and healing self for (8-12)% of your spell power 5 times."));
            VeilOfChaosMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14-25)%."));
            VeilOfChaosMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%."));
            //----------------------------------------------------Frost----------------------------------------\\
            //----------------------------------------------------ColdSnapMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> ColdSnapMods = SkillModList.GetOrAdd("coldsnap", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            ColdSnapMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_ColdSnap_BonusAbsorb", SkillPower, "The shield absorbs an additional (25-40)% of your spell power."));
            ColdSnapMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_ColdSnap_BonusDamage", SkillPower, "Increaces damage by (13-20)%."));
            ColdSnapMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_ColdSnap_HasteWhileShielded", SkillPower, "When triggered increases movement speed by (15,3-25)% while the shield last."));
            ColdSnapMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_ColdSnap_Immaterial", SkillPower, "When triggered turn inmmaterial for (0,8-1)sec."));
            ColdSnapMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Frost_IncreaseFreezeWhenChill", SkillPower, "Increases Freeze duration by (0,6-1,2)sec when hitting a Chilled target."));
            ColdSnapMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_FrostWeapon", SkillPower, "When triggered, charges target's weapon with arctic energy. Next primary attack deals (29-40)% bonus damage and inflicts Chill."));
            ColdSnapMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_High", SkillPower, "Increases movement speed when channeling by (24-35)%."));
            //----------------------------------------------------CrystalLanceMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> CrystalLanceMods = SkillModList.GetOrAdd("crystallance", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            CrystalLanceMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_CrystalLance_BonusDamageToFrosty", SkillPower, "Increases damage done Chilled anf Frozen targets by (38-60)%."));
            CrystalLanceMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_CrystalLance_PierceEnemies", SkillPower, "Pierces up to (2-3) targets dealing 50% reduced damage per target."));
            CrystalLanceMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_CastRate", SkillPower, "Increases cast rate by (14-25)%."));
            CrystalLanceMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Frost_IncreaseFreezeWhenChill", SkillPower, "Increases Freeze duration by (0,6-1,2)sec when hitting a Chilled target."));
            CrystalLanceMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Frost_ShieldOnFrosty", SkillPower, "Hitting a chilled or frozen target shields you for (58-80)% of your spell power."));
            CrystalLanceMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------FrostBarrierMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> FrostBarrierMods = SkillModList.GetOrAdd("frostbarrier", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            FrostBarrierMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_FrostBarrier_BonusDamage", SkillPower, "Increaces damage by (11-20)%."));
            FrostBarrierMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_FrostBarrier_BonusSpellPowerOnAbsorb", SkillPower, "Absorbing an attack increases your spell power by (6-10)% for 6sec. Effect stacks up to 3 times."));
            FrostBarrierMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_FrostBarrier_ConsumeAttackReduceCooldownXTimes", SkillPower, "Absorbing an attack reduces coodown by (0,5-0,8)sec from up to 3 attacks."));
            FrostBarrierMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_FrostBarrier_KnockbackOnRecast", SkillPower, "Cone of cold knocks targets back (1,9-3) meters on hit."));
            FrostBarrierMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_FrostBarrier_ShieldOnFrostyRecast", SkillPower, "Hitting a Chilled or Frozen target with the cone of cold shields you for (58-80)% of your spell power."));
            FrostBarrierMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Frost_ConsumeChillIntoFreeze_Recast", SkillPower, "Cone of cold consumes Chill and inflicts Freeze lasting 4(2,5-4)s."));
            FrostBarrierMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_Low", SkillPower, "Increases movement speed when channeling by (8-12)%."));
            //----------------------------------------------------FrostBatMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> FrostBatMods = SkillModList.GetOrAdd("frostbat", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            FrostBatMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_FrostBat_AreaDamage", SkillPower, "The frost inpact blast deals (29-40)% damage to surrounding enemies."));
            FrostBatMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_FrostBat_BonusDamageToFrosty", SkillPower, "Increases damage done to Chilled and Frozen targets by (25-40)%."));
            FrostBatMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_CastRate", SkillPower, "Increases cast rate by (14-25)%."));
            FrostBatMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Frost_SplinterNovaOnFrosty", SkillPower, "Hitting a Chilled or Frozen target shatters the projectile into 8 splinters, each dealing (19-30)% damage and inflicting Chill."));
            FrostBatMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Frost_ShieldOnFrosty", SkillPower, "Hitting a chilled or frozen target shields you for (58-80)% of your spell power."));
            FrostBatMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------IceNovaMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> IceNovaMods = SkillModList.GetOrAdd("icenova", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            IceNovaMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_IceNova_ApplyShield", SkillPower, "The nova shields self and allies for (58-80)% of your spell power."));
            IceNovaMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_IceNova_BonusDamageToFrosty", SkillPower, "Increases damage done to Chelled and Frozen targets by (29-40)%."));
            IceNovaMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_IceNova_RecastLesserNova", SkillPower, "Recast to conjure a lessert ice nova dealing (31-50)% of the original damage."));
            IceNovaMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Cooldown_Medium", SkillPower, "Reduces cooldown by (8-12)%."));
            IceNovaMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_TargetAoE_IncreaseRange_Medium", SkillPower, "Increases range by (11-20)%."));
            //----------------------------------------------------VeilOfFrostMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfFrostMods = SkillModList.GetOrAdd("veiloffrost", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfFrostMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_Frost_ConsumeChillIntoFreeze_OnAttack", SkillPower, "Next primary attack consumes Chill and inflicts Freeze lasting (2,5-4)sec."));
            VeilOfFrostMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_VeilOfFrost_FrostNova", SkillPower, "Next primary attack conjures a nova of frost dealing (31-50)% damage and inflicting Chill on nearby enemies."));
            VeilOfFrostMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_VeilOfFrost_IllusionFrostBlast", SkillPower, "Illusion explodes in a nova of ice dealing (25- 40)% damage and inflicting Chill on nearby enemies."));
            VeilOfFrostMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_VeilOfFrost_ShieldBonus", SkillPower, "of Increases shield absorb amount by (38-60)% your spell power."));
            VeilOfFrostMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14—25)%."));
            VeilOfFrostMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%."));
            //----------------------------------------------------Illusion----------------------------------------\\
            //----------------------------------------------------MistTranceMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> MistTranceMods = SkillModList.GetOrAdd("misttrance", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            MistTranceMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_MIstTrance_DamageOnAttack", SkillPower, "When triggered your next primal attac used within 5sec deal (31-50)% bonus damage."));
            MistTranceMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_MistTrance_FearOnTrigger", SkillPower, "When triggered fears nearby enemies aroung you dor (1,3-2)sec."));
            MistTranceMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_MistTrance_HasteOnTrigger", SkillPower, "When triggered increases movement speed by (14-21)% for 3sec."));
            MistTranceMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_MistTrance_PhantasmOnTrigger", SkillPower, "When triggered grants (2-4) stacks of Phantasm."));
            MistTranceMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_MistTrance_ReduceSecondaryWeaponCD", SkillPower, "When triggered reduces the cooldown of your secondary weapon skill by (50-80)%."));
            MistTranceMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_High", SkillPower, "Increases movement speed when channeling by (24-35)%."));
            MistTranceMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_KnockbackOnHit_Medium", SkillPower, "Knock targets back (1,9-3) meters on hit."));
            MistTranceMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_TravelBuff_IncreaseRange_Medium", SkillPower, "Increases distance traveled by (11-20)%."));
            //----------------------------------------------------MosquitoMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> MosquitoMods = SkillModList.GetOrAdd("mosquito", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            MosquitoMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Mosquito_BonusDamage", SkillPower, "Increases damage by (25-40)%."));
            MosquitoMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Mosquito_BonusFearDuration", SkillPower, "Increases duration of fear by (0,5-0,8)sec."));
            MosquitoMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Mosquito_BonusHealthAndSpeed", SkillPower, "Increases mosquito maximum health by 25-40)%."));
            MosquitoMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Mosquito_ShieldOnSpawn", SkillPower, "Shields nearby allies for (45-60)% of your spell power when the mosquito is summoned."));
            MosquitoMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Mosquito_WispsOnDestroy", SkillPower, "Spawns 3 wisps healing selfor ally for 60% of your spell power when the mosquito explodes."));
            //----------------------------------------------------PhantomAegisMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> PhantomAegisMods = SkillModList.GetOrAdd("phantomaegis", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            PhantomAegisMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_PhantomAegis_ConsumeShieldAndPullAlly", SkillPower, "Recast to consume the barrier from an allied target pulling the ally towards tou."));
            PhantomAegisMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_PhantomAegis_ExplodeOnDestroy", SkillPower, "The barrier explodes if destroyed inflicting a (1,2-1,6)sec Fear on nearby enemies."));
            PhantomAegisMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_PhantomAegis_IncreaseLifetime", SkillPower, "Increasers target speel power by (15-25)% while the barrier last."));
            PhantomAegisMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_PhantomAegis_IncreaseSpellPower", SkillPower, "Increases target spell power by (15-24)% while the barrier last."));
            PhantomAegisMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_DispellDebuffs", SkillPower, "Removes all negative effects."));
            PhantomAegisMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_KnockbackOnHit_Medium", SkillPower, "Knock targets back (1,9-3) meters on hit."));
            PhantomAegisMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_MovementSpeed_Normal", SkillPower, "Increases movement speed by (10-14)%."));
            //----------------------------------------------------SpectralWolfMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> SpectralWolfMods = SkillModList.GetOrAdd("spectralwolf", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            SpectralWolfMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_Illusion_ConsumeWeakenSpawnWisp", SkillPower, "Consumes Weaken to spawn a wisp healing self or ally for (38-60)% of your spell power."));
            SpectralWolfMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Shared_Illusion_WeakenShield", SkillPower, "Hitting a target affected by Weaken grants you a shield absorbing (25-40)% damage based on your spell power stacking up to 3 times."));
            SpectralWolfMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            SpectralWolfMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_SpectralWolf_AddBounces", SkillPower, "Increases maximum bounces by 1."));
            SpectralWolfMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_SpectralWolf_DecreaseBounceDamageReduction", SkillPower, "Reduces damage penalty per bounce by (9-15)%."));
            SpectralWolfMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_SpectralWolf_FirstBounceInflictFadingSnare", SkillPower, "Initial projectile inflicts a fading snare on enemies hit lasting (1,2-1,8)sec."));
            SpectralWolfMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_SpectralWolf_ReturnToOwner", SkillPower, "The wolf returns to you after the last bounce, healing for (85-100)% of your spell power."));
            SpectralWolfMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_SpectralWolf_WeakenApplyXPhantasm", SkillPower, "Hitting a target affected by Weaken grants (2-3) stacks of Phantasm."));
            //----------------------------------------------------WraithSpearMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> WraithSpearMods = SkillModList.GetOrAdd("wraithspear", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            WraithSpearMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_ApplyFadingSnare_Medium", SkillPower, "Inflicts a fading snare on enemies hit lasting (0,9-1,5)sec."));
            WraithSpearMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Shared_Illusion_ConsumeWeakenSpawnWisp", SkillPower, "Consumes Weaken to spawn a wisp healing self or ally for (38-60)% of your spell power."));
            WraithSpearMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Illusion_WeakenShield", SkillPower, "Hitting a target affected by Weaken grants you a shield absorbing (25-40)% damage based on your spell power stacking up to 3 times."));
            WraithSpearMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_IncreaseRange_Medium", SkillPower, "Increases projectile range by (15-25)%."));
            WraithSpearMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_WraithSpear_BonusDamage", SkillPower, "Increases damage by (14-25)%."));
            WraithSpearMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_WraithSpear_ReducedDamageReduction", SkillPower, "Damage penalty per hit is reduced by (6-10)%."));
            WraithSpearMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_WraithSpear_ShieldAlly", SkillPower, "Hitting an ally shields them for (60-90)% of your spell power."));
            //----------------------------------------------------VeilOfIllusionMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfIllusionMods = SkillModList.GetOrAdd("veilofillusion", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfIllusionMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_VeilOfIllusion_AttackInflictFadingSnare", SkillPower, "Next primary attack inflicts a fading snare lasting (1,4-2)sec."));
            VeilOfIllusionMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_VeilOfIllusion_IllusionProjectileDamage", SkillPower, "Illusion projectiles deal (13-20)% damage."));
            VeilOfIllusionMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_VeilOfIllusion_PhantasmOnHit", SkillPower, "Next primary attack grants (3-4) stacks of Phantasm."));
            VeilOfIllusionMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_VeilOfIllusion_RecastDetonate", SkillPower, "Detonate your illusion dealing (24-35)% damage and inflicting weaken in an area on recast."));
            VeilOfIllusionMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14-25)%."));
            VeilOfIllusionMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%"));
            VeilOfIllusionMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_Illusion_WeakenShield_OnAttack", SkillPower, "Hitting an enemy affected by Weaken with your next primary attack grants a shield absorbing (25-40)% damage based on your spell power stacking up to 3 times."));
            //----------------------------------------------------Storm----------------------------------------\\
            //----------------------------------------------------BallLightningMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> BallLightningMods = SkillModList.GetOrAdd("balllightning", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            BallLightningMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_BallLightning_BonusDamage", SkillPower, "Increases damage per shock by (4-6)%."));
            BallLightningMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_BallLightning_DetonateOnRecast", SkillPower, "Recast to detonate the orb early. The explosion deals (31-50)% increased damage."));
            BallLightningMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_BallLightning_Haste", SkillPower, "Increases nearby allies movement speed by (10-15) for 4sec when the orb explodes."));
            BallLightningMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_BallLightning_KnockbackOnExplode", SkillPower, "Knocks enemies back (1,9-3) meters when the orb explodes."));
            BallLightningMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_IncreaseRange_Medium", SkillPower, "Increases projectile range by (15-25)%."));
            BallLightningMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Storm_ConsumeStaticIntoStun_Explode", SkillPower, "Consumes Static to stun enemies for (0,4-0,7)sec when the orb explodes."));
            //----------------------------------------------------CycloneMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> CycloneMods = SkillModList.GetOrAdd("cyclone", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            CycloneMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Cyclone_BonusDamage", SkillPower, "Increases damage by (13-20)%."));
            CycloneMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Cyclone_IncreaseLifetime", SkillPower, "Increases projectile lifetime by (14-25)%."));
            CycloneMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            CycloneMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Shared_Storm_ConsumeStaticIntoStun", SkillPower, "Consumes Static to stun the target for (0,4-0,7)sec."));
            CycloneMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Storm_ConsumeStaticIntoWeaponCharge", SkillPower, "Consumes Static to charge your weapon up to 3 times. Next primary attack deals (19-30)% bonus damage per stack and inflicts Static."));
            //----------------------------------------------------DischargeMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> DischargeMods = SkillModList.GetOrAdd("discharge", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            DischargeMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Discharge_BonusDamage", SkillPower, "Increases damage done by storm shields by (13-20)%."));
            DischargeMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Discharge_Immaterial", SkillPower, "Turn Immaterial for (1-1,6)s if you have 3 Storm Shields active when the effect ends."));
            DischargeMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Discharge_IncreaseStunDuration", SkillPower, "Increases duration of the stun effect by (0,3-0,4)sec."));
            DischargeMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Discharge_RecastDetonate", SkillPower, "Recast to end the effect triggering an explosion dealing (31-50)% damage and knocking nearby enemies back."));
            DischargeMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Discharge_SpellLeech", SkillPower, "Each active storm shield grants (4-6)% spell life leech."));
            DischargeMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_High", SkillPower, "Increases movement speed when channeling by (24-35)%."));
            DischargeMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_Storm_GrantWeaponCharge", SkillPower, "When triggered charge your weapon up to 3 times. Next primary attack deals (19-30)% bonus damage per stack and inflicts Static."));
            //----------------------------------------------------LightningWallMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> LightningWallMods = SkillModList.GetOrAdd("lightningwall", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            LightningWallMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_LightningWall_ApplyShield", SkillPower, "Passing through the wall shields ally target for (45-60)% of your spell power."));
            LightningWallMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_LightningWall_BonusDamage", SkillPower, "Increases damage per hit by (6-12)%."));
            LightningWallMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_LightningWall_ConsumeProjectileWeaponCharge", SkillPower, "Blocking projectiles charges your weapon up to 3 times. Next primary attack deals (19-30)% bonus damage per stack and inflicts Static."));
            LightningWallMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_LightningWall_FadingSnare", SkillPower, "Inflicts a fading snare lasting 1,5(0,9-1,5)s on the initial hit."));
            LightningWallMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_LightningWall_IncreaseMovementSpeed", SkillPower, "Increases movement speed by an additional (13-20)% when passing through the wall."));
            //----------------------------------------------------PolarityShiftMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> PolarityShiftMods = SkillModList.GetOrAdd("polarityshift", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            PolarityShiftMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_ApplyFadingSnare_Medium", SkillPower, "Inflicts a fading snare on enemies hit lasting (0,9-1,5)sec."));
            PolarityShiftMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            PolarityShiftMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Storm_ConsumeStaticIntoWeaponCharge", SkillPower, "Consumes Static to charge your weapon up to 3 times. Next primary attack deals (19-30)% bonus damage per stack and inflicts Static."));
            PolarityShiftMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Storm_PolarityShift_AreaImpactDestination", SkillPower, "Triggers a lightning nova upon reaching the destination dealing (31-50)% damage and inflicting Static on nearby enemies."));
            PolarityShiftMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Storm_PolarityShift_AreaImpactOrigin", SkillPower, "Triggers a lightning nova at the origin location dealing (31-50)% damage and inflicting Static on nearby enemies."));
            //----------------------------------------------------VeilOfStormMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfStormMods = SkillModList.GetOrAdd("veilofstorm", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfStormMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_Storm_ConsumeStaticIntoStun", SkillPower, "Consumes Static to stun the target for (0,4-0,7)sec."));
            VeilOfStormMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14-25)%."));
            VeilOfStormMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%."));
            VeilOfStormMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_VeilOfStorm_AttackInflictFadingSnare", SkillPower, "Next primary attack inflicts a fading snare lasting (1,4-2)sec."));
            VeilOfStormMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_VeilOfStorm_DashInflictStatic", SkillPower, "Dashing through an enemy inflicts Static."));
            VeilOfStormMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_VeilOfStorm_SparklingIllusion", SkillPower, "Your illusion periodically shocks a nearby enemy dealing (10-20)% damage and inflicting Static."));
            //----------------------------------------------------Unholy----------------------------------------\\
            //----------------------------------------------------CorpseExplosionMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> CorpseExplosionMods = SkillModList.GetOrAdd("corpseexplosion", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            CorpseExplosionMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_BonusDamage", SkillPower, "Increases damage by (13-20)%."));
            CorpseExplosionMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_DoubleImpact", SkillPower, "Triggers a second lesser explosion at the same location dealing (31-50)% damage."));
            CorpseExplosionMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_HealMinions", SkillPower, "Heals all allied skeletons hit by (58-80)% of their maximum health and reset their lifetime."));
            CorpseExplosionMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_KillingBlow", SkillPower, "Deals (18-25)% bonus damage to enemies below 30% health, lethal attacks reduce cooldown by (1,7-2,3)sec."));
            CorpseExplosionMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_SkullNova", SkillPower, "Spawns a nova of projectiles from impact location, each projectile dealing (25-40)% damage and inflicting Condemn."));
            CorpseExplosionMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_CorpseExplosion_SnareBonus", SkillPower, "Inflicts a fading snare on enemies hit lasting (1-1,5)sec."));
            CorpseExplosionMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Shared_Cooldown_Medium", SkillPower, "Reduces cooldown by (8-12)%."));
            CorpseExplosionMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Shared_TargetAoE_IncreaseRange_Medium", SkillPower, "Increases range by (11-20)%."));
            //----------------------------------------------------CorruptedSkullMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> CorruptedSkullMods = SkillModList.GetOrAdd("corruptedskull", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            CorruptedSkullMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_CorruptedSkull_BoneSpirit", SkillPower, "Conjures a bone spirit that circles around the target dealing (9-15)% damage and inflicting Condemn to any enemy it hits."));
            CorruptedSkullMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_CorruptedSkull_BonusDamage", SkillPower, "Increases damage by (11-20)%."));
            CorruptedSkullMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_CorruptedSkull_DetonateSkeleton", SkillPower, "Hitting an ally skeleton causes it to explode dealing (48-70)% damage and inflicting Condemn on nearby enemies."));
            CorruptedSkullMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_CorruptedSkull_LesserProjectiles", SkillPower, "Launch two spiraling projectiles instead of one, each projectile deals (35-50)% of the original damage."));
            CorruptedSkullMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_KnockbackOnHit_Medium", SkillPower, "Knock targets back (1,9-3) meters on hit."));
            CorruptedSkullMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Projectile_RangeAndVelocity", SkillPower, "Increases projectile range and speed by (12-24)%."));
            //----------------------------------------------------DeathKnightMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> DeathKnightMods = SkillModList.GetOrAdd("deathknight", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            DeathKnightMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_DeathKnight_BonusDamage", SkillPower, "Increases damage by (14-20)%."));
            DeathKnightMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_DeathKnight_IncreaseLifetime", SkillPower, "Increases Death Knight lifetime by (25-40)%."));
            DeathKnightMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_DeathKnight_LifeLeech", SkillPower, "Damage done by the Death Knight heals you for (18-25)% of damage done."));
            DeathKnightMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_DeathKnight_MaxHealth", SkillPower, "Increases Death Knight health by (25-40)%."));
            DeathKnightMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_DeathKnight_SkeletonMageOnLifetimeEnded", SkillPower, "Summon a Skeleton Mage with (25-40)% increased power when the Death Knight lifetime expire."));
            DeathKnightMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_DeathKnight_SnareEnemiesOnSummon", SkillPower, "Inflicts a fading snare lasting (1,2-1,7)sec on enemies nearby the summoning location."));
            //---------------------------------------------------SoulburnMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> SoulburnMods = SkillModList.GetOrAdd("soulburn", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            SoulburnMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_DispellDebuffs_Self", SkillPower, "Removes all negative effects from self when cast."));
            SoulburnMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_Soulburn_BonusDamage", SkillPower, "Increases damage by (10-16)%."));
            SoulburnMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_Soulburn_BonusLifeDrain", SkillPower, "Increases life drain by (8-15)%."));
            SoulburnMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_Soulburn_ConsumeSkeletonEmpower", SkillPower, "Consume up to 3 allied skeletons increasing your spell and physical power by (7-12)% per skeleton for 8s."));
            SoulburnMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Soulburn_ConsumeSkeletonHeal", SkillPower, "Consume up to 3 allied skeletons healing you for (63-100)% of your spell power per skeleton."));
            SoulburnMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Soulburn_IncreasedSilenceDuration", SkillPower, "Increases silence duration by (0,4-0,5)sec."));
            SoulburnMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_Soulburn_IncreaseTriggerCount", SkillPower, "Increases targets hit by 1."));
            SoulburnMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_Soulburn_ReduceCooldownOnSilence", SkillPower, "Reduces cooldown by (0,5-0,8)sec for each target silenced."));
            //----------------------------------------------------WardOfTheDamnedMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> WardOfTheDamnedMods = SkillModList.GetOrAdd("wardofthedamned", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            WardOfTheDamnedMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_Shared_IncreaseMoveSpeedDuringChannel_Low", SkillPower, "Increases movement speed when channeling by (8-12)%."));
            WardOfTheDamnedMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_BonusDamageOnRecast", SkillPower, "Increases damage done by the recast attack by (13-20)."));
            WardOfTheDamnedMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_DamageMeleeAttackers", SkillPower, "Melee attackers take (31-50)% damage when striking the barrier."));
            WardOfTheDamnedMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_EmpowerSkeletonsOnRecast", SkillPower, "Empower allied skeletons hit by the recast for increasing their damage output by (19-30)% for 8sec."));
            WardOfTheDamnedMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_HealOnAbsorbProjectile", SkillPower, "Absorbing a projectile heals you for (30-45)% your spell power."));
            WardOfTheDamnedMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_KnockbackOnRecast", SkillPower, "The recast attack knocks targets back (1,9-3) meters on hit."));
            WardOfTheDamnedMods.TryAdd("7", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_MightSpawnMageSkeleton", SkillPower, "(25-40)% chance to spawn a Skeleton Mage instead ofa Skeleton Warrior when triggered."));
            WardOfTheDamnedMods.TryAdd("8", new CreateJevelLegendStruct("SpellMod_WardOfTheDamned_ShieldSkeletonsOnRecast", SkillPower, "Shields allied skeletons hit by the recast for (75-120)% of your spell power. The shield last for 4s."));
            //----------------------------------------------------VeilOfBonesMods----------------------------------------\\
            ConcurrentDictionary<string, CreateJevelLegendStruct> VeilOfBonesMods = SkillModList.GetOrAdd("veilofbones", new ConcurrentDictionary<string, CreateJevelLegendStruct>());
            VeilOfBonesMods.TryAdd("1", new CreateJevelLegendStruct("SpellMod_VeilOfBones_BonusDamageBelowTreshhold", SkillPower, "Increases damage done to targets below critical health by (25-40)%."));
            VeilOfBonesMods.TryAdd("2", new CreateJevelLegendStruct("SpellMod_VeilOfBones_DashHealMinions", SkillPower, "Heals all allied skeletons you dash through by (58-80)% oftheir maximum health and reset their lifetime."));
            VeilOfBonesMods.TryAdd("3", new CreateJevelLegendStruct("SpellMod_VeilOfBones_DashInflictCondemn", SkillPower, "Dashing through an enemy inflicts Condemn."));
            VeilOfBonesMods.TryAdd("4", new CreateJevelLegendStruct("SpellMod_VeilOfBones_SpawnSkeletonMage", SkillPower, "Striking an enemy summons a Skeleton Mage instead of Skeleton Warrior."));
            VeilOfBonesMods.TryAdd("5", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BonusDamageOnPrimary", SkillPower, "Increases damage of next primary attack by (14-25)%."));
            VeilOfBonesMods.TryAdd("6", new CreateJevelLegendStruct("SpellMod_Shared_Veil_BuffAndIllusionDuration", SkillPower, "Increases elude duration by (13-20)%."));
        }
    }
}
