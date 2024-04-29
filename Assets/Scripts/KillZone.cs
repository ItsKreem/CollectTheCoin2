using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        GameObject.Destroy(collider2D.gameObject);
    }
}
