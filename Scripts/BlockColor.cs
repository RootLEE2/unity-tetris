using System;
using UnityEngine;

namespace BlockColor
{
    [System.Serializable]
    public class ColorSet
    {
        public Color border = new Color(197/255f, 171/255f, 219/255f);
        public Color stage = new Color(136/255f, 117/255f, 152/255f);

        public Color red = new Color(219/255f, 141/255f, 153/255f);
        public Color orange = new Color(234/255f, 199/255f, 171/255f);
        public Color yellow = new Color(234/255f, 226/255f, 171/255f);
        public Color green = new Color(176/255f, 227/255f, 174/255f);
        public Color blue = new Color(155/255f, 227/255f, 225/255f);
        public Color indigo = new Color(110/255f, 140/255f, 203/255f);
        public Color purple = new Color(151/255f, 124/255f, 186/255f);
    }
}