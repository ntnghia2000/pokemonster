using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : BaseMonoBehaviour
{
    [Header("Base spawner")]
    [SerializeField]
    protected Transform holder;
    public Transform Holder => holder;

    [SerializeField] protected int spawnedCount = 0;
    public int SpawnedCount => spawnedCount;

    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> poolObjs;
}
