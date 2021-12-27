
//---------------------------------------------------------------------------------------
Task("nuget-pack")
    .IsDependentOn ("libs")
    .Does
    (
        () =>
        {
			foreach(FilePath sln in LibrarySourceSolutions)
			{
				Information($"Solution: 	{sln}");
			}
			foreach(FilePath prj in LibrarySourceProjects)
			{
				Information($"Project: 		{prj}");

				MSBuild
				(
					prj,
					configuration => 
						configuration
							.SetConfiguration("Release")
							.WithTarget("Pack")
							//.WithProperty("PackageVersion", NUGET_VERSION)
							.WithProperty("PackageOutputPath", "../../output")
				);

				DotNetPack
				(
					prj,
					new DotNetPackSettings
					{
						Configuration = "Release",
						OutputDirectory = "../../output/"
					}
				);
			}



            return;
        }
    );

//---------------------------------------------------------------------------------------
