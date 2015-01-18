using UnityEngine;
using System.Collections;

public class ball2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.WakeUp();

	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(Vector3.left * 50);
        rigidbody.AddForce(Vector3.up * 60);
        rigidbody.AddForce(Vector3.forward * 80);
	}

	void FixedUpdate() {
        
    }
	void OnCollisionEnter(Collision collisionInfo)
	{
	    print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
	    print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
	    print("Their relative velocity is " + collisionInfo.relativeVelocity);
	}

	void OnCollisionStay(Collision collisionInfo)
	{
	    print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
	}

	void OnCollisionExit(Collision collisionInfo)
	{
	    print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
	}

}
