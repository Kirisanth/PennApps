using UnityEngine;
using System.Collections;


//controls the position variables 
public class Movement : MonoBehaviour{
	
	public bool killCondition = false;
	
	//whenever the script becomes active
	void Start()
	{

	}
	void Update()
	{
		if (killCondition) {
			Destroy(gameObject);
		}
	}


}
