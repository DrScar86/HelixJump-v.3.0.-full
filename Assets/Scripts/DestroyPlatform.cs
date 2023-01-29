using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public Object Destroyer;

    public bool IsBlockDestroyed { get; private set; }

    private void OnTriggerExit(Collider other)
    {
        GameObject destroyer = (GameObject)Instantiate(Destroyer);
        destroyer.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
        Destroy(gameObject);
    }
}