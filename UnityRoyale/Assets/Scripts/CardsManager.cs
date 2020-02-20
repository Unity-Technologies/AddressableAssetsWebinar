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

    public GameObject m_ConfirmationWindow;
    public GameObject m_UnlockMagesButton;
    public GameObject m_UnlockWarriorsButton;

    // Start is called before the first frame update
    void Start()
    {
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

        Destroy(m_UnlockMagesButton);
        Instantiate(m_ConfirmationWindow);
    }

    private void OnWarriorsRetrieved(AsyncOperationHandle<IList<GameObject>> obj)
    {

        // Activate the buttons to be interactable
        m_WarriorCard.interactable = true;
        m_WarriorHouseCard.interactable = true;

        Destroy(m_UnlockWarriorsButton);
        Instantiate(m_ConfirmationWindow);
    }
}
