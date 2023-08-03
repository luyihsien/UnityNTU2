using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Getscore : MonoBehaviour
{
    int score=0;
    [SerializeField] float delayDestroy =0.5f;
    [SerializeField] TextMeshProUGUI scoreText;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision!!");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="Positive"){
            score+=1;
            Destroy(other.gameObject,delayDestroy);
            scoreText.text=$"Score : {score}";
            Debug.Log("Score : "+score);
        }else if (other.tag=="Negative"){
            score-=1;
            Destroy(other.gameObject,delayDestroy);
            scoreText.text=$"Score : {score}";
            Debug.Log("Score : "+score);
        }
    }

}
