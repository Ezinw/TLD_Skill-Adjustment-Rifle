using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustmentFirestarting
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class FirestartingAdjustmentXP
    {
        public static void Postfix(SkillsManager __instance)
        {
            Skill firestarting = __instance.GetSkill(SkillType.Firestarting);

            if (firestarting != null)
            {
                firestarting.m_TierPoints[1] = Settings.settings.tier2;
                firestarting.m_TierPoints[2] = Settings.settings.tier3;
                firestarting.m_TierPoints[3] = Settings.settings.tier4;
                firestarting.m_TierPoints[4] = Settings.settings.tier5;
            }
        }
    }


    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class SkillAdjustmentFirestarting
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Firestarting.m_LevelWhereTinderNotRequired = Settings.settings.tinder;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[0] = Settings.settings.chance1;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[0] = Settings.settings.duration1;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[0] = Settings.settings.quickstart1;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[1] = Settings.settings.chance2;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[1] = Settings.settings.duration2;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[1] = Settings.settings.quickstart2;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[2] = Settings.settings.chance3;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[2] = Settings.settings.duration3;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[2] = Settings.settings.quickstart3;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[3] = Settings.settings.chance4;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[3] = Settings.settings.duration4;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[3] = Settings.settings.quickstart4;

            __instance.m_Skill_Firestarting.m_BaseSuccessChance[4] = Settings.settings.chance5;
            __instance.m_Skill_Firestarting.m_DurationPercentIncrease[4] = Settings.settings.duration5;
            __instance.m_Skill_Firestarting.m_StartPercentIncrease[4] = Settings.settings.quickstart5;

        }

    }

    

    [HarmonyPatch(typeof(Skill_Firestarting), nameof(Skill_Firestarting.GetTierBenefits))]
    public class FirestartingBenefits
    {

        static void Postfix(ref string __result, Skill_Firestarting __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            // Tinder requirement
            if (currentTier == SkillTiers.Beginner && Settings.settings.tinder == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.tinder == 2   ||
                currentTier == SkillTiers.Novice && Settings.settings.tinder == 1)
            {
                __result += "\nCan start fires without tinder";
            }

            if ((currentTier == SkillTiers.Skilled && Settings.settings.tinder >= 4) ||
                (currentTier == SkillTiers.Expert && Settings.settings.tinder >= 5)  ||
                (currentTier == SkillTiers.Master && Settings.settings.tinder == 6))
            {
                List<string> resultList = __result.Split('\n').ToList();
                List<string> newResult = resultList.Where(benefit => !benefit.Contains("Tinder")).ToList();
                string newResultString = string.Join("\n", newResult);
                __result = newResultString;
            }



            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.duration1 >= 1) { __result += $"\nFires last {Settings.settings.duration1}% longer"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.quickstart1 >= 1) { __result += $"\nFires start {Settings.settings.quickstart1}% faster"; }

            if (currentTier == SkillTiers.Beginner && Settings.settings.chance1 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.chance1}% chance to start fires";
                }
            
            }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.quickstart2 >= 1) { __result += $"\nFires start {Settings.settings.quickstart2}% faster"; }

            if (currentTier == SkillTiers.Novice && Settings.settings.chance2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.chance2}% chance to start fires";
                }

            }
            if (currentTier == SkillTiers.Novice && Settings.settings.duration2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.duration2}% longer";
                }

            }


            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.quickstart3 >= 1) { __result += $"\nFires start {Settings.settings.quickstart3}% faster"; }

            if (currentTier == SkillTiers.Skilled && Settings.settings.chance3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.chance3}% chance to start fires";
                }

            }
            if (currentTier == SkillTiers.Skilled && Settings.settings.duration3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.duration3}% longer";
                }

            }


            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.quickstart4 >= 1) { __result += $"\nFires start {Settings.settings.quickstart4}% faster"; }

            if (currentTier == SkillTiers.Expert && Settings.settings.chance4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.chance4}% chance to start fires";
                }

            }
            if (currentTier == SkillTiers.Expert && Settings.settings.duration4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.duration4}% longer";
                }

            }


            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.chance5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Chance: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.chance1}% chance to start fires";
                }

            }
            if (currentTier == SkillTiers.Master && Settings.settings.duration5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Last: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires last {Settings.settings.duration5}% longer";
                }

            }
            if (currentTier == SkillTiers.Master && Settings.settings.quickstart5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Faster: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Fires start {Settings.settings.quickstart5}% faster";
                }

            }
        }

    }

}
