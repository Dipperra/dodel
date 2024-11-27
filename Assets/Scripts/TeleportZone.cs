using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportZone : MonoBehaviour
{
    [SerializeField] private float _xForTeleportation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 newPosition = collision.transform.position;
            newPosition.x = _xForTeleportation;
            collision.transform.position = newPosition;
        }
    }
}
