using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class TextureController : MonoBehaviour
{

    public Renderer m_ReferencedMaterial;

    public void SwitchToHighDef()
    {
        LoadTexture("ArcherColor", "HD");
    }

    void LoadTexture(string key, string label)
    {
        Addressables.LoadAssetsAsync<Texture2D>(new List<object> { key, label }, null, Addressables.MergeMode.Intersection).Completed
            += TextureLoaded;
    }

    void TextureLoaded(AsyncOperationHandle<IList<Texture2D>> obj)
    {
        m_ReferencedMaterial.material.mainTexture = obj.Result[0];
    }
}
