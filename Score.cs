using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text win;
    public Text score;
    private int ChangeScore = 0;
    void Start ()
    {
        score.text = ChangeScore.ToString();
        win.text = ("");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            ChangeScore += 1;
            score.text = ChangeScore.ToString();
            Destroy(collision.collider.gameObject);
        }

        if (ChangeScore == 1)
        {
            if (collision.collider.tag == "Bullet")
            {
                if (Input.GetKey(KeyCode.V))
                ChangeScore = 4;
                score.text = ChangeScore.ToString();
                Destroy(collision.collider.gameObject);
            }
        }



        if(ChangeScore == 4)
        {
            win.text =("You Win Created by Gage Langlais");
        }
    
    }
}
