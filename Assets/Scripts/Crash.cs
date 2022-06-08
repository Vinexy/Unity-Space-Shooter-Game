using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public GameObject explosion;
    public GameObject player_explosion;

    GameObject Random_Asteroid;
    Random_Asteroid control;
    
    void Start()
    {
        Random_Asteroid = GameObject.FindGameObjectWithTag ("game_control");
        control = Random_Asteroid.GetComponent<Random_Asteroid> ();
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "lines")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            control.scoring(10);
        }

        if (col.tag=="Player")
        {
            control.scoring(-10);
            Instantiate(player_explosion, col.transform.position,col.transform.rotation);
            control.gameover();
        }


    }
}
