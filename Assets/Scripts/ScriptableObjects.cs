using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "Example Scriptable Object", order = 51)]
public class ScriptableObjects : ScriptableObject
{
   
        public int exampleNumber;
        public Color colorValue;
        public Vector3[] examplespawnPoints;
    
}
