using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets; //TODO: Mention the use of this namespace
using UnityEngine.ResourceManagement.AsyncOperations; // TODO: Mention that this is needed to do the async operations over the lists?
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    //public IList<GameObject> m_Towers;

    //public AssetLabelReference m_TowerLabel;

    //public Button[] m_TowerCards;

    //public List<AssetReference> m_Characters;

    public List<AssetReference> m_Towers;

    public void SpawnTower(int towerType)
    {

        Vector3 position = Random.insideUnitSphere * 5;
        position.Set(position.x, 0, position.z);

        m_Towers[towerType].InstantiateAsync(position, Quaternion.identity);
    }

    //public void InstantiateMageTower()
    //{

    //}

    //public void InstantiateWarrior()
    //{

    //}

    //public void InstantiateWarriorTower()
    //{

    //}

    //public void InstantiateTower(int index)
    //{
    //    if(m_Towers != null)
    //    {
    //        Vector3 position = Random.insideUnitSphere * 5;
    //        position.Set(position.x, 0, position.z);

    //        Instantiate(m_Towers[index], position, Quaternion.identity, null);
    //    }
    //}
}
