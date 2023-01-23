using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenSlide : MonoBehaviour
{
	[SerializeField] private GameObject canvas;
	[SerializeField] private GameObject slide;
	public static bool fullscreen;
	
	void Start()
	{
		canvas.SetActive(false);
		fullscreen = false;
	}
	
	void LateUpdate()
	{
		if(fullscreen)
		{
			if(Input.GetKeyDown(KeyCode.Escape))
			{
				fullscreen = false;
				canvas.SetActive(false);
			}
		}
	}
	
    public void OnClickFullScreen(Texture tex)
	{
		//Change Texture to Slide Image
		//Only Do if EscMenu is not Open
		if(!EscMenu.escapeMenuOpen)
		{
			slide.GetComponent<RawImage>().texture = tex;
			canvas.SetActive(true);
			fullscreen = true;
		}
	}
	
}
