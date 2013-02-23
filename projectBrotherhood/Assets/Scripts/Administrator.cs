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
	}
}
