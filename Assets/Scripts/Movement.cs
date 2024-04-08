using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private BorderClamp _positionClampX;
    private Rigidbody _rigidbody;
    [SerializeField]
    private GameManager gameManager;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void BorderController()
    {
        if (transform.position.x > _positionClampX.GetMaximum)
        {
            _rigidbody.velocity = Vector3.zero;
        }
        if (transform.position.x < _positionClampX.GetMinimum)
        {
            _rigidbody.velocity = Vector3.zero;
        }
        Vector3 currentPosition = transform.position;
        float clampX = Mathf.Clamp(currentPosition.x, _positionClampX.GetMinimum, _positionClampX.GetMaximum);
        transform.position = new Vector3(clampX, transform.position.y, transform.position.z);
    }
    void Update()
    {
        BorderController();
        if (gameManager.isGameOver == false)
        {
            float movement = Input.GetAxis("Horizontal");
            _rigidbody.velocity = new Vector3(movement, 0, 0) * speed;
        }
    }
}
[Serializable]
public class BorderClamp
{
    [SerializeField]
    private float _minimal;
    [SerializeField]
    private float _maximum;

    public float GetMinimum => _minimal;
    public float GetMaximum => _maximum;
}