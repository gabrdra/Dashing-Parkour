using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public CharacterController controller;
    public float dashForce = 100f;
    public int maximumDashes = 2;
    public int remainingDashes = 2;
    public bool dashesReseted = false;
    float dashFinishTime;
    public float dashDuration = 0.25f;
    public float cooldownTime = 1.5f;
    private void Update()
    {
        if (dashFinishTime > Time.time)
        {
            controller.Move(Camera.main.transform.forward * dashForce*Time.deltaTime);
            //dashing = false;
        }
        else if (Input.GetKeyDown("mouse 0") && remainingDashes > 0)
        {
            //dashing = true;
            dashFinishTime = Time.time + dashDuration;
            remainingDashes--;
            StartCoroutine(dashCooldown());
        }
    }
    private IEnumerator dashCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        if(remainingDashes >= maximumDashes)
        {
            remainingDashes = maximumDashes;
        }
        else{
            if (!dashesReseted)
            {
                remainingDashes++;
            }
            dashesReseted = false;
        }
    }
}
