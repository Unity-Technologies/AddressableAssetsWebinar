using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeout : MonoBehaviour
{
    [SerializeField]
    private float m_TimeToLive;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_TimeToLive);
    }
}
