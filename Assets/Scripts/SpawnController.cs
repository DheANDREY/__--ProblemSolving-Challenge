using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class SpawnController : MonoBehaviour
{
	public int numberSpawn;
	public List<GameObject> spawnPool;
	public GameObject quad;
	public CircleFollowClick cfc;
	public float spawnTime = 3f;
	Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
	
    }
	private void Update(){
		
	}
	public void spawnObjects(){
		destroyObjects();
		int randomItem = 0;
		GameObject toSpawn;
		MeshCollider c = quad.GetComponent<MeshCollider>();
		float screenX, screenY;
		Vector2 pos;
		
		for(int i = 0; i < numberSpawn; i++){
			randomItem = Random.Range(0, spawnPool.Count);
			toSpawn = spawnPool[randomItem];
			
			screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
			screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
			pos = new Vector2(screenX, screenY);
			
			Instantiate(toSpawn, pos, toSpawn.transform.rotation);
		}
	}
	public void respawn(){	
		int randomItem = 0;
		GameObject toSpawn;
		MeshCollider c = quad.GetComponent<MeshCollider>();
		float screenX, screenY;
		
		Vector2 pos;	
			randomItem = Random.Range(0, spawnPool.Count);
			toSpawn = spawnPool[randomItem];
			
			screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
			screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
			pos = new Vector2(screenX, screenY);
			//StartCoroutine(hidup());
		//	Thread.Sleep(detik);
			Instantiate(toSpawn, pos, toSpawn.transform.rotation);
		
	}
	void awake(){
		anim = GetComponent<Animator>();
	}
	int detik = 3000;
	public void delay(){	
		
		Thread.Sleep(detik);
	}
	/* IEnumerator hidup(GameObject prefab){
		yield return new WaitForSecond(3);
	} */
	

	public void destroyObjects(){
		foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable")){
			Destroy(o);		
		}
	}
	public void MakanAnim(){
		anim.SetTrigger("makan_kanan");
	}
}
