using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
	public Transform cannon;
	public Vector3 offset = new Vector3(0, 2.5f, -4f);
	
	void LateUpdate()
	{
		transform.position = cannon.position + offset;
		transform.LookAt(cannon);
	}
}












