using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            Dash dashScript = other.gameObject.GetComponent<Dash>();
            PlayerStats playerStatsScript = other.gameObject.GetComponent<PlayerStats>();
            playerStatsScript.addScore(100);
            dashScript.remainingDashes = dashScript.maximumDashes;
            dashScript.dashesReseted = true;
            Destroy(gameObject);
        }
    }
}
