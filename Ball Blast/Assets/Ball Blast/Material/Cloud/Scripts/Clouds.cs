using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [System.Serializable] class Cloud
    {
        public MeshRenderer meshRenderer = null;
        public float speed = 0f;
        [HideInInspector] public Vector2 offset;
        [HideInInspector] public Material mat;
    }

    [SerializeField] private Cloud[] _allCloud;
    private int _count = 0;
    
    private void Start()
    {
        _count = _allCloud.Length;
        for (int i = 0; i < _count; i++)
        {
            _allCloud[i].offset = Vector2.zero;
            _allCloud[i].mat = _allCloud[i].meshRenderer.material;
        }
    }

    
    private void Update()
    {
        for (int i = 0; i < _count; i++)
        {
            _allCloud[i].offset.x += _allCloud[i].speed * Time.deltaTime;
            _allCloud[i].mat.mainTextureOffset = _allCloud[i].offset;
        }
    }
}
