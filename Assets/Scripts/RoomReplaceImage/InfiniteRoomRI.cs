using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoomRI : MonoBehaviour
{
	[SerializeField] private GameObject startRoom;
	[SerializeField] private GameObject middleRoom;
	[SerializeField] private GameObject endRoom;
	
    void Start()
    {
        /*
		//Test Case
		StaticValues.SlideRangeInputStart = 3;
		StaticValues.SlideRangeInputEnd = 3;
		StaticValues.slidePath = "D:\\Unity\\Senior_Project\\Assets\\Tests\\TestSlides";
		*/

        GameObject room;
        //One Slide
        if (StaticValues.SlideRangeInputEnd - StaticValues.SlideRangeInputStart == 0)
		{
			//Start Room and End Room Instantiate in Same Position
			room = Instantiate(startRoom);
			ReplaceImages.renameRoom(0, ref room);
			room.transform.Translate(0,-100,0);
			ReplaceImages.replaceImage(0, 1 , StaticValues.SlideRangeInputStart);
			
			room = Instantiate(endRoom);
			ReplaceImages.renameRoom(1, ref room);
			room.transform.Translate(-0.1f,-99.9f,-0.1f);
			ReplaceImages.replaceImage(1, 1 , -1);
		}
		//Two Slide
		else if(StaticValues.SlideRangeInputEnd - StaticValues.SlideRangeInputStart == 1)
		{
			//Start Room at z = 0 and End Room at z = 50
			room = Instantiate(startRoom);
			ReplaceImages.renameRoom(0, ref room);
			room.transform.Translate(0,-100,0);
			ReplaceImages.replaceImage(0, 1, StaticValues.SlideRangeInputStart);
			
			room = Instantiate(endRoom);
			ReplaceImages.renameRoom(1, ref room);
			room.transform.Translate(0,-100,50);
			ReplaceImages.replaceImage(1, 1, StaticValues.SlideRangeInputEnd);
		}
		//Three or More Slides
		else
		{
			//Create Start Room
			room = Instantiate(startRoom);
			ReplaceImages.renameRoom(0, ref room);
			room.transform.Translate(0,-100,0);
			ReplaceImages.replaceImage(0, 1, StaticValues.SlideRangeInputStart);
			
			int z = 50;
			int range = StaticValues.SlideRangeInputEnd - StaticValues.SlideRangeInputStart;
			for(int i = 1; i < range; i++)
			{
				room = Instantiate(middleRoom);
				ReplaceImages.renameRoom(i, ref room);
				room.transform.Translate(0,-100, z);
				z += 50;
				ReplaceImages.replaceImage(i, 1 , StaticValues.SlideRangeInputStart + i);
			}
			
			//Create End Room
			room = Instantiate(endRoom);
			ReplaceImages.renameRoom( range , ref room);
			room.transform.Translate(0,-100,z);
			ReplaceImages.replaceImage(range, 1, StaticValues.SlideRangeInputEnd );
		}
    }
}
