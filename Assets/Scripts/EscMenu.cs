using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
	public static bool escapeMenuOpen;
	public static bool paused;
	[SerializeField] private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        escapeMenuOpen = false;
		paused = false;
		canvas.SetActive(escapeMenuOpen);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
			//Only Open Escape Menu if FullScreen is not Open
			if(!FullScreenSlide.fullscreen)
			{
				escapeMenuOpen = !escapeMenuOpen;
				canvas.SetActive(escapeMenuOpen);
				if(escapeMenuOpen)
				{
					Cursor.lockState = CursorLockMode.None;
					paused = true;
				}
				else
				{
					Cursor.lockState = CursorLockMode.Locked;
					paused = false;
				}
			}
		}
    }
	
	public void MenuButton()
	{
		paused = false;
		ChangeScene.Menu();
	}
	
	public void QuitButton()
	{
		ChangeScene.Quit();
	}
}
