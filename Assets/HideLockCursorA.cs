using UnityEngine;
using System.Collections;

public class HideLockCursorA : MonoBehaviour
{
	void Start ()
	{ Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
	
	} 

	void Update () { Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
		if (Input.GetKey("escape"))
			Application.Quit();
	}


}