using UnityEngine;
using System;

public class LaserRayController : MonoBehaviour
{
    public GameManager gameManager;
    public SafeZoneController safeZoneScript;
    public Transform player;
    
    
    RaycastHit hit;
    public Transform turret1;
    public Transform turret2;
    public LineRenderer lineRenderer;
    public bool laserActive = true;
    
    
    public Color dangerColor = Color.red;
    public Color safeColor = Color.green;


	private void Start()
	{
        lineRenderer.positionCount = 2;
	}
	void Update()
    {
		Color currentColor = safeZoneScript.SafeZone ? safeColor : dangerColor;
		lineRenderer.material.color = currentColor;

		lineRenderer.SetPosition(0, turret1.position);
		lineRenderer.SetPosition(1, turret2.position);



		if (laserActive)
		{
			if (Physics.Raycast(turret1.position, turret2.position - turret1.position, out hit))
			{
				
				if (hit.collider.CompareTag("Player") && safeZoneScript.SafeZone == false)
				{
					gameManager.LifeLost();
				}
			}
		}
	}
}


        
        
            
            
            
            
        
        



        
            
        





	
	

    
            





   
