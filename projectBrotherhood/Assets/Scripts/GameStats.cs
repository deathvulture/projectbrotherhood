using UnityEngine;
using System.Collections;

public static class GameStats {

	private static int nLives = -1;
	private static int nPoints = 0;
	private static string mapName;
	private static bool isPaused = false;
	private static bool soundState = true; //True ON, False OFF
	
	
	
	//Set Initial Values
	public static void start()
	{
		if (nLives == -1) nLives = 5;
		GameObject.Find("txtLives").guiText.text = "Lives: " + nLives.ToString();
		GameObject.Find("txtPoints").guiText.text = "Points: " + nPoints.ToString();
		isPaused = false;
	}
	
	// Assign new lives count and update text
	public static void takeLife()
	{	
		nLives = nLives -1;
		GameObject.Find("txtLives").guiText.text = "Lives: " + nLives.ToString();
	}
	
	//Assign new point count and update text	
	public static void givePoints(int quantity)
	{	
		nPoints = nPoints +  quantity;
		GameObject.Find("txtPoints").guiText.text = "Points: " + nPoints.ToString();
	}
	
	//Change pause state
	public static void togglePauseState()
	{
		if (isPaused == false) {
			isPaused = true;
		}
		else {
			isPaused = false;
		}	
	}
	
	
	//Returns pause state
	public static bool getPauseState()
	{
		return isPaused;	
	}
	
	
	//Change music state
	public static void toggleSoundState()
	{
		if (soundState == false) {
			soundState = true;
		}
		else {
			soundState = false;
		}	
	}
	
	//Returns music state
	public static bool getSoundState()
	{
		return soundState;	
	}
	

}
