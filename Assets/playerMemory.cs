using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMemory : MonoBehaviour
{
    [SerializeField] private int freeMemSlots;
    private playerMove plrMove;
    void Start()
    {
        plrMove = GetComponent<playerMove>();
    }

    void Update()
    {
        
    }
}
