using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;

namespace COITask
{
    /// <summary>
    /// Definition of T1 container
    /// </summary>
    /// <typeparam name="T">numerical type</typeparam>
    public class Position<T> : IEnumerable
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Point<T>> PointsList;

        /// <summary>
        ///  Default T1 constructor for empty container
        /// </summary>
        public Position()
        {
            PointsList = ImmutableList<Point<T>>.Empty;
        }

        /// <summary>
        /// Constructor for T1 container with pre-specified collection of T1 containers
        /// </summary>
        /// <param name="list">List of T0 objects to be stored</param>
        public Position(ImmutableList<Point<T>> list)
        {
            if (list.Select(el => el.GetType()).Distinct().Count() > 1)
                throw new ContainerException();

            PointsList = list;
        }

        public IEnumerator GetEnumerator()
        {
            return PointsList.GetEnumerator();
        }

        public Point<T> this[int index]
        {
            get => PointsList[index];
        }
    }
}