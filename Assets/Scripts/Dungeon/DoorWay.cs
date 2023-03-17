using UnityEngine;
[System.Serializable] 

public class DoorWay 
{
    public Vector2Int position;
    public Orientation orientation;
    public GameObject doorPrefab;

    #region Header
    [Header("The upper left positionto start copying from")]
    #endregion
    public Vector2Int doorwayStartCopyPosition;
    
    #region Header
    [Header("The widht of tiles in the doorway to copy over")]
    #endregion
    public int doorwayCopyTileWidht;

    #region Header
    [Header("The Height of tiles in the doorway to copy over")]
    #endregion
    public int doorwayCopyTileHeight;
    [HideInInspector]
    public bool isConnected =  false;
    [HideInInspector]
    public bool isUnavailable = false;
    


}