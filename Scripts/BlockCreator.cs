using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreator : MonoBehaviour
{
    [Header("Objects & Prefabs")]
    [SerializeField] private static GameObject blockPrefab;

    protected void Awake()
    {
        if (!blockPrefab)
        {
            blockPrefab = Resources.Load<GameObject>("Prefabs/tetris_block");

            if (!blockPrefab)
            {
                Debug.LogError("Error: Prefab for block is missing");
            }
        }
    }

    protected void CreateBlock(Transform a_parent, Vector3 a_position, Color a_blockColor, int a_sortingOrder)
    {
        var blockObject = Instantiate(blockPrefab, a_parent);
        blockObject.transform.localPosition = a_position;

        var block = blockObject.GetComponent<Block>();
        block.color = a_blockColor;
        block.sortingOrder = a_sortingOrder;
    }
}
