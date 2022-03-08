using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayController : MonoBehaviour
{
    public Transform lens;

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {

            Vector3 direction = other.transform.position - lens.position;
            RaycastHit hit;

            if (Physics.Raycast(lens.position, direction.normalized, out hit, 1000))
            {
                print(hit.collider.name);
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    print(hit);
    //}
}
