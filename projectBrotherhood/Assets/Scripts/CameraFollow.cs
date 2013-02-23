using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

 
    public float dampTime = 0.15f;
	public float y = 0.165f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
 
    // Update is called once per frame
    void LateUpdate() 
    {
       if (target)
       {
         Vector3 point = camera.WorldToViewportPoint(target.position);
         Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, y, point.z)); //(new Vector3(0.5, 0.5, point.z));
         Vector3 destination = transform.position + delta; 
         transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			
       }
 
    }
}