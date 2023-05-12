using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSides : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _leftWallCollider;
    [SerializeField] private BoxCollider2D _rightWallCollider;

    private void Awake()
    {
        float screenWidth = Game.Instance.screenWidth;

        _leftWallCollider.transform.position = new Vector3(-screenWidth - _leftWallCollider.size.x/2, 0f, 0f);
        _rightWallCollider.transform.position = new Vector3(screenWidth + _rightWallCollider.size.x/2, 0f, 0f);

        Destroy(this);
    }
}
