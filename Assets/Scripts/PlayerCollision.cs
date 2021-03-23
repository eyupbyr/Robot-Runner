using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : Player
{
    [SerializeField] PlayerMovement playerMovement = default;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
