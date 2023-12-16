using ModSettings;
using System.Reflection;

namespace SkillAdjustmentFirestarting
{
    internal class Settings : JsonModSettings
    {
        [Section("Fire Starting")]
        [Name("Adjust fire starting skill?")]
        private readonly bool Fire = true;

        //Tinder Requirement
        [Name("No Tinder Required")]
        [Description("Level when tinder is no longer required.(Game default = 3) (6 = Tinder is always required) - Requires game reload to take effect")]
        [Slider(1, 6)]
        public int tinder = 3;

        //lvl1
        [Name("Fire Starting Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool Fire1 = false;

        [Name("          Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 40%)")]
        [Slider(0, 100)]
        public int chance1 = 40;

        [Name("          Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 0%)")]
        [Slider(0, 200)]
        public int duration1 = 0;

        [Name("          Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickstart1 = 0;

        //lvl2
        [Name("Fire Starting Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool Fire2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 20)")]
        [Slider(20, 500)]
        public int tier2 = 20;

        [Name("          Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 55%)")]
        [Slider(0, 100)]
        public int chance2 = 55;

        [Name("          Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 10%)")]
        [Slider(0, 200)]
        public int duration2 = 10;

        [Name("          Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickstart2 = 0;

        //lvl3
        [Name("Fire Starting Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool Fire3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 50)")]
        [Slider(50, 500)]
        public int tier3 = 50;

        [Name("          Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 65%)")]
        [Slider(0, 100)]
        public int chance3 = 65;

        [Name("          Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 10%)")]
        [Slider(0, 200)]
        public int duration3 = 10;

        [Name("          Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickstart3 = 0;

        //lvl4
        [Name("Fire Starting Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool Fire4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 100)")]
        [Slider(100, 1000)]
        public int tier4 = 100;

        [Name("          Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 75%)")]
        [Slider(0, 100)]
        public int chance4 = 75;

        [Name("          Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 25%)")]
        [Slider(0, 200)]
        public int duration4 = 25;

        [Name("          Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 0%)")]
        [Slider(0, 100)]
        public int quickstart4 = 0;

        //lvl5
        [Name("Fire Starting Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes require game reload to take effect")]
        [Choice("+", "-")]
        public bool Fire5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 200)")]
        [Slider(200, 1000)]
        public int tier5 = 200;

        [Name("          Bonus Fire Starting")]
        [Description("Increase % chance to start a fire.(Game default = 90%)")]
        [Slider(0, 100)]
        public int chance5 = 90;

        [Name("          Longer Lasting Fires")]
        [Description("Increase the % duration of fires.(Game default = 50%)")]
        [Slider(0, 200)]
        public int duration5 = 50;

        [Name("          Quicker Fire Starting")]
        [Description("Quicker fire starting.(Game default = 50%)")]
        [Slider(0, 100)]
        public int quickstart5 = 50;





        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {

            if (field.Name == nameof(Fire) ||
                field.Name == nameof(Fire1) ||
                field.Name == nameof(Fire2) ||
                field.Name == nameof(Fire3) ||
                field.Name == nameof(Fire4) ||
                field.Name == nameof(Fire5))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(tinder), Fire);

            SetFieldVisible(nameof(Fire1), Fire);
            SetFieldVisible(nameof(chance1), Fire1 && Fire);
            SetFieldVisible(nameof(duration1), Fire1 && Fire);
            SetFieldVisible(nameof(quickstart1), Fire1 && Fire);

            SetFieldVisible(nameof(Fire2), Fire);
            SetFieldVisible(nameof(chance2), Fire2 && Fire);
            SetFieldVisible(nameof(duration2), Fire2 && Fire);
            SetFieldVisible(nameof(quickstart2), Fire2 && Fire);
            SetFieldVisible(nameof(tier2), Fire2 && Fire);

            SetFieldVisible(nameof(Fire3), Fire);
            SetFieldVisible(nameof(chance3), Fire3 && Fire);
            SetFieldVisible(nameof(duration3), Fire3 && Fire);
            SetFieldVisible(nameof(quickstart3), Fire3 && Fire);
            SetFieldVisible(nameof(tier3), Fire3 && Fire);

            SetFieldVisible(nameof(Fire4), Fire);
            SetFieldVisible(nameof(chance4), Fire4 && Fire);
            SetFieldVisible(nameof(duration4), Fire4 && Fire);
            SetFieldVisible(nameof(quickstart4), Fire4 && Fire);
            SetFieldVisible(nameof(tier4), Fire4 && Fire);

            SetFieldVisible(nameof(Fire5), Fire);
            SetFieldVisible(nameof(chance5), Fire5 && Fire);
            SetFieldVisible(nameof(duration5), Fire5 && Fire);
            SetFieldVisible(nameof(quickstart5), Fire5 && Fire);
            SetFieldVisible(nameof(tier5), Fire5 && Fire);

        }


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Skill-Adjustment-Firestarting");
            settings.RefreshFields();
        }
    }
}
