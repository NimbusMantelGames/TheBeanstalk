// © 2015 Nimbusmantel Games

using UnrealBuildTool;
using System.Collections.Generic;

public class TheBeanstalkTarget : TargetRules
{
	public TheBeanstalkTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
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
