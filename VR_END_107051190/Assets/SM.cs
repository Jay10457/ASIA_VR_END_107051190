using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SM : MonoBehaviour
{
    [SerializeField] int scoreIn;
    [SerializeField] int score;
    [SerializeField] TMP_Text Text;
    [SerializeField] AudioSource _AS;
    [SerializeField] AudioClip[] audioArray;

    private void Awake()
    {
        _AS = GetComponent<AudioSource>();
    }
    private void Voice()
    {
        _AS.clip = audioArray[Random.Range(0, audioArray.Length)];
        _AS.PlayOneShot(_AS.clip, Random.Range(1f, 10f));
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other);
        
        if (other.tag == "gold")
        {
            scoreIn = 100;
            Debug.Log("gold!");
            AddScore();
            Voice();


        }
        if (other.tag == "silver")
        {
            scoreIn = 50;
            Debug.Log("silver!");
            AddScore();
            Voice();

        }
        if (other.tag == "normal")
        {
            scoreIn = 10;
            Debug.Log("normal!");
            AddScore();
            Voice();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        scoreIn = 0;
    }
    private void AddScore()
    {
        score += scoreIn;
        Text.text = "Score : " + score;
        Debug.Log(score);
    }
}
