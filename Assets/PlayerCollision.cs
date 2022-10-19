using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject thePlayer;
    AIStateManager enemyScript; 
    // Start is called before the first frame update


    

    void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            enemyScript = other.gameObject.GetComponent<AIStateManager>();
            if(enemyScript.powerPell == false && enemyScript.playerCollide == false)
            {
                Destroy(thePlayer);
            }
            if(enemyScript.powerPell == true)
            {
                enemyScript.playerCollide = true;
            }
        
        }
    
    


        Debug.Log("asuigfybasdhyusgrdfuignd");
        if(other.gameObject.tag == "Pellet")
        {
            foreach (GameObject enemy in enemies)
            {
                enemyScript = enemy.GetComponent<AIStateManager>();
                enemyScript.powerPell = true;
                enemyScript.playerCollide = false;
            }

            Debug.Log("asasdas");
        }


        if(other.gameObject.tag == "tictac")
        {

        }

    }
    
}
