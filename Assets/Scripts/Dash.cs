using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public CharacterController controller;
    public float dashForce = 100f;
    public int maximumDashes = 2;
    public int remainingDashes = 2;
    float dashFinishTime;
    public float cooldownTime = 1.5f;
    private void Update()
    {
        if (dashFinishTime > Time.time)
        {
            controller.Move(Camera.main.transform.forward * dashForce);
            //dashing = false;
        }
        else if (Input.GetKeyDown("mouse 0") && remainingDashes > 0)
        {
            //dashing = true;
            dashFinishTime = Time.time + 0.25f;
            remainingDashes--;
            StartCoroutine(dashCooldown());
        }
    }
    private IEnumerator dashCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        if(remainingDashes == maximumDashes)
        {
            yield return null;
        }
        remainingDashes++;
    }
}
