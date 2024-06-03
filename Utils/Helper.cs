using Il2CppSystem.Collections.Generic;
using JewelCreator.Database;
using ProjectM;
using ProjectM.Network;
using Stunlock.Core;
using System.Collections.Concurrent;
using Unity.Entities;
using UnityEngine;

namespace JewelCreator.Utils
{
    internal class Helper
    {
        public static void CreateJewel(User user, string args1, string[] mods, ConcurrentDictionary<string, CreateJevelLegendStruct> Mods)
        {
            var Prefab = NameToPrefab;
            float[] Power = new float[Mods.Count];
            PrefabGUID[] prefabs = new PrefabGUID[Mods.Count];
            for (int i = 0; i < mods.Length; i++)
            {
                if (mods[i] != "0" && Mods.TryGetValue(mods[i], out _))
                {
                    prefabs[i] = Prefab[Mods[mods[i]].Mod];
                    Power[i] = Mods[mods[i]].Power;
                }
                else
                {
                    prefabs[i] = new PrefabGUID(0);
                    Power[i] = 0;
                }
            }
            var createjevelevent = new CreateJewelDebugEventV2()
            {
                AbilityPrefabGuid = Prefab[DB.abilityNames[args1]],
                Equip = false,
                SpellMod1 = prefabs[0],
                SpellMod1Power = Power[0],
                SpellMod2 = prefabs[1],
                SpellMod2Power = Power[1],
                SpellMod3 = prefabs[2],
                SpellMod3Power = Power[2],
                SpellMod4 = prefabs[3],
                SpellMod4Power = Power[3],
                Tier = DB.JewelTier
            };
            Helper.Server.GetExistingSystemManaged<DebugEventsSystem>().CreateJewelEvent(user.Index, ref createjevelevent);
        }
        private static PrefabCollectionSystem PrefabCollectionSystem => Server.GetExistingSystemManaged<PrefabCollectionSystem>();
        private static Dictionary<string, PrefabGUID> NameToPrefab => PrefabCollectionSystem.NameToPrefabGuidDictionary;
        private static World? _serverWorld;
        public static World Server
        {

            get
            {
                if (_serverWorld != null) return _serverWorld;
                _serverWorld = GetWorld("Server")
                    ?? throw new System.Exception("There is no Server world (yet). Did you install a server mod on the client?");
                return _serverWorld;
            }
        }
        public static bool IsServer => Application.productName == "VRisingServer";


        private static World GetWorld(string name)
        {
            foreach (var world in World.s_AllWorlds)
            {
                if (world.Name == name)
                {
                    return world;
                }
            }

            return null;
        }

    }
}
