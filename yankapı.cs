using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class yankapı : MonoBehaviour
{
    public AudioSource kapıAcılmaSesi;
    int kapıAcılmaBeklemeSuresi = 100;
    private void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "Player")
        {
            if (anahtar.anahtarsayisi > 0)
            {
                kapıAcılmaSesi.Play();
                Thread.Sleep(kapıAcılmaBeklemeSuresi);
                anahtar.anahtarsayisi--;
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
            }

        }

    }
}
