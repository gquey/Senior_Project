using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReplaceImages : MonoBehaviour
{
	//Rename the Copies of Room Objects to use replaceImages Function
    public static void renameRoom(int roomNumber,ref GameObject room)
	{
		room.name = roomNumber.ToString();
	}
	
	//Places the PNG Slide on the Slide Object
	//RoomNumber is the Rooms number
	//RoomSlideNumber is the slide object we want to replace in the Room
	//PathSlide is the actual slide number in the folder/path
	public static void replaceImage(int roomNumber, int roomSlideNumber, int pathSlide)
	{
		//Find the Slide inside in the Room
		string slidePath = roomNumber.ToString() + "/Slides/Slides/" + roomSlideNumber.ToString();
		GameObject slide = GameObject.Find(slidePath);
		
		if(slide != null)
		{
			string filePath = StaticValues.slidePath + "\\Slide" + (pathSlide).ToString() + ".PNG";
			Texture2D tex = null;
			byte[] fileData;
			if (File.Exists(filePath)) 
			{
				fileData = File.ReadAllBytes(filePath);
				tex = new Texture2D(2, 2);
				tex.LoadImage(fileData);
			}
			else
			{
				slide.SetActive(false);
			}
			slide.GetComponent<RawImage>().texture = tex;
		}
	}
}
