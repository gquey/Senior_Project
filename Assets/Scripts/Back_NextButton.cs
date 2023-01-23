using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_NextButton : MonoBehaviour
{
	[SerializeField] private GameObject p1;
	[SerializeField] private GameObject p2;
	
    void Start()
    {
        p2.SetActive(false);
    }

    public void backButton()
	{
		p2.SetActive(false);
		p1.SetActive(true);
	}
	
	public void NextButton()
	{
		p1.SetActive(false);
		p2.SetActive(true);	
	}
}
