Console.Write("Matrix rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Matrix columns: ");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];

//Current position in the matrix.
int posi = 0;
int posj = 0;

//Directions for the fill.
int diri = 0;
int dirj = 1;

//Stopping points for our cycle. if a stopping point is reached - change direction!
//These represent the maximum/minimum indexes of the matrix, that our posi and posj can reach.
int imin = 1;
int imax = matrix.GetLength(0) - 1;
int jmin = 0;
int jmax = matrix.GetLength(1) - 1;

//The data we use to fill each position of the matrix
int fillerData = 2;

//Some manual labor. please, don't judge :/
matrix[0, 0] = 1;

while (fillerData <= (matrix.GetLength(0) * matrix.GetLength(1)))
{
    /*
    Position will change every single cycle of this loop.
    Position is changed with the use of the direction.
    Since we're adding a value to our current position:
    If we add 1 to our current posi, it means we're moving down.
    If we're adding -1 to posi, we're moving up.
    If we add 0 to posi, we stay at the same spot.
    In other words - diri handles the directions up and down,
    while dirj handles the direction left and right.
    Both variables(diri and dirj) decide our direction.
    */
    posi += diri;
    posj += dirj;

    //Fill and increment the data
    matrix[posi, posj] = fillerData;
    fillerData++;

    //DIRECTION HANDLERS
    //If direction is RIGHT and we reach maximum RIGHT position:
    //Change direction to DOWN and lower the maximum RIGHT position (so we don't visit it again the next time we move RIGHT)
    if ((diri == 0 && dirj == 1) && posj == jmax)
    {
        jmax--;
        diri = 1;
        dirj = 0;
    }
    //If direction is DOWN and we reach maximum DOWN position:
    //Change direction to LEFT and lower the maximum DOWN position (so we don't visit it again the next time we move DOWN)
    if ((diri == 1 && dirj == 0) && posi == imax)
    {
        imax--;
        diri = 0;
        dirj = -1;
    }
    //If direction is LEFT and we reach maximum LEFT position:
    //Change direction to UP and increase the minimum LEFT position (so we don't visit it again the next time we move LEFT)
    if ((diri == 0 && dirj == -1) && posj == jmin)
    {
        jmin++;
        diri = -1;
        dirj = 0;
    }
    //If direction is UP and we reach minimum UP position:
    //Change direction to RIGHT and increased the minimum UP position (so we don't visit it again the next time we move UP)
    if ((diri == -1 && dirj == 0) && posi == imin)
    {
        imin++;
        diri = 0;
        dirj = 1;
    }
}

Console.WriteLine();

//Print the matrix.
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0, 5}", matrix[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();