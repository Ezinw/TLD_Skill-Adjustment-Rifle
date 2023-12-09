using MelonLoader;

namespace SkillAdjustmentRifle
{ 
	internal sealed class Implementation : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }
	
	}

}
