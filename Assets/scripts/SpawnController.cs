using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
	[SerializeField] private GameObject ballPrefab;

	private GameObject spawnedBall;
	private float count;

	public void SpawnBall()
	{
		if(spawnedBall == null)
			spawnedBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
	}

	public void MoveInput(int dir)
	{
		spawnedBall.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -dir * 100));
	}
    
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("goal"))
        {

			Destroy(gameObject);
        }
    }
   
}
