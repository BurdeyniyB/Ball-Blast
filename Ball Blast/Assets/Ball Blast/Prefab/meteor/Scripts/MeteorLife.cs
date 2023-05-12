using UnityEngine;
using TMPro;

public class MeteorLife : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countHealthText;
    [SerializeField] private int _maxSpawnMeteor;
    private MeteorSpawner _meteorSpawner;
    protected int _health =1;

    public void GetValues(int health, MeteorSpawner meteorSpawner)
    {
        _health = health;
        _meteorSpawner = meteorSpawner;
        _countHealthText.text = _health.ToString();
    }

    public void TakeDamage()
    {
        _health = --_health;
        Debug.Log("Health " + _health.ToString());
        _countHealthText.text = _health.ToString();
        CheckHealth();
    }

    public void TakeDamage(int damage)
    {
        _health = _health - damage;
        _countHealthText.text = _health.ToString();
        CheckHealth();
    }

    private void CheckHealth()
    {
        if (_health <= 0)
        {
            CreateNewMeteor();
            Destroy(this.gameObject);
        }
    }

    private void CreateNewMeteor()
    {
        int countCreateMeteor = Random.Range(1, (_maxSpawnMeteor + 1));
        _meteorSpawner.CreateMeteor(_meteorSpawner.transform, countCreateMeteor);
    }
}
