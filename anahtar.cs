using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class anahtar : MonoBehaviour
{
    public static int anahtarsayisi;
    public AudioSource anahtarSesi;
    
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            anahtarsayisi++;
            anahtarSesi.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "spiritual_player")
        {
            anahtarsayisi++;
            anahtarSesi.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
       
   


}