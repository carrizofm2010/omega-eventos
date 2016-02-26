using UnityEngine;
using System.Collections;

public class captureScreen : MonoBehaviour {
	
	// Use this for initialization
	public void ButtonScreenShot(){
		StartCoroutine ("ScreenshotEncode");
	}
	
	private IEnumerator ScreenshotEncode (){
		yield return new WaitForEndOfFrame ();
		string datacion = System.DateTime.Now.ToFileTime ().ToString ();
		Application.CaptureScreenshot (datacion+".png");
	}
}
