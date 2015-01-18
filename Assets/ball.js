#pragma strict

function Start () {
	// Debug.Log('TEST');
	// Debug.Log(Object);
	// print(gameObject.name);	
}

function Update () {


}

function onCollisionEnter(collision : Collision) {
	Debug.Log("Collision Detected");
}

function onTriggerEnter(collision : Collision) {
	Debug.Log("Passing through Detected");
}