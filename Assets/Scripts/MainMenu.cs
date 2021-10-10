using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 public void menu1(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }   
 public void menu2(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
 }   
 public void menu3(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
 }   
 public void menu4(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
 }   
 public void menu5(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
 }   
 public void menu6(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
 }   
 public void menu7(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
 }   
 public void menu8(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
 }
 public void menu9(){
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
 }
public void exit(){
	 SceneManager.LoadScene("menu10");
 } 
 public void endGame(){
	 Application.Quit();
 }
}
