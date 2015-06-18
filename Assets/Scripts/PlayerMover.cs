using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	public int maxSpeed;
	Vector3 DesiredVelocity;
	Vector3 targetPosition;
	Vector3 Steering;
	public float maxSteering;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	protected virtual void AddVelocity(Vector3 newVelocity)
	{
		DesiredVelocity += newVelocity;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Steering = DesiredVelocity - rigidbody.velocity;
		GetComponent<Rigidbody>().velocity = DesiredVelocity;
		if(DesiredVelocity.sqrMagnitude > maxSpeed * maxSpeed)
		{
			DesiredVelocity = DesiredVelocity.normalized * maxSpeed;
		}
		//		if(Steering.sqrMagnitude > maxSteering * maxSteering)
		//		{
		//			Steering = Steering.normalized * maxSteering;
		//		}
	}
}
