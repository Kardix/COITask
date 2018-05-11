using System;
using System.Collections;
using System.Collections.Immutable;

namespace COITask
{
    /// <summary>
    /// Definition of T3 container
    /// </summary>
    /// <typeparam name="T">numerical type</typeparam>
    public class Collection<T> : IEnumerable
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Matrix<T>> Matrices;
        /// <summary>
        /// Default T3 constructor for empty container
        /// </summary>
        public Collection()
        {
            Matrices = ImmutableList<Matrix<T>>.Empty;
        }

        /// <summary>
        /// Constructor for T3 container with pre-specified collection of T2 containers
        /// </summary>
        /// <param name="matrices">list of T2 containers</param>
        public Collection(ImmutableList<Matrix<T>> matrices)
        {
            Matrices = matrices;
        }

        public IEnumerator GetEnumerator()
        {
            return Matrices.GetEnumerator();
        }

        public Matrix<T> this[int index]
        {
            get => Matrices[index];
        }
    }
}