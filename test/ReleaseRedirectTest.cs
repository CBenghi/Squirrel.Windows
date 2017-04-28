using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squirrel.Tests.TestHelpers;
using Xunit;

namespace Squirrel
{
    
    public class ReleaseRedirectTest
    {
        [Fact]
        public async Task CustomNamedRELEASEUrl()
        {
            string tempDir;
            string remotePkgDir = "http://www.overarching.it/dload/XbimXplorer";

            using (Utility.WithTempDirectory(out tempDir))
            {
                using (var um = new UpdateManager(remotePkgDir, "theApp", tempDir))
                {
                    var ret = um.UpdateApp(releasesExtension: ".php");
                    var t = ret.Result;
                }
            }
        }
    }
}
