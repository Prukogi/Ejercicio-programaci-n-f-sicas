using UnityEngine;


public class SafeZoneController : MonoBehaviour
{
	public bool SafeZone 
	{ 
		get { return isInSafeZone;}
	}
	
	
	[SerializeField] private bool isInSafeZone = false;
	
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) 
			isInSafeZone = true;	
	}
		
		
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
			isInSafeZone = false;
	}
		
		


}
	
	

    
    


	

	
   
