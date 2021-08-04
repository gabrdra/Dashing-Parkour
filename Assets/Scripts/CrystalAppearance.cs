using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalAppearance : MonoBehaviour
{
    public GameObject player;
    public Material orange;
    public Material purple;
    public Light crystalLight;
    MeshRenderer crystalRenderer;

    private Color orangeColor = new Color(0.831f, 0.392f, 0.098f);
    private Color purpleColor = new Color(0.745f, 0.173f, 1f);
    private void Start()
    {
        crystalRenderer = GetComponentInParent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            crystalRenderer.material = purple;
            crystalLight.color = purpleColor;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            crystalRenderer.material = orange;
            crystalLight.color = orangeColor;
        }
    }
}
