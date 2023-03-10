using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
	[SerializeField] private Vector3 direction;
	[SerializeField] private float power;

	private void OnTriggerStay(Collider other)
	{
		other.attachedRigidbody.AddForce(direction * power);
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawLine(transform.position, transform.position + direction.normalized * 2);
		Gizmos.DrawWireSphere(transform.position + direction.normalized * 2,0.5f);
	}
}
