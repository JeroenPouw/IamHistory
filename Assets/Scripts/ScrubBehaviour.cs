using UnityEngine;
using System.Collections;

public class ScrubBehaviour : MonoBehaviour {
	
	Vector3 DesiredVelocity;
	Vector3 targetPosition;
	Vector3 Steering;
	public float maxSteering = 10;
	Transform patrol;
	public int maxSpeed = 10;
	
	
	// Use this for initialization
	void Awake () {
		patrol = GameObject.FindWithTag ("Leader").transform;	
	}
	

	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log (patrol);
		if(patrol != null)
		{
			targetPosition = patrol.transform.position;
			DesiredVelocity = targetPosition - this.GetComponent<Rigidbody>().position;
			DesiredVelocity = DesiredVelocity.normalized * maxSpeed;
			Steering = DesiredVelocity - GetComponent<Rigidbody>().velocity;
			if(Steering.sqrMagnitude > maxSteering * maxSteering)
			{
				Steering = Steering.normalized * maxSteering;
			}
			
			
			
			gameObject.SendMessage(Messages.AddVelocity, Steering, SendMessageOptions.DontRequireReceiver);
		}
	}
}
