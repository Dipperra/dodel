using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _velocityUp;
    [SerializeField] private Rigidbody2D _ballsRigidBody;


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector2 newVector = new Vector2(_ballsRigidBody.velocity.x, _velocityUp);
            _ballsRigidBody.velocity = newVector;
        }
    }
}
