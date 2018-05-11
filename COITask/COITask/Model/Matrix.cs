using System;
using System.Collections;
using System.Collections.Immutable;

namespace COITask
{
    /// <summary>
    /// Definition of T2 container
    /// </summary>
    /// <typeparam name="T">numerical type</typeparam>
    public class Matrix<T> : IEnumerable 
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Position<T>> MatrixPositions;

        /// <summary>
        /// Default T2 constructor for empty container
        /// </summary>
        public Matrix()
        {
            MatrixPositions = ImmutableList<Position<T>>.Empty;
        }

        /// <summary>
        /// Constructor for T2 container with pre-specified collection of T1 containers
        /// </summary>
        /// <param name="positionList">List of T1 containers to be stored</param>
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
