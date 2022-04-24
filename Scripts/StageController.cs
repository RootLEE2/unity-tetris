using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BlockColor;

public class StageController : BlockSpawner, IBackgroundSetting
{
    public static StageController instance;

    private void Awake()
    {
        base.Awake();
        
        instance = this;
    }

    public void SetupBackground(int a_stageWidth, int a_stageHeight)
    {
        Color blockColor = ColorSet.STAGE;

        int halfWidth = Mathf.RoundToInt(a_stageWidth * 0.5f);
        int halfHeight = Mathf.RoundToInt(a_stageHeight * 0.5f);

        for (int x = -halfWidth; x < halfWidth; x++)
        {
            for (int y = halfHeight; y > -halfHeight; y--)
            {
                CreateBlock(transform, new Vector3(x,y,0), blockColor, -1);
            }
        }
    }
}
