using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// * Use this Controller by attaching it to an empty object in the scene
public class ControllerTCLR : MonoBehaviour {
	
	[HideInInspector]
	public bool isTop = false;
	[HideInInspector]
	public bool isCenter = false;
	[HideInInspector]
	public bool isLeft = false;
	[HideInInspector]
	public bool isRight = false;

	public void OnTopDown() {
		isTop = true;
	}
	public void OnCenterDown() {
		isCenter = true;
	}
	public void OnLeftDown() {
		isLeft = true;
	}
	public void OnRightDown() {
		isRight = true;
	}

	public void OnTopUp() {
		isTop = false;
	}
	public void OnCenterUp() {
		isCenter = false;
	}
	public void OnLeftUp() {
		isLeft = false;
	}
	public void OnRightUp() {
		isRight = false;
	}
}
