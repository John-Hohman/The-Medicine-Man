using UnrealBuildTool;

public class TheMedicineManTarget : TargetRules
{
	public TheMedicineManTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheMedicineMan");
	}
}
