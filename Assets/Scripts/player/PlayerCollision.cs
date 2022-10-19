using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject[] enemies;
    public GameObject thePlayer;
    AIStateManager enemyScript;
    List<AIStateManager> list = new List<AIStateManager>();


    // Start is called before the first frame update

    void Start()
    {
        foreach (GameObject enemy in enemies)
        {
            list.Add(enemy.GetComponent<AIStateManager>());
        }
    }

  
    void OnTriggerEnter(Collider other) 
    {

        if(other.gameObject.tag == "Enemy")
        {
            enemyScript = other.gameObject.GetComponent<AIStateManager>();
            if(enemyScript.powerPell == false && enemyScript.playerCollide == false)
            {
                gameManager.WaitForScene();
                Destroy(thePlayer);
            }
            if(enemyScript.powerPell == true)
            {
                enemyScript.playerCollide = true;
            }
        
        }
    
        if(other.gameObject.tag == "Pellet")
        {
            foreach (AIStateManager manager in list)
            {
                manager.powerPell = true;
                manager.playerCollide = false;
            }

            Debug.Log("asasdas");
            Destroy(other.gameObject);
        }


        if(other.gameObject.tag == "TicTac")
        {
            Destroy(other.gameObject);
            gameManager.score += 1;

        }

    }

    
}


