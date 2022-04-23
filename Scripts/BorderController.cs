using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BlockColor;

public class BorderController : BlockCreator, IBackgroundSetting
{
    public static BorderController instance;

    private void Awake()
    {
        base.Awake();
        
        instance = this;
    }

    public void SetupBackground(int a_stageWidth, int a_stageHeight)
    {
        Color blockColor = ColorSet.BORDER;

        int halfWidth = Mathf.RoundToInt(a_stageWidth * 0.5f);
        int halfHeight = Mathf.RoundToInt(a_stageHeight * 0.5f);

        for (int y = halfHeight; y > -halfHeight; --y)
        {
            CreateBlock(transform, new Vector3(-halfWidth-1,y,0), blockColor, 0);
            CreateBlock(transform, new Vector3(halfWidth,y,0), blockColor, 0);
        }

        for (int x = -halfWidth - 1; x <= halfWidth; ++x)
        {
            CreateBlock(transform, new Vector3(x,-halfHeight,0), blockColor, 0);
        }
    }
}
