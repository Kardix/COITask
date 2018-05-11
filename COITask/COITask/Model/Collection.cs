using System;
using System.Collections;
using System.Collections.Immutable;

namespace COITask
{
    /// <summary>
    /// Definition of immutable collection of matrixes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Collection<T> : IEnumerable
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Matrix<T>> Matrices;
        public Collection()
        {
            Matrices = ImmutableList<Matrix<T>>.Empty;
        }

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