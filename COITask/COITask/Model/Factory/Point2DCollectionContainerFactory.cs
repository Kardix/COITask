using System;

namespace COITask.Model.Factory
{
    class Point2DCollectionContainerFactory<T> : ICollectionContainerFactory<T> 
        where T : struct, IComparable<T>, IComparable
    {
        public ColletionContainer<T> Create()
        {
            throw new NotImplementedException();
        }
    }
}
