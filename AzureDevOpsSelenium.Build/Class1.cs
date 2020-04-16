using Nuke.Common;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using System;

namespace AzureDevOpsSelenium.Build
{
    public class Build : NukeBuild
    {
        public static int Main() => Execute<Build>(x => x.Test);
        [Solution] readonly Solution Solution;

        Target Test => _ => _
            .Executes(() =>
            {
                DotNetTasks.DotNetTest(t => t.SetProjectFile(Solution.GetProject("AzureDevOpsSelenium").Path));
            });
    }
}