using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Debug.Log("trigger");
			Application.LoadLevel(1);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
