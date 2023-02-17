using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public void StartJumping() {
        transform.LeanMoveLocal(new Vector2(270, 40), 1).setEaseOutQuart().setLoopPingPong();
        // 0,0 is center of the screen

    }
}
