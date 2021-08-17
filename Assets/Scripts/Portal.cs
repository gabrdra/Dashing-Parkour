using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    public GameObject scoreScreen;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            scoreScreen.SetActive(true);
        }
    }
}
