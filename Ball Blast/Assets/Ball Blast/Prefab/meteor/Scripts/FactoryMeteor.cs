using UnityEngine;

public interface FactoryMeteor
{
    void GetValues();
    void CreateMeteor(Transform transform, int countMeteor = 1);
}
