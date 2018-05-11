using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COITask;

namespace COITaskExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point1D<int>();
            List<Point<int>> poiList = Enumerable.Repeat(point as Point<int>, 5).ToList();
            Point<int>[] poiArr = poiList.ToArray();
            ImmutableList<Point<int>> iPoiList = ImmutableList.Create(poiArr);
            Position<int> ILPointsl = new Position<int>(iPoiList);


            List<Position<int>> posList = Enumerable.Repeat(ILPointsl, 5).ToList();
            Position<int>[] posArr = posList.ToArray();
            ImmutableList<Position<int>> iPosList = ImmutableList.Create(posArr);
            Matrix<int> ILPositionl = new Matrix<int>(iPosList);

            List<Matrix<int>> colList = Enumerable.Repeat(ILPositionl, 2).ToList();
            Matrix<int>[] colArr = colList.ToArray();
            ImmutableList<Matrix<int>> iMatList = ImmutableList.Create(colArr);
            Collection<int> ILMatrixl = new Collection<int>(iMatList);

            ColletionContainer<int> baseContainer = new ColletionContainer<int>(ImmutableList.Create(ILMatrixl));
            baseContainer.Print();
            Console.ReadLine();

        }
    }
}
