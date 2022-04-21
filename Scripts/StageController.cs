using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BlockColor;

public class StageController : MonoBehaviour, IBackgroundSetting
{
    public static StageController instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetupBackground(GameObject a_blockPrefab, int a_stageWidth, int a_stageHeight)
    {
        Transform thisTransform = gameObject.GetComponent<Transform>();
        Color blockColor = ColorSet.STAGE;

        int halfWidth = Mathf.RoundToInt(a_stageWidth * 0.5f);
        int halfHeight = Mathf.RoundToInt(a_stageHeight * 0.5f);

        for (int x = -halfWidth; x < halfWidth; x++)
        {
            for (int y = halfHeight; y > -halfHeight; y--)
            {
                var stage = Instantiate(a_blockPrefab, thisTransform);
                stage.transform.localPosition = new Vector3(x, y, 0);

                var block = stage.GetComponent<Block>();
                block.color = blockColor;
                block.sortingOrder = -1;
            }
        }
    }
}
