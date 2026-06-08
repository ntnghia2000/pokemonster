using UnityEngine;

public abstract class GridAbstract : BaseMonoBehaviour
{
    [Header("Grid Abstract")]
    
    [SerializeField]
    private GridManagerController gridController;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.GetGridManagerController();
    }

    private void GetGridManagerController()
    {
        if (this.gridController != null) return;
        this.gridController = transform.GetComponent<GridManagerController>();
    }
}
