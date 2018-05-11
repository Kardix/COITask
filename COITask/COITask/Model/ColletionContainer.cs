using System;
using System.Collections;
using System.Collections.Immutable;

namespace COITask
{
    /// <summary>
    // Top level container
    /// <typeparam name="T">limited to numerical types</typeparam>
    public class ColletionContainer<T> : IEnumerable
        where T : struct, IComparable, IComparable<T>
    {
        public ImmutableList<Collection<T>> Collections;

        public ColletionContainer()
        {
            Collections = ImmutableList<Collection<T>>.Empty;
        }

        public ColletionContainer(ImmutableList<Collection<T>> collections)
        {
            Collections = collections;
        }

        public IEnumerator GetEnumerator()
        {
            return Collections.GetEnumerator();
        }

        public Collection<T> this[int index]
        {
            get => Collections[index];
        }

        #region Print

        /// <summary>
        /// method for printing the container to the console
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Container");
            foreach (var collection in Collections)
            {  
                PrintCollection(collection);
            }
        }

        private void PrintCollection(Collection<T> collection)
        {
            Console.WriteLine("\tCollection");
            foreach (var matrix in collection.Matrices)
            {    
                PrintMatrix(matrix);
            }
        }

        private void PrintMatrix(Matrix<T> matrix)
        {
            Console.WriteLine("\t\tMatrix");
            foreach (var position in matrix.MatrixPositions)
            {
                PrintPosition(position);
            }
        }

        private void PrintPosition(Position<T> position)
        {
            Console.WriteLine("\t\t\tPosition");
            Console.Write("\t\t\t\t");
            foreach (var point in position.PointsList)
            {
                point.Print();
            }
            Console.WriteLine();
        }

        #endregion
    }
}