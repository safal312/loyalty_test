using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class boxThrow : MonoBehaviour
{
    public Rigidbody rb;
    public float strength = 2000;
    public XRGrabInteractable box;
    public void Throw()
    {
        Vector3 direction = box.GetOldestInteractorSelecting().transform.forward;
        direction *= strength;

        box.enabled = false;

        rb.AddForce(direction);

        StartCoroutine(reenable());

        
    }

    IEnumerator reenable()
    {
        yield return new WaitForSeconds(2);

        box.enabled = true;
    }

    // Start is called before the first frame update
}
