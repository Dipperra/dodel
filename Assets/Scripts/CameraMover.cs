using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _target;
    [SerializeField] private float _x;
    [SerializeField] private float _maxY;
    [SerializeField] private float _z;

    private void LateUpdate()
    {
        //Vector3 newPosition = _target.transform.position; 
        //newPosition.z = _camera.transform.position.z;
        //_camera.transform.position = newPosition;
        float nowY = _target.transform.position.y;
        if (nowY > _maxY)
        {
            _maxY = nowY;
            _camera.transform.position = new Vector3(_camera.transform.position.x, _maxY, _camera.transform.position.z);
        }
    }
}
