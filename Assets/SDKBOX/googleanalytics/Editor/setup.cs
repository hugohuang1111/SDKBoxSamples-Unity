/*****************************************************************************
Copyright © 2015 SDKBOX.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*****************************************************************************/

using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using Sdkbox;

namespace Sdkbox
{
	[InitializeOnLoad]
	public class GoogleAnalyticsSetup
	{
		const string Version = "1.1";

	    [PostProcessBuild]
        static void OnPostProcessBuild(BuildTarget target, string path)
        {
            Setup.OnPostProcessBuild(target, path);
        }

	    [PostProcessSceneAttribute (1)]
		static GoogleAnalyticsSetup()
		{
			Sdkbox.Setup.Register("GoogleAnalytics", Version);
		}

		[MenuItem("Window/SDKBOX/Documentation/GoogleAnalytics")]
		static void OpenDocumentation(MenuCommand menuCommand)
		{
			Sdkbox.Setup.OpenDocumentation("googleanalytics");
		}
	}
}
