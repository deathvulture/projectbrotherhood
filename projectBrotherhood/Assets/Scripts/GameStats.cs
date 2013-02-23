using UnityEngine;
using System.Collections;

public static class GameStats {

	static int nLives = -1;
	static int nPoints = 0;
	static string mapName;
	
	
	
	//Set Initial Values
	public static void start()
	{
		if (nLives == -1) nLives = 5;
		GameObject.Find("txtLives").guiText.text = "Lives: " + nLives.ToString();
		GameObject.Find("txtPoints").guiText.text = "Points: " + nPoints.ToString();
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

}
