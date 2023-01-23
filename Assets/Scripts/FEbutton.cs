using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System.IO;
using SimpleFileBrowser;

public class FEbutton : MonoBehaviour
{
	void Start()
	{
		FileBrowser.AddQuickLink( "Users", "C:\\Users", null );
	}

	IEnumerator ShowLoadDialogCoroutine()
	{
		yield return FileBrowser.WaitForLoadDialog( FileBrowser.PickMode.Folders, false, null, null, "Folders", "Load" );
		if( FileBrowser.Success )
		{
			StaticValues.slidePath = FileBrowser.Result[0];
		}
	}
	public void FEopen()
	{
		StartCoroutine( ShowLoadDialogCoroutine() );
	}
	
    
}