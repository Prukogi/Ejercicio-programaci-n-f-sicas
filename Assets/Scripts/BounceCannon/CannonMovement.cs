using UnityEngine;


public class CannonMovement : MonoBehaviour
{
	
	public Transform cannonBodyTransform;
	[SerializeField] private float rotateSpeed;
	

	private float minZAngle = -90f;
	private float maxZAngle = 90f;
    void Update()
    {
		cannonBodyTransform.Rotate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed);
		cannonBodyTransform.Rotate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * rotateSpeed);


		Vector3 currentRotation = cannonBodyTransform.localEulerAngles;
		if (currentRotation.z > 180) currentRotation.z -= 360;

		currentRotation.z = Mathf.Clamp(currentRotation.z, minZAngle, maxZAngle);

		cannonBodyTransform.localEulerAngles = new Vector3(0, currentRotation.y, currentRotation.z);

	}
}
	
	
	

    



   
