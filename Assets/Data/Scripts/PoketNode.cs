using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PoketNode", menuName = "Scriptable Objects/PoketNode")]
public class PoketNode : ScriptableObject
{
    public List<Sprite> sprites = new List<Sprite>();
}
