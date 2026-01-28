using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour 
{
    // 1
    public GameBehavior GameManager;
    void Start()
    {
        // 2
        GameManager = GameObject.Find("Game Manager")
            .GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item collected!");

            GameManager.Items += 1;
        }
    }
} 