using UnityEngine;
using System.Collections;

public class ArmyTrigger : MonoBehaviour {
	public GameObject army;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Instantiate(army,army.transform.position,army.transform.rotation);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
