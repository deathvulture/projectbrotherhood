using UnityEngine;
using System.Collections;

public class stab : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	 void OnTriggerEnter(Collider other){
		animation["Up Down"].speed = 2.0f;
		animation.Play();

	}
}
