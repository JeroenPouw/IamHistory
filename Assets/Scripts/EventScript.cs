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
			StartCoroutine(wait());

		}

	}

	IEnumerator wait() {
		print(Time.time);
		yield return new WaitForSeconds(5);
		Application.LoadLevel(2);
		print(Time.time);
	}

	// Update is called once per frame
	void Update () {

	}
}
