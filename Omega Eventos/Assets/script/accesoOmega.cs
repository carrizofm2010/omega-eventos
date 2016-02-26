using UnityEngine;
using System.Collections;
using Vuforia;
public class accesoOmega : MonoBehaviour, IVirtualButtonEventHandler {

	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			
			vbs[i].RegisterEventHandler(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		
		// si se presiona el boton virtual quebrada
		if (vb.VirtualButtonName == "VirtualOmega") {
			
			Application.OpenURL("https://www.facebook.com/events/558981187604216/");
			
		}
		
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
	}
}
