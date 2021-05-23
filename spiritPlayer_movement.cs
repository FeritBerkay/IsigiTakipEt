using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiritPlayer_movement : MonoBehaviour
{
    private float spiritSpeed;
    public float spiritSpeedC = 8;
    private Vector3 direction;
    public GameObject physicyPlayerBody;
    private Vector2 vectorBetBodies;
    private float lenghtBetBodies;
    public static float howFarSpiritCanGo = 10f;
    private float spiritSpeedController;
    private Vector2 whichDirectionController;
    private float whichDirectionLenght;
    private bool isSpiritGettinCloser;
    public float gettingSlowerSharpness = 2;
    private float gettingSlowerValue;
  //  public GameObject bullet;      //Mermi ile alakalý
  //  private Vector3 bulletWay;      //Mermi ile alakalý
  //  public static Vector3 bulletWayTransitionValue;       //Mermi il alakalý

    void Start()
    {
        spiritSpeed = spiritSpeedC;
     //   bulletWay = new Vector3(1f, 0f, 0f);    //Mermi ile alakalý
    }


    void Update()
    {
        // Hareket Kodalarý
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        transform.position += direction * spiritSpeed * Time.deltaTime;
        if(direction.x<0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (direction.x >0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        //--------------------

        // Vücuttan Uzaklaþma Mekaniði
        vectorBetBodies = transform.position - physicyPlayerBody.transform.position;
        lenghtBetBodies = Mathf.Sqrt(vectorBetBodies.x * vectorBetBodies.x + vectorBetBodies.y * vectorBetBodies.y);
        if (lenghtBetBodies>howFarSpiritCanGo)
        {
            if (isSpiritGettinCloser)
            {
                spiritSpeed = spiritSpeedC;
            }
            else
            {
                spiritSpeedController = (lenghtBetBodies - howFarSpiritCanGo);
                gettingSlowerValue = spiritSpeedController * gettingSlowerSharpness;
                if ( gettingSlowerValue > spiritSpeedC)
                {
                    gettingSlowerValue = spiritSpeedC - 0.01f;
                }
                spiritSpeed = spiritSpeedC - gettingSlowerValue;
            }

        }else
        {
            spiritSpeed = spiritSpeedC;
        }
        whichDirectionController.x = vectorBetBodies.x + direction.x;
        whichDirectionController.y = vectorBetBodies.y + direction.y;
        whichDirectionLenght = Mathf.Sqrt(whichDirectionController.x * whichDirectionController.x + whichDirectionController.y * whichDirectionController.y);
        if ( whichDirectionLenght>lenghtBetBodies)
        {
            isSpiritGettinCloser = false;
        }else if (whichDirectionLenght<lenghtBetBodies)
        {
            isSpiritGettinCloser = true;
        }
        // Merminin Yönünü Bulma
        /*
        if (Mathf.Abs(direction.x) > 0.01f && Mathf.Abs(direction.y) > 0.01f)
        {
            if (direction.x > 0.01)
            {
                if (direction.y > 0.01)
                {
                    bulletWay.x = 1f;
                    bulletWay.y = 1f;
                }
                else if (direction.y < -0.01)
                {
                    bulletWay.x = 1f;
                    bulletWay.y = -1f;
                }
            }
            else if (direction.x < -0.01)
            {
                if (direction.y > 0.01)
                {
                    bulletWay.x = -1f;
                    bulletWay.y = 1f;
                }
                else if (direction.y < -0.01)
                {
                    bulletWay.x = -1f;
                    bulletWay.y = -1f;
                }
            }
        }
        if (Mathf.Abs(direction.x)>0.01 && Mathf.Abs(direction.y)<0.01)
        {
            if (direction.x > 0.01)
            {
                bulletWay.x = 1f;
                bulletWay.y = 0f;
            }
            else if (direction.x < 0.01)
            {
                bulletWay.x = -1f;
                bulletWay.y = 0f;
            }
        }
        if (Mathf.Abs(direction.x) < 0.01 && Mathf.Abs(direction.y) > 0.01)
        {
            if (direction.y > 0.01)
            {
                bulletWay.x = 0f;
                bulletWay.y = 1f;
            }
            else if (direction.y < 0.01)
            {
                bulletWay.x = 0f;
                bulletWay.y = -1f;
            }
        }
        //-------------------
        */
        //bullet spawner
       /*
        if (spiritEnvirementB.spiritMana > 1f)
        {
            if (Input.GetKeyDown(KeyCode.X) )
            {
                Instantiate(bullet, transform.position, Quaternion.Euler(0,0,0));
                bulletWayTransitionValue = bulletWay;
            }
        }
        */
        //-------------------
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            spiritEnvirementB.mustTurnSpirit = true;
            Debug.Log("oldu");
        }
    }
}
