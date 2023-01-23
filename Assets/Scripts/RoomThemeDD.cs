using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomThemeDD : MonoBehaviour
{
	void Start()
	{
		StaticValues.rtr = 0;
	}
	public void DropDown(int val)
	{
		StaticValues.rtr = val;
	}
}
