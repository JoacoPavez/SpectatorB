// Copyright Charmillot Clement 2020. All Rights Reserved.

using UnrealBuildTool;

public class BlueprintJsonEditor : ModuleRules
{
	public BlueprintJsonEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core"
			}
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"BlueprintJson",
				"Json",
				"BlueprintGraph",
				"UnrealEd",
				"KismetCompiler"
			}
		);
	}
}
