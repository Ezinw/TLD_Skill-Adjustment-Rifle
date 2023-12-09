using ModSettings;
using System.Reflection;

namespace SkillAdjustmentRifle
{
    internal class Settings : JsonModSettings
    {

        [Section("Rifle")]

        [Name("Rifle Skills")]
        private readonly bool Rifle = true;

        //lvl 1
        [Name("Rifle Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Rifle1 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 0%)")]
        [Slider(0, 100)]
        public int crit1 = 0;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 0%)")]
        [Slider(0, 100)]
        public int repair1 = 0;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 0%)")]
        [Slider(0, 100)]
        public int accuracy1 = 0;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int dmg1 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int degrade1 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.0)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float aim1 = 0.00f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 75)")]
        [Slider(75, 350)]
        public int range1 = 75;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 0)")]
        [Slider(0, 100)]
        public int stable1 = 0;


        //lvl 2
        [Name("Rifle Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Rifle2 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 10%)")]
        [Slider(0, 100)]
        public int crit2 = 10;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int repair2 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 0%)")]
        [Slider(0, 100)]
        public int accuracy2 = 0;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int dmg2 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int degrade2 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.2)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float aim2 = 0.20f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 90)")]
        [Slider(0, 350)]
        public int range2 = 90;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 10)")]
        [Slider(0, 100)]
        public int stable2 = 10;


        //lvl 3
        [Name("Rifle Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Rifle3 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 15%)")]
        [Slider(0, 100)]
        public int crit3 = 15;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int repair3 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 20%)")]
        [Slider(0, 100)]
        public int accuracy3 = 20;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 0%)")]
        [Slider(0, 100)]
        public int dmg3 = 0;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 3%)")]
        [Slider(0, 100)]
        public int degrade3 = 3;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.35)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float aim3 = 0.35f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 110)")]
        [Slider(0, 350)]
        public int range3 = 110;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 20)")]
        [Slider(0, 100)]
        public int stable3 = 20;


        //lvl 4
        [Name("Rifle Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Rifle4 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 20%)")]
        [Slider(0, 100)]
        public int crit4 = 20;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 2%)")]
        [Slider(0, 100)]
        public int repair4 = 2;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 30%)")]
        [Slider(0, 100)]
        public int accuracy4 = 30;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 10%)")]
        [Slider(0, 100)]
        public int dmg4 = 10;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 0%)")]
        [Slider(0, 100)]
        public int degrade4 = 0;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.5)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float aim4 = 0.50f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 150)")]
        [Slider(0, 350)]
        public int range4 = 150;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 30)")]
        [Slider(0, 100)]
        public int stable4 = 30;


        //lvl 5
        [Name("Rifle Level 5 ------------------------------")]
        [Description("Show or hide level 5 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Rifle5 = false;

        [Name("         - Critical Hit Bonus")]
        [Description("Critical Hit chance.(Game default = 30%)")]
        [Slider(0, 100)]
        public int crit5 = 30;

        [Name("         - Repair Bonus")]
        [Description("Increase amount of condition recieved from repair.(Game default = 5%)")]
        [Slider(0, 100)]
        public int repair5 = 5;

        [Name("         - Accuracy")]
        [Description("Bonus to Accuracy .(Game default = 30%)")]
        [Slider(0, 100)]
        public int accuracy5 = 30;

        [Name("         - Damage Bonus")]
        [Description("Increase damage.(Game default = 20%)")]
        [Slider(0, 100)]
        public int dmg5 = 20;

        [Name("         - Condition Loss")]
        [Description("Rifle condition decays slower per use..(Game default = 50%)")]
        [Slider(0, 100)]
        public int degrade5 = 50;

        [Name("         - Aim assist")]
        [Description("Increase aim assist.(Game default = 0.6)")]
        [Slider(0.00f, 1.00f, NumberFormat = "{0:#.00}")]
        public float aim5 = 0.60f;

        [Name("         - Effective range")]
        [Description("Increase effective range.(Game default = 250)")]
        [Slider(0, 350)]
        public int range5 = 250;

        [Name("         - Stability bonus")]
        [Description("Increase stability.(Game default = 50)")]
        [Slider(0, 100)]
        public int stable5 = 50;


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(Rifle)  ||
                field.Name == nameof(Rifle1) ||
                field.Name == nameof(Rifle2) ||
                field.Name == nameof(Rifle3) ||
                field.Name == nameof(Rifle4) ||
                field.Name == nameof(Rifle5))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(Rifle1), Rifle);
            SetFieldVisible(nameof(crit1), Rifle1 && Rifle);
            SetFieldVisible(nameof(repair1), Rifle1 && Rifle);
            SetFieldVisible(nameof(accuracy1), Rifle1 && Rifle);
            SetFieldVisible(nameof(dmg1), Rifle1 && Rifle);
            SetFieldVisible(nameof(degrade1), Rifle1 && Rifle);
            SetFieldVisible(nameof(degrade1), Rifle1 && Rifle);
            SetFieldVisible(nameof(degrade1), Rifle1 && Rifle);
            SetFieldVisible(nameof(aim1), Rifle1 && Rifle);
            SetFieldVisible(nameof(range1), Rifle1 && Rifle);
            SetFieldVisible(nameof(stable1), Rifle1 && Rifle);

            SetFieldVisible(nameof(Rifle2), Rifle);
            SetFieldVisible(nameof(crit2), Rifle2 && Rifle);
            SetFieldVisible(nameof(repair2), Rifle2 && Rifle);
            SetFieldVisible(nameof(accuracy2), Rifle2 && Rifle);
            SetFieldVisible(nameof(dmg2), Rifle2 && Rifle);
            SetFieldVisible(nameof(degrade2), Rifle2 && Rifle);
            SetFieldVisible(nameof(aim2), Rifle2 && Rifle);
            SetFieldVisible(nameof(range2), Rifle2 && Rifle);
            SetFieldVisible(nameof(stable2), Rifle2 && Rifle);

            SetFieldVisible(nameof(Rifle3), Rifle);
            SetFieldVisible(nameof(crit3), Rifle3 && Rifle);
            SetFieldVisible(nameof(repair3), Rifle3 && Rifle);
            SetFieldVisible(nameof(accuracy3), Rifle3 && Rifle);
            SetFieldVisible(nameof(dmg3), Rifle3 && Rifle);
            SetFieldVisible(nameof(degrade3), Rifle3 && Rifle);
            SetFieldVisible(nameof(aim3), Rifle3 && Rifle);
            SetFieldVisible(nameof(range3), Rifle3 && Rifle);
            SetFieldVisible(nameof(stable3), Rifle3 && Rifle);

            SetFieldVisible(nameof(Rifle4), Rifle);
            SetFieldVisible(nameof(crit4), Rifle4 && Rifle);
            SetFieldVisible(nameof(repair4), Rifle4 && Rifle);
            SetFieldVisible(nameof(accuracy4), Rifle4 && Rifle);
            SetFieldVisible(nameof(dmg4), Rifle4 && Rifle);
            SetFieldVisible(nameof(degrade4), Rifle4 && Rifle);
            SetFieldVisible(nameof(aim4), Rifle4 && Rifle);
            SetFieldVisible(nameof(range4), Rifle4 && Rifle);
            SetFieldVisible(nameof(stable4), Rifle4 && Rifle);

            SetFieldVisible(nameof(Rifle5), Rifle);
            SetFieldVisible(nameof(crit5), Rifle5 && Rifle);
            SetFieldVisible(nameof(repair5), Rifle5 && Rifle);
            SetFieldVisible(nameof(accuracy5), Rifle5 && Rifle);
            SetFieldVisible(nameof(dmg5), Rifle5 && Rifle);
            SetFieldVisible(nameof(degrade5), Rifle5 && Rifle);
            SetFieldVisible(nameof(aim5), Rifle5 && Rifle);
            SetFieldVisible(nameof(range5), Rifle5 && Rifle);
            SetFieldVisible(nameof(stable5), Rifle5 && Rifle);

        }


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Skill-Adjustment-Rifle");
            settings.RefreshFields();
        }
    }
}