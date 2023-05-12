using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilesCreatedAndPush : MonoBehaviour
{
    [SerializeField] private GameObject _missilePrefab;
    [SerializeField] private Transform _missilesTransform;
    [SerializeField] private float _speed;
    [SerializeField] private float _timeCreator;

    private List<GameObject> _missiles = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(CreatedAndPush());
    }

    IEnumerator CreatedAndPush()
    {
        while (true) 
        {
            _missiles.Add(Instantiate(_missilePrefab, _missilesTransform));
            _missiles[_missiles.Count - 1].GetComponent<Rigidbody2D>().AddForce(Vector2.up * _speed);
            yield return new WaitForSeconds(_timeCreator);
        }
    }
}
