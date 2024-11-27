using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _left;
    [SerializeField] private Sprite _right;
    [SerializeField] private float _sensitivityForFlip = 0.05f;
    
    private bool _isDirectionLeft = true;
    private bool _previousDirectionLeft = true;
    
    private const string AxisName = "Horizontal";
    
    
    private void Update()
    {
        float diffX = Input.GetAxis(AxisName);
        
        // С гравитацией не работает
        // _rigidbody2D.MovePosition(_rigidbody2D.position + diff * (_speed * Time.deltaTime));
        
        _rigidbody2D.AddForce(new Vector2(diffX*_speed*Time.deltaTime, 0), ForceMode2D.Impulse);
        
        
        
        if (diffX > _sensitivityForFlip)
            _isDirectionLeft = false;
        else if (diffX < -_sensitivityForFlip)
            _isDirectionLeft = true;
        // _spriteRenderer.flipX = !_isDirectionLeft;

        if (_isDirectionLeft != _previousDirectionLeft)
        {
            _spriteRenderer.sprite = (_isDirectionLeft) ? _left : _right;
        }
        
        _previousDirectionLeft = _isDirectionLeft;
    }

    private void onCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log($"Hit {collision2D.gameObject.name}");
    }
}
