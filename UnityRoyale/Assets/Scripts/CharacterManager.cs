using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets; 

public class CharacterManager : MonoBehaviour
{
    public List<AssetReference> m_Characters;

    public void SpawnCharacter(int characterType)
    {
        Vector3 position = Random.insideUnitSphere * 5;
        position.Set(position.x, 0, position.z);

        m_Characters[characterType].InstantiateAsync(position, Quaternion.identity);
    }
}
