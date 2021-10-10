using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
	public SpawnController spawnController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawnable" && !other.isTrigger)
        {
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);
            spawnController.MakanAnim();
        }
    }
}
