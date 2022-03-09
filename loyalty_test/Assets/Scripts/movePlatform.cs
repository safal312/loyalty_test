using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{
    public Animator platform;
    public string movePlat = "slidey";

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("box"))
        {
            platform.Play(movePlat, 0, 0.0f);
        }
            
    }
}
