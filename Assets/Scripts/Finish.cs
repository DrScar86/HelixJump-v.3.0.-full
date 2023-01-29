using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public UnityEngine.Object Confetti;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;

        GameObject confetti = (GameObject)Instantiate(Confetti);
        confetti.transform.position = new Vector3(transform.position.x - 7 , transform.position.y - 7, transform.position.z - 7);

        player.ReachFinish();
    }
}