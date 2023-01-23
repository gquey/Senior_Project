using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	
	public static void HTU()
	{
		SceneManager.LoadScene(0);
	}
	
    public static void Menu()
	{
		SceneManager.LoadScene(1);
	}
	
	public static void CR()
	{
		SceneManager.LoadScene(2);
	}
	
	public static void JR()
	{
		SceneManager.LoadScene(3);
	}
	
	public static void FAQ()
	{
		SceneManager.LoadScene(4);
	}
	
	public static void InfiniteRoom()
	{
		SceneManager.LoadScene(5);
	}
	
	public static void ForestRoom()
	{
		SceneManager.LoadScene(6);
	}
	
	public static void MoonRoom()
	{
		SceneManager.LoadScene(7);
	}
	
	public static void Quit()
	{
		Application.Quit();
	}
	
}
