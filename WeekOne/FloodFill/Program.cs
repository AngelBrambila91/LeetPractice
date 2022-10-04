using static System.Console;
using System.Collections.Generic;

    int [][] image = new int[3][];
    image [0][0] = 1;
    image [0][1] = 1;
    image [0][2] = 1;
    image [1][0] = 1;
    image [1][1] = 1;
    image [1][2] = 0;
    image [2][0] = 1;
    image [2][1] = 0;
    image [2][2] = 1;
    FloodFill(image, 1, 1, 2);

    static int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image.Length == 0) return image;
        if (image[sr][sc] == color) return image;
        
        bool down = (sr + 1) < image.Length && sr >=0 && image[sr][sc]==image[sr+1][sc];
        bool up =   (sr - 1) < image.Length && sr >=1 && image[sr][sc]==image[sr-1][sc];
        bool right = (sc + 1) < image[sr].Length && sc >= 0 && image[sr][sc]==image[sr][sc+1];
        bool left =  (sc - 1) < image[sr].Length && sc >= 1 && image[sr][sc]==image[sr][sc-1];
        
        image[sr][sc] = color;
        
        if (down)  image = FloodFill(image, sr+1, sc, color);
        if (up)    image = FloodFill(image, sr-1, sc, color);
        if (right) image = FloodFill(image, sr, sc+1, color);
        if (left)  image = FloodFill(image, sr, sc-1, color);
            
        return image;
    }