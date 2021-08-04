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
            dashScript.remainingDashes = dashScript.maximumDashes;
            Destroy(gameObject);
        }
    }
}
