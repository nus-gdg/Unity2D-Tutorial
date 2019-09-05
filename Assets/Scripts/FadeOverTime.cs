using UnityEngine;
using System.Collections;

/*
 Generic script to make a gameObject start fading out over time.
*/
public class FadeOverTime : MonoBehaviour 
{
	public float delay;
	public float fadeRate;
	public GameObject follower;

	private bool fade;

	// Use this for initialization
	void Start() 
	{
		fade = false;
		StartCoroutine (StartFading());
	}

	IEnumerator StartFading()
	{
		if(delay < 0)
		{
			yield break;
		}
		yield return new WaitForSeconds(delay);
		fade = true;
	}
	
	// Update is called once per frame
	void Update() 
	{
		if(fade)
		{
			Color temp = gameObject.GetComponent<Renderer>().material.color;
			temp.a -= fadeRate * Time.deltaTime;
			gameObject.GetComponent<Renderer>().material.color = temp;
			
			if(follower != null) {
				temp = follower.GetComponent<TextMesh>().color;
				temp.a -= fadeRate * Time.deltaTime;
				follower.GetComponent<TextMesh>().color = temp;
			}
			
			if(gameObject.GetComponent<Renderer>().material.color.a <= 0.0f)
			{
				Destroy(gameObject);
			}
		}
	}
}
