using UnityEngine;
using System.Collections;

public class EventScript : MonoBehaviour {
	public GameObject explosion;
	private GameObject player;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" ) {
			Instantiate(explosion,explosion.transform.position,explosion.transform.rotation);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
