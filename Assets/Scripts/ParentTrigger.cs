using UnityEngine;
using System.Collections;

public class ParentTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Leader") {
			//play sound
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
