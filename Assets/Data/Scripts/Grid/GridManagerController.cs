using UnityEngine;

public class GridManagerController : BaseMonoBehaviour
{
    [Header("Grid Manager Ctrl")]
    private static GridManagerController instance;
    public static GridManagerController Instance => instance;

    [SerializeField]
    private BlockSpawner blockSpawner;

    protected override void Awake()
    {
        base.Awake();

        if (instance != null) return;
        instance = this;
    }

    public BlockSpawner GetBlockSpawner()
    {
        return this.blockSpawner;
    }
}
