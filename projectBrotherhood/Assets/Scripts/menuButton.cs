using UnityEngine;
using System.Collections;

public class menuButton : MonoBehaviour {
	
	
	void OnMouseEnter() { renderer.material.color = Color.red; }

	void OnMouseExit() { renderer.material.color = Color.white; }
	
	public bool isExit;
	public int scene;
	
	void OnMouseDown(){
		if (isExit == true) Application.Quit();
		else Application.LoadLevel(scene);	
		
	}
	
}