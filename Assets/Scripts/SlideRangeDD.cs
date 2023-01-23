using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SlideRangeDD : MonoBehaviour
{	
	[SerializeField] private GameObject Range;
	[SerializeField] private GameObject Invalid_Start_Range;
	[SerializeField] private GameObject Invalid_End_Range;
	
	void Start()
	{
		//Start Values of Slide Range
		StaticValues.SlideRange = false;
		Range.SetActive(false);
		Invalid_Start_Range.SetActive(false);
		Invalid_End_Range.SetActive(false);
		StaticValues.validRange = false;
		StaticValues.validStartInputRange = false;
		StaticValues.validEndInputRange = false;
	}
	
	public void SlideRangeDropDown(int val)
	{
		if(val == 0)
		{
			Range.SetActive(false);
			StaticValues.SlideRange = false;
		}
		else
		{
			Range.SetActive(true);
			StaticValues.SlideRange = true;
		}
	}
	
	public void SlideRange1(string val)
	{
		try
		{
			StaticValues.SlideRangeInputStart = Int32.Parse(val);
			//Input needs to be greater than 0
			if(!(StaticValues.SlideRangeInputStart > 0))
			{
				throw new FormatException();
			}
			StaticValues.validStartInputRange = true;
			Invalid_Start_Range.SetActive(false);
		}
		catch (FormatException)
		{
			StaticValues.validStartInputRange = false;
			Invalid_Start_Range.SetActive(true);
		}
	}
	
	public void SlideRange2(string val)
	{
		try
		{
			StaticValues.SlideRangeInputEnd = Int32.Parse(val);
			//Input needs to be greater than 0
			if(!(StaticValues.SlideRangeInputEnd > 0))
			{
				throw new FormatException();
			}
			StaticValues.validEndInputRange = true;
			Invalid_End_Range.SetActive(false);
		}
		catch (FormatException)
		{
			StaticValues.validEndInputRange = false;
			Invalid_End_Range.SetActive(true);
		}
	}
	
	//Tester Functions
	public void TesterInitialization()
	{
		//For Testing
		Range = new GameObject();
		Invalid_Start_Range = new GameObject();
		Invalid_End_Range = new GameObject();
	}
}
