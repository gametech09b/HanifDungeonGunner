using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Room_  ", menuName = "Scriptable Object/Dungeon/Room")]
public class RoomTemplateSO : ScriptableObject
{
    [HideInInspector] public string guid;

    #region Header ROOM PREFAB

    [Space(10)]
    [Header("Room Prefab")]

    #endregion Header ROOM PREFAB

    #region Tooltip
    [Tooltip("the gameobject prefab for the room_this will contain all the tilemap for the room and environment game objects")]
    #endregion Tooltip
    public GameObject prefab;
    [HideInInspector] public GameObject previousPrefab;

    #region Header ROOM CONFIGURATION
    [Space(10)]
    [Header("ROOM CONFIGURATION")]
    #endregion Header ROOM CONFIGURATION

    #region Tooltip
    [Tooltip("")]
    #endregion Tooltip

    public RoomNodeTypeSO roomNodeType;

    #region Tooltip
    [Tooltip("")]
    #endregion Tooltip

    public Vector2Int lowerBounds;

     #region Tooltip
    [Tooltip("")]
    #endregion Tooltip

    public Vector2Int UpperBounds;

    #region Tooltip
    [Tooltip("")]
    #endregion Tooltip

    [SerializeField] public List<DoorWay> doorwayList;

    #region Tooltip 
    [Tooltip("")]
    #endregion Tooltip

    public Vector2Int[] spawnPositionArray;

    public List<DoorWay> GetDoorwayList()
    {
        return doorwayList; 
    }

    #region Validation

#if UNITY_EDITOR

    // Validate SO fields
    private void OnValidate()
    {
        // Set unique GUID if empty or the prefab changes
        if (guid == "" || previousPrefab != prefab)
        {
            guid = GUID.Generate().ToString();
            previousPrefab = prefab;
            EditorUtility.SetDirty(this);
        }

        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(doorwayList), doorwayList);

        // Check spawn positions populated
        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(spawnPositionArray), spawnPositionArray);
    }

#endif

    #endregion Validation
   
}
