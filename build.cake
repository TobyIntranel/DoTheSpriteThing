﻿const string baseVersionNumber = "1.0.0";
const string buildConfiguration = "Release";

var target = Argument("target", "Default");

Task("Default").IsDependentOn("Pack");

Task("Pack").IsDependentOn("Build").Does(() => {
	var revisionNumber = EnvironmentVariable("BUILD_NUMBER") ?? "0";

	var nuGetPackSettings = new NuGetPackSettings
	{
		Version = baseVersionNumber + "." + revisionNumber,
	};
	NuGetPack("DoTheSpriteThing/DoTheSpriteThing.nuspec", nuGetPackSettings);
});

Task("Build").IsDependentOn("Restore").Does(() => {
	var buildSettings = new DotNetCoreBuildSettings
	{
		Configuration = buildConfiguration,
		NoIncremental = true		
	};
	DotNetCoreBuild("DoTheSpriteThing/project.json", buildSettings);		
});

Task("Restore").Does(() => {	
	DotNetCoreRestore();	
});

RunTarget(target);