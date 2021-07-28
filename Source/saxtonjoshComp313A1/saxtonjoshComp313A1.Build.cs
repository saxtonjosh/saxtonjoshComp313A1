// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class saxtonjoshComp313A1 : ModuleRules
{
	public saxtonjoshComp313A1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
