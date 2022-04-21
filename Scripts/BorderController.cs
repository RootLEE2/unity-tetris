using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BlockColor;

public class BorderController : MonoBehaviour, IBackgroundSetting
{
    public static BorderController instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetupBackground(GameObject a_blockPrefab, int a_stageWidth, int a_stageHeight)
    {
        Transform thisTransform = gameObject.GetComponent<Transform>();
        Color blockColor = ColorSet.BORDER;

        int halfWidth = Mathf.RoundToInt(a_stageWidth * 0.5f);
        int halfHeight = Mathf.RoundToInt(a_stageHeight * 0.5f);

        for (int y = halfHeight; y > -halfHeight; --y)
        {
            var stage = Instantiate(a_blockPrefab, thisTransform);
            stage.transform.localPosition = new Vector3(-halfWidth - 1, y, 0);

            var block = stage.GetComponent<Block>();
            block.color = blockColor;
            block.sortingOrder = 0;


            stage = Instantiate(a_blockPrefab, thisTransform);
            stage.transform.localPosition = new Vector3(halfWidth, y, 0);

            block = stage.GetComponent<Block>();
            block.color = blockColor;
            block.sortingOrder = 0;
        }

        for (int x = -halfWidth - 1; x <= halfWidth; ++x)
        {
            var stage = Instantiate(a_blockPrefab, thisTransform);
            stage.transform.localPosition = new Vector3(x, -halfHeight, 0);

            var block = stage.GetComponent<Block>();
            block.color = blockColor;
            block.sortingOrder = 0;
        }
    }
}
