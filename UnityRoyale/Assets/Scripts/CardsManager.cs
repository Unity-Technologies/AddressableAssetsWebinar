using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CardsManager : MonoBehaviour
{
    public AssetLabelReference m_ArcherLabel;
    public AssetLabelReference m_MageLabel;
    public AssetLabelReference m_WarriorLabel;

    public Button m_ArcherCard;
    public Button m_ArcherHouseCard;

    public Button m_MageCard;
    public Button m_MageHouseCard;

    public Button m_WarriorCard;
    public Button m_WarriorHouseCard;

    // Start is called before the first frame update
    void Start()
    {
        //Addressables.LoadAssetsAsync<GameObject>(m_ArcherLabel, null).Completed += OnResourcesRetrieved;
        LoadArchers();
    }

    public void LoadArchers()
    {
        Addressables.LoadAssetsAsync<GameObject>(m_ArcherLabel, null).Completed += OnArchersRetrieved;
    }

    public void LoadMages()
    {
        Addressables.LoadAssetsAsync<GameObject>(m_MageLabel, null).Completed += OnMagesRetrieved;
    }

    public void LoadWarriors()
    {
        Addressables.LoadAssetsAsync<GameObject>(m_WarriorLabel, null).Completed += OnWarriorsRetrieved;
    }

    private void OnArchersRetrieved(AsyncOperationHandle<IList<GameObject>> obj)
    {

        // Activate the buttons to be interactable
        m_ArcherCard.interactable = true;
        m_ArcherHouseCard.interactable = true;
    }

    private void OnMagesRetrieved(AsyncOperationHandle<IList<GameObject>> obj)
    {

        // Activate the buttons to be interactable
        m_MageCard.interactable = true;
        m_MageHouseCard.interactable = true;
    }

    private void OnWarriorsRetrieved(AsyncOperationHandle<IList<GameObject>> obj)
    {

        // Activate the buttons to be interactable
        m_WarriorCard.interactable = true;
        m_WarriorHouseCard.interactable = true;
    }
}
