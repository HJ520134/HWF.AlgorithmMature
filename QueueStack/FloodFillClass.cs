using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class FloodFillClass
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image == null || image.Length == 0 || image[0].Length == 0)
            {
                return image;
            }
            var oriColor = image[sr][sc];
            if (oriColor== newColor) 
            {
                return image;
            }

            SetValue(image, sr, sc, newColor, oriColor);
            return image;
        }

        public void SetValue(int[][] image, int sr, int sc, int newColor, int oriColor)
        {
            var x = image.Length;
            var y = image[0].Length;
            if (sr < 0 || sc < 0 || sr >= x || sc >= y)
            {
                return;
            }

            if (image[sr][sc] == oriColor)
            {
                image[sr][sc] = newColor;
            }
            else
            {
                return;
            }

            SetValue(image, sr - 1, sc, newColor, oriColor);
            SetValue(image, sr + 1, sc, newColor, oriColor);
            SetValue(image, sr, sc - 1, newColor, oriColor);
            SetValue(image, sr, sc + 1, newColor, oriColor);

            "".ToString();

        }
    }
}
