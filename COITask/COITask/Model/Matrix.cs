using System;
using System.Collections;
using System.Collections.Immutable;

namespace COITask
{
    /// <summary>
    /// Definition of immutable collection of collections of points
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T> : IEnumerable 
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Position<T>> MatrixPositions;

        public Matrix()
        {
            MatrixPositions = ImmutableList<Position<T>>.Empty;
        }

        public Matrix(ImmutableList<Position<T>> positionList)
        {
            MatrixPositions = positionList;
        }

        public IEnumerator GetEnumerator()
        {
            return MatrixPositions.GetEnumerator();
        }

        public Position<T> this[int index]
        {
            get => MatrixPositions[index];
        }
    }
}
