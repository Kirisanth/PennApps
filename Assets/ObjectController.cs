using UnityEngine;
using System.Collections;
using Ovr;

public class ObjectController : MonoBehaviour {
	
	public float xCoord;
	public float yCoord;
	public float zCoord;

	public float xRot;
	public float yRot;
	public float zRot;
	Vector3 newPos;
	Vector3 newRot;
	Vector3 up;

	// The start position should be close to the Oculus Position
	void Start () {
		xCoord = GameObject.Find ("OVRPlayerController").transform.position.x+1;
		yCoord = GameObject.Find ("OVRPlayerController").transform.position.y;
		zCoord = GameObject.Find ("OVRPlayerController").transform.position.z+1;

		xRot = GameObject.Find ("OVRPlayerController").transform.rotation.x;
		yRot = GameObject.Find ("OVRPlayerController").transform.rotation.y;
		zRot = GameObject.Find ("OVRPlayerController").transform.rotation.z;

		newPos = new Vector3 (xCoord, yCoord, zCoord);
		GameObject.Find ("Joint").transform.position = newPos;

		newRot = new Vector3 (xRot, yRot, zRot);
		GameObject.Find ("Joint").transform.rotation.SetLookRotation (newRot);

	}

	// Update is called once per frame
	void Update () {

		xCoord = GameObject.Find ("OVRPlayerController").transform.position.x+1;
		yCoord = GameObject.Find ("OVRPlayerController").transform.position.y;
		zCoord = GameObject.Find ("OVRPlayerController").transform.position.z+1;
		
		xRot = GameObject.Find ("OVRPlayerController").transform.rotation.x+1;
		yRot = GameObject.Find ("OVRPlayerController").transform.rotation.y;
		zRot = GameObject.Find ("OVRPlayerController").transform.rotation.z+1;

		newPos = new Vector3 (xCoord, yCoord, zCoord);
		GameObject.Find ("Joint").transform.position = newPos;

		newRot = new Vector3 (xRot, yRot, zRot);
		GameObject.Find ("Joint").transform.rotation.SetLookRotation (newRot);
	
	}
}
