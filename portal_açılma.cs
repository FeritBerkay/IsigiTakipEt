using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_açılma : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
    }
    public void Update()
    {
        if(anahtar.anahtarsayisi >= 2)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}
