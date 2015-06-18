using UnityEngine;
using System.Collections;

public class ArmyTrigger : MonoBehaviour {
	public GameObject army;
	public GameObject squadron;
	private bool isSpawned = false;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && isSpawned == false) {
			Instantiate(army,army.transform.position,army.transform.rotation);
			Instantiate(squadron,squadron.transform.position,squadron.transform.rotation);
			isSpawned = true;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
