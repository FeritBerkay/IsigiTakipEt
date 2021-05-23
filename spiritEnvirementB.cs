using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiritEnvirementB : MonoBehaviour
{
    public static bool mustTurnSpirit = false;
  //  public static float spiritMana;     //Mermi ile alakalý
  //  public float maxMana = 4;           //Mermi ile alakalý
    public Animator spiritStateControl;

  //  private float timecontrol = 1f;     //Mermi ile ilgili
    private void Start()
    {
      //  spiritMana = maxMana;    //Mermi ile ilgili
    }
    void Update()
    {
        /*
        spiritStateControl.SetFloat("spiritMana", spiritMana);
        if ( Input.GetKeyDown(KeyCode.X) && spiritMana > 1f && dimensionControl.isTurned == true)
        {
            spiritMana -= 1;
        }
        */        //Mermi ile ilgili
    }
    private void FixedUpdate()
    {
        /*
        if ( spiritMana <maxMana)
        {
            spiritMana += timecontrol*Time.fixedDeltaTime;
        }
        if ( spiritMana <0)
        {
            spiritMana = 0f;
        }
        */            //Mermi ile ilgili
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spiritual_wall")
        {
            mustTurnSpirit = true;
        }
    }
}
