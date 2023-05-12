using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour, FactoryMeteor
{
    [SerializeField] private List<GameObject> _meteors;
    [SerializeField] private GameObject _meteorPrefab;
    [SerializeField] private Color[] _newColor;
    [Space]
    [SerializeField] private int _minMeteorValue;
    [SerializeField] private int _maxMeteorValue;
    [Space]
    [SerializeField] private float _minScale;
    [SerializeField] private float _maxScale;
    private MeteorSpawner _meteorSpawner;
    private Transform _transform;
    private float _widthScreen;

    void Start()
    {
        GetValues();
        CreateMeteor(_transform);
    }

    public void GetValues()
    {
        _transform = transform;
        _widthScreen = Screen.width;
        _meteorSpawner = GetComponent<MeteorSpawner>();
    }

    public void CreateMeteor(Transform transform, int countMeteor = 1)
    {
        for (int i = 0; i < countMeteor; i++)
        {
            _meteors.Add(Instantiate(_meteorPrefab, this.transform));
            VeiwMeteor(_meteors[_meteors.Count - 1]);
        }
    }

    private void VeiwMeteor(GameObject meteor)
    {
        int meteorValue = Random.Range(_minMeteorValue, _maxMeteorValue);
        meteor.GetComponent<MeteorLife>().GetValues(meteorValue, _meteorSpawner);
        meteor.GetComponent<SpriteRenderer>().color = _newColor[Random.Range(0, _newColor.Length)];
        meteor.transform.position = new Vector2(SetPositionX(), transform.position.y);
        ChangeScale(meteorValue, meteor.transform);
    }

    private void ChangeScale(int meteorValue, Transform meteor)
    {
        ScaleMeteor scale = new ScaleMeteor();
        scale.ChangeScale(_minScale, _maxScale, _minMeteorValue, _maxMeteorValue, meteorValue, meteor);
    }

    private float SetPositionX()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, _widthScreen), 0f, 0f)).x;
    }
}
