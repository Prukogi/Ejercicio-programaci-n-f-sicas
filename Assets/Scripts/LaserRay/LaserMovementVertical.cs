using UnityEngine;
using System;
using TMPro;

public class LaserMovementVertical : MonoBehaviour
{

		public TextMeshProUGUI timeCounter;
		public Transform turret;
		[SerializeField] private float turretSpeed = 5f;
		[SerializeField] private float minSpeed = 5f;
		[SerializeField] private float maxSpeed = 15f;

		private float changeInterval = 5f;
		private float timer = 0f;

		private float pointA = -50f;
		private float pointB = 50f;

		private bool movingToA = true;

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
				turret.Translate(Vector3.forward * turretSpeed * Time.deltaTime, Space.World);
				if (turret.position.z >= pointB)
					movingToA = false;
			}
			else
			{
				turret.Translate(Vector3.back * turretSpeed * Time.deltaTime, Space.World);
				if (turret.position.z <= pointA)
					movingToA = true;
			}

			
	}
	

}
