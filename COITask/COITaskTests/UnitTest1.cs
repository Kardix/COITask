using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using COITask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COITaskTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ImmutabilityOfContainers()
        {
            ImmutableList<Point<int>> emptyContainer = ImmutableList<Point<int>>.Empty;
            var add = new Point1D<int>(0);
            emptyContainer.Add(add);
            Assert.AreEqual(emptyContainer,ImmutableList<Point<int>>.Empty);

        }

        [TestMethod]
        public void InvalidData()
        {
            var point1D = new Point1D<int>(1);
            var point2D = new Point2D<int>(2, 3);
            var point3D = new Point3D<int>(4, 5, 6);

            ImmutableList<Point<int>> points1 = ImmutableList.Create<Point<int>>(point1D, point2D, point3D);
            try
            {
                var position = new Position<int>(points1);
                Assert.Fail();
            }
            catch (ContainerException ex)
            {
            }
            
        }

        [TestMethod]
        public void BigSize()
        {
            var point = new Point1D<int>();
            List<Point<int>> poiList = Enumerable.Repeat(point as Point<int>, 50).ToList();
            Point<int>[] poiArr = poiList.ToArray();
            ImmutableList<Point<int>> iPoiList = ImmutableList.Create(poiArr);
            Position<int> ILPointsl = new Position<int>(iPoiList);


            List<Position<int>> posList = Enumerable.Repeat(ILPointsl, 50).ToList();
            Position<int>[] posArr = posList.ToArray();
            ImmutableList<Position<int>> iPosList = ImmutableList.Create(posArr);
            Matrix<int> ILPositionl = new Matrix<int>(iPosList);

            List<Matrix<int>> colList = Enumerable.Repeat(ILPositionl, 1000).ToList();
            Matrix<int>[] colArr = colList.ToArray();
            ImmutableList<Matrix<int>> iMatList = ImmutableList.Create(colArr);
            Collection<int> ILMatrixl = new Collection<int>(iMatList);

            ColletionContainer<int> baseContainer = new ColletionContainer<int>(ImmutableList.Create(ILMatrixl));
            Assert.IsNotNull(baseContainer);
        }
    }
}
