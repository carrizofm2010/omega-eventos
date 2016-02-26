using UnityEngine;
using System.Collections;

public class Capture : MonoBehaviour 
{
	// Store more screenshots...
	private int Screen_Shot_Count = 0;
	// Screenshot taking by touch the button.
	public GUITexture Capture_Model;
	// Check the Shot Taken/Not.
	private bool Shot_Taken = false;
	// Name of the File.
	private string Screen_Shot_File_Name;
	
	void Update()
	{
		if (Input.touches.Length > 0)       
			// Finger hit the button position.
			if(Capture_Model.HitTest (Input.GetTouch(0).position))
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began)
			{
				// Increament the screenshot count.
				Screen_Shot_Count++;
				// Save the screenshot name as Screenshot_1.png, Screenshot_2.png, with date format...
				Screen_Shot_File_Name = "Screenshot__" + Screen_Shot_Count + System.DateTime.Now.ToString("__yyyy-MM-dd") + ".png";
				Application.CaptureScreenshot(Screen_Shot_File_Name);
				Shot_Taken = true;
			}
		}
		if(Shot_Taken == true)
		{
			string Origin_Path = System.IO.Path.Combine(Application.persistentDataPath, Screen_Shot_File_Name);
			// This is the path of my folder.
			string Path = "/mnt/sdcard/DCIM/Inde/" + Screen_Shot_File_Name;
			if(System.IO.File.Exists(Origin_Path))
			{
				System.IO.File.Move(Origin_Path, Path);
				Shot_Taken = false;
			}
		}
	}
	public void sacarFoto(){
		Screen_Shot_Count++;
		// Save the screenshot name as Screenshot_1.png, Screenshot_2.png, with date format...
		Screen_Shot_File_Name = "Screenshot__" + Screen_Shot_Count + System.DateTime.Now.ToString("__yyyy-MM-dd") + ".png";
		Application.CaptureScreenshot(Screen_Shot_File_Name);
		Shot_Taken = true;
		string Origin_Path = System.IO.Path.Combine(Application.persistentDataPath, Screen_Shot_File_Name);
		// This is the path of my folder.
		string Path = "/mnt/sdcard/DCIM/" + Screen_Shot_File_Name;
		if(System.IO.File.Exists(Origin_Path))
		{
			System.IO.File.Move(Origin_Path, Path);
			Shot_Taken = false;
		}
	}
}