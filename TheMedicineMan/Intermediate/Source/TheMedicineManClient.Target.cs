using UnrealBuildTool;

public class TheMedicineManClientTarget : TargetRules
{
	public TheMedicineManClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TheMedicineMan");
	}
}
