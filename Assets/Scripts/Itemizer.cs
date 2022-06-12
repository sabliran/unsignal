using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemizer : MonoBehaviour
{
    [SerializeField] bool isAKey = false;
    [SerializeField] GameObject uIButton = null;

    public bool GetIsAKey { get => isAKey; }
    public GameObject GetButton { get => uIButton; }
}

