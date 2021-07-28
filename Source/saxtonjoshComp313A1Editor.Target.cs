// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class saxtonjoshComp313A1EditorTarget : TargetRules
{
	public saxtonjoshComp313A1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("saxtonjoshComp313A1");
	}
}
