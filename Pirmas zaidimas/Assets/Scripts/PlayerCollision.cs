using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment playerMovment;
    private void OnCollisionEnter(Collision collisionInfo, bool IsDead)
    {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            IsDead = true;
            playerMovment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
