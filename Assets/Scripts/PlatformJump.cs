using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    [SerializeField] private float _velocityUp = 5f;
    [SerializeField] private bool _isTouched = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var playerRigidBody2D = collision.rigidbody;
        Vector2 newVelocity = collision.relativeVelocity;
        newVelocity.y = (_isTouched) ? (_velocityUp) : (-newVelocity.y);
        _isTouched = true;
        playerRigidBody2D.velocity = newVelocity;
    }

}
