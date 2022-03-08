using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCollider : MonoBehaviour
{
    public Transform lens;
    public Text text;
    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    print(hit);
    //}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Ray"))
        {
            
            Vector3 direction = lens.position - transform.position;
            RaycastHit hit;

            if (Physics.Raycast(transform.position, direction.normalized, out hit, 1000))
            {
                text.text = hit.collider.name;
                print(hit.collider.name);
                //hit.collider.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.blue;
                other.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                if (hit.collider.name == "ViewVisual") FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
