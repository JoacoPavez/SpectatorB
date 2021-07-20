// Copyright Charmillot Clement 2020. All Rights Reserved.

using UnrealBuildTool;

using System.IO;

public class BlueprintJson : ModuleRules
{
	public BlueprintJson(ReadOnlyTargetRules Target) : base(Target)
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
				"Json",
				"JsonUtilities"
			}
		);
		
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
	}
}
