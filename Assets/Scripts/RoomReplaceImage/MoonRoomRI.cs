using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRoomRI : MonoBehaviour
{
	[SerializeField] private GameObject Room;
	[SerializeField] private GameObject EndBoarder;
	[SerializeField] private int slidesInRoom;
	
    void Start()
    {	
		GameObject room;
		int range = StaticValues.SlideRangeInputEnd - StaticValues.SlideRangeInputStart;
		//First 24 Slides
		for(int i = 0; (i < slidesInRoom); i++)
		{
			ReplaceImages.renameRoom(0, ref Room);
			if(i < range + 1)
			{
				ReplaceImages.replaceImage(0, i + 1, StaticValues.SlideRangeInputStart + i);
			}
			else
			{
				ReplaceImages.replaceImage(0, i + 1, -1);
			}
		}
		
		//25+ Slides
		for(int j = 0; j < range/slidesInRoom; j++)
		{
			//Copy Room,Move Room, Move Boarder
			room = Instantiate(Room);
			room.transform.Translate(-500 * (j + 1),0,0);
			ReplaceImages.renameRoom(j + 1, ref room);
			EndBoarder.transform.Translate(0,-500,0);
			
			
			for(int i = 0; i < slidesInRoom; i++)
			{
				//start slide + slides in all rooms + slide in current room
				int currentSlide = (StaticValues.SlideRangeInputStart + (j+1) * slidesInRoom + i);
				if(currentSlide <= StaticValues.SlideRangeInputEnd)
				{
					ReplaceImages.replaceImage(j + 1, i + 1, currentSlide );
				}
				else
				{
					ReplaceImages.replaceImage(j + 1, i + 1, -1 );
				}
			}
		}
    }
}
