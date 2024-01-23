using MatrixExample;
using Microsoft.Extensions.Logging;


try
{
    Matrix matrix = new Matrix(3, 4);

    matrix[0, 0] = 1;
    matrix[0, 1] = 2;
    matrix[0, 2] = 7;
    matrix[1, 0] = 3;
    matrix[1, 2] = 5;
    //matrix[3, 6] = 6;
    matrix.ShowMatrixElements();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}



