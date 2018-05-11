using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;

namespace COITask
{
    /// <summary>
    /// Immutable Collection of points
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Position<T> : IEnumerable
        where T : struct, IComparable, IComparable<T>
    {
        public readonly ImmutableList<Point<T>> PointsList;

        public Position()
        {
            PointsList = ImmutableList<Point<T>>.Empty;
        }

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