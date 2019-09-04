using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Generic Script to move an object from one place to another the moment it is spawned, then destroys it.
 Destination needs to be set.
 You may set callback to intercept the destroy function. If you do, then this object is not automatically destroyed and the callback is called instead.
 If you don't, the object is destroyed.
*/
public class MoveAndDestroy : MonoBehaviour {

	public Vector3 destination;
	public float howLong;

	float time;
	Vector3 startLocation;

	destroyCallback callback;

	public delegate void destroyCallback(GameObject who);

	// Use this for initialization
	void Start () {
		time = 0;
		startLocation = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		Vector3 currPos = Vector3.Lerp(startLocation, destination, (time/howLong));
		gameObject.transform.position = currPos;
		if(time >= howLong) {
			if(callback != null) {
				callback(gameObject);
			} else {
				Destroy(gameObject);
			}
		}
	}

	public void setDestination(Vector3 d) {
		destination = d;
	}

	public void setCallback(destroyCallback dcb) {
		callback = dcb;
	}

	public void reset() {
		Start();
	}
}
