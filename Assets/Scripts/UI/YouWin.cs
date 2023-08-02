using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public GameObject completeGame;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D endScreen)
    {   
        
        if(endScreen.tag == "Player")
        {
            completeGame.SetActive(true);
        }
 
    }
}
