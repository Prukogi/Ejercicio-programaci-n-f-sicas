using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public TextMeshProUGUI timeCounter;
	public SafeZoneController safeZoneScript;

	private Vector3 startPoint = new Vector3(-0.8f, 0.7f, 0);
	private float timeSurvived = 0f;
	private int lifes = 1;
    void Update()
    {
		if (safeZoneScript.SafeZone == false)
		{
			timeSurvived += Time.deltaTime;
			timeCounter.text = "Time: " + timeSurvived.ToString("F2") + "s";
		}
		else 
		{
			timeSurvived += 0f;
			timeCounter.text = "Time: " + timeSurvived.ToString("F2") + "s";
		}
	}
			

			

	public void LifeLost()
	{
		lifes--;
		if (lifes <= 0)
		{
			Debug.Log("You got caught, restarting");
			player.transform.position = startPoint;
			lifes = 1;
			timeSurvived = 0f;
		}
	}
}
			



			
		 
		
			
		







	

    

	

	
   
