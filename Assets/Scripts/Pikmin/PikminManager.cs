using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class PikminEvent : UnityEvent<int> { }
[System.Serializable] public class PlayerEvent : UnityEvent<int> { }
public class PikminManager : MonoBehaviour
{

    private List<Pikmin> allPikmin;
    private int followingPikmin;
    private int plantedPikmin;

    [Header("Positioning")]
    public Transform pikminThrowPosition;

    [Header("Targeting")]
    [SerializeField] private Transform target = default;
    [SerializeField] private PikminController controller = default;
    [SerializeField] private float selectionRadius = 1;

    [Header("Spawning")]
    [SerializeField] private Pikmin pikminPrefab = default;
    
    [Header("Events")]
    public PikminEvent pikminFollow;
    public PlayerEvent pikminThrow;

    private void Awake()
    {
        allPikmin = new List<Pikmin>();
        plantedPikmin = 0;
        followingPikmin = 0;

        pikminPrefab.manager = this;
    }

}
