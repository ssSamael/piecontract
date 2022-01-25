using UnrealBuildTool;

public class PieContractTarget : TargetRules
{
	public PieContractTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PieContract");
	}
}
