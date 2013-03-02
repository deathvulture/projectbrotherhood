using UnityEngine;
using System.Collections;

public class Administrator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameStats.start();
	}
	
	// Update is called once per frame
	void Update () {
		GameStats.givePoints(1);
		if (Input.GetButtonDown("Pause")) togglePause();
		if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(KeyCode.F2)) toggleSound();
	}
	
	//Pause and unpause the game
	public static void togglePause()
	{
		if (GameStats.getPauseState() == false) {
			Time.timeScale = 0.0F;
		}
		else {
			Time.timeScale = 1.0F;
		}
		GameStats.togglePauseState();
		print(GameStats.getPauseState());
	}
	
	
	//Turns music On and Off
	public static void toggleSound()
	{
		if (GameStats.getSoundState() == false) {
			AudioListener.pause = true;
		}
		else {
			AudioListener.pause = false;
		}
		GameStats.toggleSoundState();
		print(GameStats.getSoundState());
	}
}
