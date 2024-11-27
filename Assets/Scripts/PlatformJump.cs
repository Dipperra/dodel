using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    [SerializeField] private float _velocityUp = 5f;
    [SerializeField] private bool _isTouched = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var playerRigidBody2D = collision.rigidbody;
        Vector2 newVelocity = collision.relativeVelocity;
        //newVelocity.y = (_isTouched) ? (_velocityUp) : (-newVelocity.y);
        //if (newVelocity.y < 0.15)
        //{
        //    newVelocity.y = _velocityUp;
        //}
        //Debug.Log(newVelocity);
        //_isTouched = true;
        //playerRigidBody2D.velocity = newVelocity;

        bool isPlayerDown = transform.position.y >= playerRigidBody2D.gameObject.transform.position.y;
        if (isPlayerDown)
        {
            playerRigidBody2D.velocity = newVelocity;
        }
        else
        {
            newVelocity.y = _velocityUp;
            playerRigidBody2D.velocity = newVelocity;
        }
    }

}
