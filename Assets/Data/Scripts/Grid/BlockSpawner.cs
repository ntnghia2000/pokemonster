using UnityEngine;

public class BlockSpawner : Spawner
{
    [Header("Block")]
    private static BlockSpawner instance;
    public static BlockSpawner Instance => instance;

    public static string BLOCK = "BlockPrefab";
}
