using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets; 

public class TowerManager : MonoBehaviour
{
    public List<AssetReference> m_Towers;

    public void SpawnTower(int towerType)
    {

        Vector3 position = Random.insideUnitSphere * 5;
        position.Set(position.x, 0, position.z);

        m_Towers[towerType].InstantiateAsync(position, Quaternion.identity);
    }
}
