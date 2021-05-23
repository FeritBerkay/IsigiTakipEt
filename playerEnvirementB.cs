using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEnvirementB : MonoBehaviour
{
    public GameObject bodyCamera;
    public GameObject bodyCamera_CMcam;
    public GameObject rebornPoint;
    private Vector3 transformDes;
    private Rigidbody2D rb2d;
    public GameObject portal1;
    public GameObject portal2;
    public GameObject textAcma;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag == "fallZone")
        {
            transformDes = rebornPoint.transform.position - transform.position;
            transform.position = transform.position + transformDes;
            bodyCamera.transform.position = bodyCamera.transform.position + transformDes;
            bodyCamera_CMcam.transform.position = bodyCamera_CMcam.transform.position + transformDes;
            rb2d.velocity = new Vector2(0f, 0f);
            spiritEnvirementB.mustTurnSpirit = true;
            player_movement.canMove = false;
        }
        if (collision.tag =="portal")
        {
            transform.position = portal2.transform.position;
        }
        if (collision.tag == "textAcýlýs")
        {
            textAcma.SetActive(true);
        }
    }
}
