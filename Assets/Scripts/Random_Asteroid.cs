using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Random_Asteroid : MonoBehaviour
{
    public GameObject asteroid;

    public Vector3 randomPos;

    public float start_waiting;
    public float create_waiting;
    public float loop_waiting;

    public Text texty;
    public Text govertext;
    public Text restart_text;

    bool gameovercontrol = false;
    bool restart = false;
    
    int score;

    void Start()
    {
        score = 0;
        texty.text = "SCORE: " + score;
        score = 0;
        StartCoroutine(random_create());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("level1");
        }
    }

    IEnumerator random_create()
    {
        yield return new WaitForSeconds(start_waiting);
        while (true) {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(loop_waiting);
            }
            if (gameovercontrol)
            {
                restart = true;
                break;

            }
            yield return new WaitForSeconds(create_waiting);

            
        }
        
    }
    public void scoring(int comingscore)
    {
        score += comingscore;
        texty.text = "SCORE: " + score;

    }
    public void gameover()
    {
        govertext.text = "GAME OVER !";
        restart_text.text = "For Restart Press R :)";
        gameovercontrol = true;
        
    }
   
}
