using UnityEngine;
using System;
using TMPro;

public class ProyectileController : MonoBehaviour
{

	private UImanager uimanager;
	void Start()
    {
		uimanager = FindFirstObjectByType<UImanager>();
    }
    

  

	private void OnCollisionEnter(Collision collision)
	{
		if(uimanager != null)
		uimanager.AddBounce();
	}
}
		
   

	
	
	





   
