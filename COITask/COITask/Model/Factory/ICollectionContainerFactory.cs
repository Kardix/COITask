using System;

namespace COITask
{
    interface ICollectionContainerFactory<T> where T : struct, IComparable, IComparable<T>
    {
        ColletionContainer<T> Create();
    }
}
