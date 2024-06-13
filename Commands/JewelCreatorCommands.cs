using JewelCreator.Database;
using JewelCreator.Utils;
using VampireCommandFramework;

namespace JewelCreator.Commands
{
    internal class JewelCreatorCommands
    {
        [Command("jewelcreator", shortHand: "jc", usage: ".jewelcreator ?", description: "Jewel creator.", adminOnly: true)]
        public static void JewelCreatorCommand(ChatCommandContext ctx, string arg1 = "", string arg2 = "")
        {
            if (DB.EnebledCommand)
            {
                var SteamID = ctx.User.PlatformId;
                var sb = new Il2CppSystem.Text.StringBuilder();
                string message = "";
                if (arg1 == null || string.IsNullOrEmpty(arg1)|| arg1.Equals("?"))
                {
                    sb.Clear();
                    sb.AppendLine($"[.jc] [Jewel Skill] [Skill mods]");
                    sb.AppendLine("This command creates a Jewel with your chosen skill and up to 4 modifiers for that skill. ");
                    sb.AppendLine($"Select a Jewel Skill School");
                    message = ".jc [";
                    foreach (var skill in DB.SkillClass.Keys)
                    {
                        message += "\""+char.ToUpper(skill[0]) + skill.Substring(1) + "\" | ";
                    }
                    message = message.Substring(0, message.Length - 3);
                    message += "]";
                    sb.Append(message);
                    ctx.Reply(sb.ToString());
                    return;
                }else if (DB.SkillClass.TryGetValue(arg1.ToLower(), out var skills))
                {
                    sb.Clear();
                    sb.AppendLine($"Select a Skill");
                    message = ".jc [";
                    foreach (var skill in skills)
                    {
                        message += "\"" + char.ToUpper(skill[0]) + skill.Substring(1) + "\" | ";
                    }
                    message = message.Substring(0, message.Length - 3);
                    message += "]";
                    sb.Append(message);
                    ctx.Reply(sb.ToString());
                    return;
                }
                else if (DB.SkillModList.TryGetValue(arg1.ToLower(), out var Mods))
                {
                    if (arg2 == null || arg2.Equals("?")|| string.IsNullOrEmpty(arg2))
                    {
                        sb.Clear();
                        sb.AppendLine($"Modifiers for [{arg1}]:");
                        for (int i = 1; i <= Mods.Count; i++)
                        {
                            sb.AppendLine($"{i}. {Mods[$"{i}"].Description}");
                            if (sb.Length > 450) { ctx.Reply(sb.ToString()); sb.Clear(); sb.AppendLine(""); }
                        }
                        ctx.Reply(sb.ToString());
                        return;
                    }
                    else if (arg2.Length <= 4 && arg2.Length >= 1)
                    {
                        string[] mods = new string[4];
                        for (int i = 0; i < 4; i++)
                        {
                            if (i < arg2.Length)
                            {
                                mods[i] = arg2[i].ToString();
                            }
                            else
                            {
                                mods[i] = "0";
                            }
                        }
                        bool havedublicat = false;
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (i != j)
                                {
                                    if (mods[i] == mods[j])
                                    {
                                        if (mods[i] != "0")
                                        {
                                            havedublicat = true;
                                        }
                                    }
                                }
                            }
                        }
                        bool canCreate = true;
                        if (!havedublicat)
                        {
                            foreach (var arg in mods)
                            {
                                if (!Mods.ContainsKey(arg))
                                {
                                    if (arg != "0")
                                    {
                                        canCreate = false;
                                        ctx.Reply("Incorrect Modifications!");
                                        return;
                                    }
                                }
                            }
                            if (canCreate)
                            {
                                Helper.CreateJewel(ctx.User, arg1.ToLower(), mods, Mods);
                                ctx.Reply("Jewel created.");
                                return;
                            }
                        }
                        else
                        {
                            ctx.Reply("Modifications can't be dublicated!");
                            return;
                        }
                    }else if (arg2.Length > 4)
                    {
                        ctx.Reply("There cannot be more than 4 modifiers!");
                        return;
                    }
                    else
                    {
                        ctx.Reply("Incorrect parameters.");
                        return;
                    }
                }
                else
                {
                    ctx.Reply("Not found abbility.");
                    return;
                }
            }
            else
            {
                ctx.Reply("This command disabled.");
                return;
            }
        }

    }
}
