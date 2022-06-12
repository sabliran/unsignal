using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Backpack", menuName = "Backpack")]
public class Backpack : ScriptableObject
{
    [SerializeField] int keys = 0;

    public int GetKeys { get => keys; }
    public void UpdateKeys(int numberOfKeys) { keys += numberOfKeys; }

    [SerializeField] List<GameObject> items = new List<GameObject>();

    public List<GameObject> GetItems { get => items; }

    public void AddItem(GameObject itemToAdd)
    {
        items.Add(itemToAdd);
    }
}
