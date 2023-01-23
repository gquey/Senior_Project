// Finished on October 25th
// Written by Frank Olivera

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

//Change a RawImage with a given path

public class ChangeImageExample : MonoBehaviour
{
	RawImage slide;
    void Start()
	{	
		string filePath = "C:\\Users\\Knarf\\Documents\\Lightshot\\Screenshot_1.png";
		Texture2D tex = null;
		byte[] fileData;
		if (File.Exists(filePath)) 
		{
			fileData = File.ReadAllBytes(filePath);
			tex = new Texture2D(2, 2);
			tex.LoadImage(fileData);
		}
		slide = GetComponent<RawImage>();
		slide.texture = tex;
	}
	
	public void ChangeSlideImage(string filePath)
	{
		byte[] fileData;
		Debug.Log("ChangeSlideImage");
		Texture2D tex = null;
		if (File.Exists(filePath)) 
		{
			fileData = File.ReadAllBytes(filePath);
			tex = new Texture2D(2, 2);
			tex.LoadImage(fileData);
		}
		slide = GetComponent<RawImage>();
		slide.texture = tex;
	}
}