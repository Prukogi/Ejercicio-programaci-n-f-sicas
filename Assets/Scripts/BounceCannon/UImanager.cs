using System;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI bounceCounterText;
    private int bounceCount = 0;
	void Start()
    {
        bounceCounterText.text = "0";
    }

    
    void Update()
    {
        
    }
    public void AddBounce() 
    {
        bounceCount++;
        bounceCounterText.text = bounceCount.ToString();
    }
}





	





