using UnityEngine;
using System.Collections;

public class moveInput : MonoBehaviour {
#pragma warning disable 0414

	float vel;
	float vel2;
	float ms = .5f;
	float tb;
	float tb2;
	float timeForSmooth = .5f;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
			{
				fingerCount++;
//				Debug.Log(touch.position.ToString()); // touch.position will give you a vector2
			}
			
		}
		if (fingerCount > 0)
			print("User has " + fingerCount + " finger(s) touching the screen");
		//print (Screen.width/2);
if(Input.touchCount>0){		
		if((Input.touchCount > 0) && (((Input.GetTouch (0).phase == TouchPhase.Began) || (Input.GetTouch (0).phase == TouchPhase.Moved))) || (Input.GetTouch (0).phase == TouchPhase.Stationary) || (Input.GetTouch (0).phase == TouchPhase.Moved))
			{
			
				if(Input.GetTouch(0).position.x > Screen.width/2)
				{
					
						//float newPosition = Mathf.SmoothDamp(0, 1, ref vel, ms);
						if(!(tb>timeForSmooth))
						{
							tb = tb + Time.deltaTime;
							tb2 = 0;	
						}
					
						float newPosition = Mathf.Lerp(0,1,tb/timeForSmooth);
						//print (newPosition);
						transform.position =  new Vector3(transform.position.x  + newPosition* Time.deltaTime* 20,transform.position.y, transform.position.z);
	
					
					
					
				}
				else if(Input.GetTouch(0).position.x <= Screen.width/2)
				{
						if(!(tb2>timeForSmooth))
						{//
							tb2 = tb2 + Time.deltaTime;
							tb = 0;
						}
						//float newPosition = Mathf.SmoothDamp(0, 1, ref vel2, ms);
						float newPosition = Mathf.Lerp(0,1,tb2/timeForSmooth);
						transform.position =  new Vector3(transform.position.x  + newPosition* Time.deltaTime* -20,transform.position.y, transform.position.z);
	
						
				}
			}
			
			
			
			else
			{
				vel2 = 0;
				tb = 0;
				tb2 = 0;
			}}
	}
	
	
	
	
		
}
