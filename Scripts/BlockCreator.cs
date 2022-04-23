using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreator : MonoBehaviour
{
    protected void CreateBlock(GameObject a_blockPrefab, Transform a_parent, Vector3 a_position, Color a_blockColor, int a_sortingOrder)
    {
        var blockObject = Instantiate(a_blockPrefab, a_parent);
        blockObject.transform.localPosition = a_position;

        var block = blockObject.GetComponent<Block>();
        block.color = a_blockColor;
        block.sortingOrder = a_sortingOrder;
    }
}
