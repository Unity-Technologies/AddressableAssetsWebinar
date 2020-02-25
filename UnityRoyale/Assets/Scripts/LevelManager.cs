using UnityEngine;
using UnityEngine.AddressableAssets;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.InstantiateAsync("Level1");
    }
}
