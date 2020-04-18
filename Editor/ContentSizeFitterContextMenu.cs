using UnityEditor;
using UnityEngine.UI;

namespace UniContentSizeFitterContextMenu
{
	internal static class ContentSizeFitterContextMenu
	{
		[MenuItem( "CONTEXT/ContentSizeFitter/Both Preferred Size" )]
		private static void BothPreferredSize( MenuCommand command )
		{
			var fitter = command.context as ContentSizeFitter;
			Undo.RecordObject( fitter, "Both Preferred Size" );
			var mode = ContentSizeFitter.FitMode.PreferredSize;
			fitter.horizontalFit = mode;
			fitter.verticalFit   = mode;
		}
	}
}