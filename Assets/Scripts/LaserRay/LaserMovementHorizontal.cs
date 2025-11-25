using System;
using TMPro;
using UnityEngine;

public class LaserMovementHorizontal : MonoBehaviour
{
	public TextMeshProUGUI timeCounter;
	public Transform turret;
    [SerializeField] private float turretSpeed = 5f;
	[SerializeField] private float minSpeed = 5f;
	[SerializeField] private float maxSpeed = 15f;

	private float changeInterval = 5f;
	private float timer = 0f;

	private float pointA = -52f;
    private float pointB = 52f;
    
    private bool movingToA = true; // True = moving to A, False = moving to B
    void Update()
    {
		timer += Time.deltaTime;

		if (timer >= changeInterval)
		{
			turretSpeed = UnityEngine.Random.Range(minSpeed, maxSpeed);
			timer = 0f;
		}
		if (movingToA)
        {
            turret.Translate(Vector3.left * turretSpeed * Time.deltaTime);
            if (turret.position.x <= pointA)
                movingToA = false;
        }
        else 
        {
            turret.Translate(Vector3.right * turretSpeed * Time.deltaTime);
			if (turret.position.x >= pointB)
                movingToA = true;
		}
    }
}
    

    
			
			
            
            


        
		
        




	
	
	




   
