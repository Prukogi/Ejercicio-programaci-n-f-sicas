using UnityEngine;


public class FireController : MonoBehaviour
{
	
    public Transform barrelTransform;
    public Transform proyectileSpawn;
    public GameObject proyectile;
    
    [SerializeField] private float firePower;
    [SerializeField] private float maxFirePower = 20f;
    [SerializeField] private float chargeRate = 5f;
	private bool OpenFire = false;
	
	void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            firePower += Time.deltaTime * chargeRate;
            firePower = Mathf.Clamp(firePower, 0f, maxFirePower);
			print(firePower);
            if (Mathf.Approximately(firePower, maxFirePower))
            {
                print("Maximun fire power reached!");
            }
        }
		if (Input.GetKeyUp(KeyCode.Space))
		{
			OpenFire = true;
		}
	}

                

	private void FixedUpdate()
	{
		if (OpenFire)
		{
			OpenFire = false;
			GameObject newProyectile = Instantiate(proyectile, proyectileSpawn.position, proyectileSpawn.rotation);

			Rigidbody rb = newProyectile.GetComponent<Rigidbody>();
			rb.AddForce(proyectileSpawn.up * firePower, ForceMode.Impulse);
			rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, 40f);

			print("Opening fire!");
			firePower = 0f;
			Destroy(newProyectile, 5f);
            
		}
	}
}
            
		








