using UnrealBuildTool;

public class TheMedicineManServerTarget : TargetRules
{
	public TheMedicineManServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TheMedicineMan");
	}
}
