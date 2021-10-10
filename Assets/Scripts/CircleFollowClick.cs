using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CircleFollowClick : MonoBehaviour
{
   public LayerMask mask;
   public float speed = 10f;
    public float spawnTime = 3f;
   Vector2 lastClickedPos;
   bool moving;
   public List<GameObject> objToDestroy;
   public SpawnController spawnObjects;
    bool playerInRange;
	public AudioClip makan;

    private AudioSource audioPlayer;
	void Start()
    {
         audioPlayer = GetComponent<AudioSource>();
    }
	
	private void OnTriggerEnter2D(Collider2D other){
		if(other.isTrigger == false){
			playerInRange = true;
		}
		
		Destroy(other.gameObject);
		Debug.Log("Nambah?" + score);
		makanSfx();
		IncrementScore();
		Debug.Log("delay");
		Invoke("delay", 3);
		
	//	}
	}
	public void delay(){
		spawnObjects.respawn();
	}
	 private int score;
	 public void IncrementScore()
    {

        score++;
		
    }
	public void makanSfx()
    {
        audioPlayer.PlayOneShot(makan);
    }
	public int Score
    {
        get { return score; }
    }	
   private void Update(){
	   if(Input.GetMouseButtonDown(0)){
		   lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);		   
		   moving = true;

	   }   
	   if(moving && (Vector2)transform.position != lastClickedPos){
		   float step = speed * Time.deltaTime;
		   transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
	   }
	   else{
		   moving = false;
	   }
	//   Rotate();
   }
/* 	void Rotate(){
		if(dirX == 0)
	} */
}
