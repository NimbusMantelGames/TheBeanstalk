// © 2015 Nimbusmantel Games

using UnrealBuildTool;
using System.Collections.Generic;

public class TheBeanstalkEditorTarget : TargetRules
{
	public TheBeanstalkEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "TheBeanstalk" } );
	}
}
