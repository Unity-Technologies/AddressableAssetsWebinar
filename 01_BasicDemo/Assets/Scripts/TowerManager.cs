using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public class TowerManager : MonoBehaviour
{
    public List<IResourceLocation> m_Characters;

    public AssetLabelReference towerLabel;

    // Start is called before the first frame update
    void Start()
    {
        //Addressables.DownloadDependenciesAsync(towerLabel).Completed += FinishedLoadingTowers;
        Addressables.LoadAssetsAsync<IResourceLocation>(new List<object> { towerLabel.labelString }, null, Addressables.MergeMode.Intersection).Completed += FinishedLoadingTowers2;
    }

    void FinishedLoadingTowers2(AsyncOperationHandle<IList<IResourceLocation>> op)
    {
        foreach(var tower in op.Result)
        {
            Addressables.InstantiateAsync(tower);
        }
    }

    //void FinishedLoadingTowers(AsyncOperationHandle obj)
    //{
    //    Debug.Log("Loaded Towers");
    //    m_Characters = new List<IResourceLocation>(obj.Result);
    //}

    // Update is called once per frame
    void Update()
    {
    }
}
