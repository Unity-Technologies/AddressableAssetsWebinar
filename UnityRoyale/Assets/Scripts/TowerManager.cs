using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets; //TODO: Mention the use of this namespace
using UnityEngine.ResourceManagement.AsyncOperations; // TODO: Mention that this is needed to do the async operations over the lists?
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    public IList<GameObject> m_Towers;

    public AssetLabelReference m_TowerLabel;

    public Button[] m_TowerCards;

    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetsAsync<GameObject>(m_TowerLabel, null).Completed += OnResourcesRetrieved;
    }

    private void OnResourcesRetrieved(AsyncOperationHandle<IList<GameObject>> obj)
    {
        m_Towers = obj.Result;

        //Activate the tower cards since their assets are now loaded
        foreach(var towerCard in m_TowerCards)
        {
            towerCard.interactable = true;
        }
    }

    public void InstantiateTower(int index)
    {
        if(m_Towers != null)
        {
            Instantiate(m_Towers[index]);
        }
    }
}
