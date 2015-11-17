using UnityEngine;
using System.Collections;

public class TestUnitAction : MonoBehaviour {

	// * The unit accesses controler by searching in the object that contains a controller
	public GameObject ctrlObj;
	public float moveSpeed = 2.5f;

	// * The controller
	private ControllerTCLR ctrl;
	private Transform trans;

	void Start () {
		trans = GetComponent<Transform>( );
		ctrl = ctrlObj.GetComponent<ControllerTCLR>( );
	}
	
	void Update() {
		float dT = Time.deltaTime;
		float dD = moveSpeed * dT;
		if( ctrl.isTop )
			trans.position += new Vector3( 0, dD, 0 );
		if( ctrl.isCenter )
			trans.position += new Vector3( 0, dD * -1, 0 );
		if( ctrl.isLeft )
			trans.position += new Vector3( dD * -1, 0, 0 );
		if( ctrl.isRight )
			trans.position += new Vector3( dD, 0, 0 );
	}
}
