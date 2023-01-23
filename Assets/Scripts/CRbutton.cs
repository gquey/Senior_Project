using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CRbutton : MonoBehaviour
{
	[SerializeField] private GameObject ErrorBox;
	[SerializeField] private GameObject ErrorMessage;
	
	void Start()
	{
		ErrorBox.SetActive(false);
	}
	
	public void CloseError()
    {
        ErrorBox.SetActive(false);
    }
	
    public void CreateRoom()
	{
		TextMeshProUGUI mError = ErrorMessage.GetComponent<TextMeshProUGUI>();
		mError.text = "";
		bool error = false;
		
		if(StaticValues.slidePath == "")
		{
			mError.text += "\nNo Folder Selected";
			error = true;
		}
		else
		{
			//If SlideRange rather than ALL is selected
			if(StaticValues.SlideRange)
			{
				if(!StaticValues.validStartInputRange)
				{
					mError.text += "\nInvalid Start Input";
					error = true;
				}
				if(!StaticValues.validEndInputRange)
				{
					mError.text += "\nInvalid End Input";
					error = true;
				}
				if(StaticValues.validStartInputRange && StaticValues.validEndInputRange)
				{
					if( (StaticValues.SlideRangeInputEnd - StaticValues.SlideRangeInputStart) < 0)
					{
						mError.text += "\nEnd Range Input cannot be smaller than Start Range Input";
						error = true;
					}
				}
			}
			//ALL is selected
			else
			{
				string[] files = Directory.GetFiles(StaticValues.slidePath,"Slide*.png");
				if(files.Length == 0)
				{
					mError.text += "\nNo Slides in Folder";
					error = true;
				}
				else
				{
					StaticValues.SlideRangeInputStart = 1;
					StaticValues.SlideRangeInputEnd = files.Length;
				}
			}
		}
		
		
		if(error)
		{
			ErrorBox.SetActive(true);
		}
		else
		{
			//Change the Scene Based on Room Theme Selected
			if(StaticValues.rtr == 0)
			{
				ChangeScene.InfiniteRoom();
			}
			else if(StaticValues.rtr == 1)
			{
				ChangeScene.ForestRoom();
			}
			else if(StaticValues.rtr == 2)
			{
				ChangeScene.MoonRoom();
			}
		}
	}
	
	//Testing Functions
	public void TesterInitialization()
	{
		//For Testing
		ErrorBox = new GameObject();
		ErrorMessage = new GameObject();
		ErrorMessage.AddComponent<TextMeshProUGUI>();
	}
	public bool ErrorBoxActive()
	{
		return ErrorBox.activeSelf;
	}
}
