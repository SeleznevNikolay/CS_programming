// Найти расстояние между точками в пространстве 2D/3D

// для 2D
int[] pointA = new int[2] {-1, -2}; // 
int[] pointB = new int[2] {-4, -6};

// для 3D
int[] pointC = new int[3] {0, 0, 0};
int[] pointD = new int[3] {1, 1, 1};


Console.WriteLine(
    $"Расстояние между точками " +
    $"({pointA[0]};{pointA[1]}) и " +
    $"({pointB[0]};{pointB[1]}) равно:" +
    $"{Distance2D(pointA, pointB):F2}"
    );

Console.WriteLine(
    $"Расстояние между точками " +
    $"({pointC[0]};{pointC[1]};{pointC[2]}) и " +
    $"({pointD[0]};{pointD[1]};{pointD[2]}) равно:" +
    $"{Distance3D(pointC, pointD):F2}"
    );



double Distance2D(int[] p1, int[] p2)
{
    int projectionX = p2[0] - p1[0];
    int projectionY = p2[1] - p1[1];
    
    return Math.Sqrt(
        projectionX * projectionX + projectionY * projectionY
        );
}

double Distance3D(int[] p1, int[] p2)
{
    int projectionX = p2[0] - p1[0];
    int projectionY = p2[1] - p1[1];
    int projectionZ = p2[2] - p1[2];
    
    return Math.Sqrt(
        projectionX * projectionX + 
        projectionY * projectionY +
        projectionZ * projectionZ
        );
}
