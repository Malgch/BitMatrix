using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// file: BitMatrixPartial.cs

public partial class BitMatrix
{
    //ToDo

    public override string BitMatrix.ToString()
    {
        int x = NumberOfRows;
        int y = NumberOfColumns;


        for (int i = 0; i < x * y; i++ )
        {
            int rowLength = i;
            if (rowLength % y != 0)
            {
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine($"{data}{Environment.NewLine}");
            }
            
        }
      

    }
}