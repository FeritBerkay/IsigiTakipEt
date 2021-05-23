using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menzil_uzatıcı : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            spiritPlayer_movement.howFarSpiritCanGo = 30f;
          
        }
        
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            spiritPlayer_movement.howFarSpiritCanGo = 10f;

        }
    }

}
