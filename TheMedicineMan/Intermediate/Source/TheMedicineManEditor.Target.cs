using UnrealBuildTool;

public class TheMedicineManEditorTarget : TargetRules
{
	public TheMedicineManEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TheMedicineMan");
	}
}
