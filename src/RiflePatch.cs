using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustmentRifle
{
    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
    internal class RifleAdjustment
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[0] = Settings.settings.crit1;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[0] = Settings.settings.repair1;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[0] = Settings.settings.accuracy1;
            __instance.m_Skill_Rifle.m_DamageIncrease[0] = Settings.settings.dmg1;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[0] = Settings.settings.degrade1;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[0] = Settings.settings.aim1;
            __instance.m_Skill_Rifle.m_EffectiveRange[0] = Settings.settings.range1;
            __instance.m_Skill_Rifle.m_StabilityBonus[0] = Settings.settings.stable1;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[1] = Settings.settings.crit2;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[1] = Settings.settings.repair2;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[1] = Settings.settings.accuracy2;
            __instance.m_Skill_Rifle.m_DamageIncrease[1] = Settings.settings.dmg2;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[1] = Settings.settings.degrade2;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[1] = Settings.settings.aim2;
            __instance.m_Skill_Rifle.m_EffectiveRange[1] = Settings.settings.range2;
            __instance.m_Skill_Rifle.m_StabilityBonus[1] = Settings.settings.stable2;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[2] = Settings.settings.crit3;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[2] = Settings.settings.repair3;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[2] = Settings.settings.accuracy3;
            __instance.m_Skill_Rifle.m_DamageIncrease[2] = Settings.settings.dmg3;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[2] = Settings.settings.degrade3;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[2] = Settings.settings.aim3;
            __instance.m_Skill_Rifle.m_EffectiveRange[2] = Settings.settings.range3;
            __instance.m_Skill_Rifle.m_StabilityBonus[2] = Settings.settings.stable3;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[3] = Settings.settings.crit4;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[3] = Settings.settings.repair4;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[3] = Settings.settings.accuracy4;
            __instance.m_Skill_Rifle.m_DamageIncrease[3] = Settings.settings.dmg4;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[3] = Settings.settings.degrade4;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[3] = Settings.settings.aim4;
            __instance.m_Skill_Rifle.m_EffectiveRange[3] = Settings.settings.range4;
            __instance.m_Skill_Rifle.m_StabilityBonus[3] = Settings.settings.stable4;


            __instance.m_Skill_Rifle.m_CriticalHitChanceIncrease[4] = Settings.settings.crit5;
            __instance.m_Skill_Rifle.m_ConditionRepairBonus[4] = Settings.settings.repair5;
            __instance.m_Skill_Rifle.m_AccuracyRangeIncrease[4] = Settings.settings.accuracy5;
            __instance.m_Skill_Rifle.m_DamageIncrease[4] = Settings.settings.dmg5;
            __instance.m_Skill_Rifle.m_ConditionDegradeOnUseReduction[4] = Settings.settings.degrade5;
            __instance.m_Skill_Rifle.m_AimAssistAngleDegrees[4] = Settings.settings.aim5;
            __instance.m_Skill_Rifle.m_EffectiveRange[4] = Settings.settings.range5;
            __instance.m_Skill_Rifle.m_StabilityBonus[4] = Settings.settings.stable5;

        }

    }

    [HarmonyPatch(typeof(Skill_Rifle), nameof(Skill_Rifle.GetTierBenefits))]
    public class RifleBenefits
    {
        static void Postfix(ref string __result, Skill_Rifle __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            //lvl 1
            if (currentTier == SkillTiers.Beginner && Settings.settings.crit1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.crit1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.repair1 >= 1) { __result += $"\n{Settings.settings.repair1} Condition per repair action"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.accuracy1 >= 1) { __result += $"\nAccuracy range increased by {Settings.settings.accuracy1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.dmg1 >= 1) { __result += $"\nDamage increased by {Settings.settings.dmg1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.degrade1 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.degrade1}%"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.aim1 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.aim1:F2}"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.range1 >= 1) { __result += $"\nEffective range increased by {Settings.settings.range1}"; }
            if (currentTier == SkillTiers.Beginner && Settings.settings.stable1 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.stable1}%"; }


            //lvl 2
            if (currentTier == SkillTiers.Novice && Settings.settings.accuracy2 >= 1) { __result += $"\nAccuracy range increased by {Settings.settings.accuracy2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.dmg2 >= 1) { __result += $"\nDamage increased by {Settings.settings.dmg2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.degrade2 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.degrade2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.range2 >= 1) { __result += $"\nEffective range increased by {Settings.settings.range2}"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.crit2 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.crit2}%"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.aim2 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.aim2:F2}"; }
            if (currentTier == SkillTiers.Novice && Settings.settings.stable2 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.stable2}%"; }
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.crit2}%";
                }
            }
            if (currentTier == SkillTiers.Novice && Settings.settings.repair2 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.repair2} Condition per repair action";
                }
            }

            
            //lvl 3
            if (currentTier == SkillTiers.Skilled && Settings.settings.dmg3 >= 1) { __result += $"\nDamage increased by {Settings.settings.dmg3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.degrade3 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.degrade3}%"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.range3 >= 1) { __result += $"\nEffective range increased by {Settings.settings.range3}"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.aim3 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.aim3:F2}"; }
            if (currentTier == SkillTiers.Skilled && Settings.settings.stable3 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.stable3}%"; }


            if (currentTier == SkillTiers.Skilled && Settings.settings.crit3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.crit3}%";
                }
            }
            if (currentTier == SkillTiers.Skilled && Settings.settings.repair3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.repair3} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Skilled && Settings.settings.accuracy3 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.accuracy3}%";
                }
            }

            
            //lvl 4
            if (currentTier == SkillTiers.Expert && Settings.settings.degrade4 >= 1) { __result += $"\nPer-use condition degradation reduced by {Settings.settings.degrade4}%"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.range4 >= 1) { __result += $"\nEffective range increased by {Settings.settings.range4}"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.aim4 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.aim4:F2}"; }
            if (currentTier == SkillTiers.Expert && Settings.settings.stable4 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.stable4}%"; }


            if (currentTier == SkillTiers.Expert && Settings.settings.crit4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.crit4}%";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.repair4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.repair4} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.accuracy4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.accuracy4}%";
                }
            }
            if (currentTier == SkillTiers.Expert && Settings.settings.dmg4 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Damage: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Damage increased by {Settings.settings.dmg4}%";
                }
            }
            

            //lvl 5
            if (currentTier == SkillTiers.Master && Settings.settings.range5 >= 1) { __result += $"\nEffective range increased by {Settings.settings.range5}"; }
            if (currentTier == SkillTiers.Master && Settings.settings.aim5 >= 0.1) { __result += $"\nIncrease aim assist angle degree: {Settings.settings.aim5:F2}"; }
            if (currentTier == SkillTiers.Master && Settings.settings.stable5 >= 1) { __result += $"\nStability Bonus increased by {Settings.settings.stable5}%"; }

            if (currentTier == SkillTiers.Master && Settings.settings.crit5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Critical: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Critical hit chance increased by {Settings.settings.crit5}%";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.repair5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Repair: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"{Settings.settings.repair5} Condition per repair action";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.accuracy5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Accuracy: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Accuracy range increased by {Settings.settings.accuracy5}%";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.dmg5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Damage: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Damage increased by {Settings.settings.dmg5}%";
                }
            }
            if (currentTier == SkillTiers.Master && Settings.settings.degrade5 >= 1)
            {
                int existingBenefitIndex = __result.IndexOf("Degradation: ");
                if (existingBenefitIndex != -1)
                {
                    int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                    if (endOfLineIndex != -1)
                    { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                    __result += $"Per-use condition degradation reduced by {Settings.settings.degrade5}%";
                }
            }
            
        }
    }

}
