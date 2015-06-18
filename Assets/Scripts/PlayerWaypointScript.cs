using UnityEngine;
using System.Collections;

public class PlayerWaypointScript : MonoBehaviour {
	
	public GameObject nextWaypoint;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("asdas");
		other.gameObject.SendMessage (Messages.NextWaypoint, nextWaypoint, SendMessageOptions.DontRequireReceiver);
	}
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawLine (transform.position, nextWaypoint.transform.position);
		Gizmos.color = Color.green;
		Gizmos.DrawSphere (transform.position, 1);
	}
	// Update is called once per frame
	void Update () {

	}
}
