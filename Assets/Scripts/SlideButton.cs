using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideButton : MonoBehaviour
{
	[SerializeField] private GameObject slide;
    void OnMouseDown()
	{
		GameObject FSS = GameObject.Find("FullScreenSlide");
		FSS.GetComponent<FullScreenSlide>().OnClickFullScreen(slide.GetComponent<RawImage>().texture);
	}
}
