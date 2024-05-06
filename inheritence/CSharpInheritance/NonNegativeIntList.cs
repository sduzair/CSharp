using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance;

internal class NonNegativeIntList : List<uint>, IList<uint>
{
    public NonNegativeIntList() : base() { }
    public new int this[int index]
    {
        get => (int)base[index];
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be non-negative");
            }
            base[index] = (uint)value;
        }
    }

    public new void Add(uint item)
    {
        if (item < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(item), "item must be non-negative");
        }
        base.Add(item);
    }

    public new int IndexOf(uint item)
    {
        if (item < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(item), "Item must be non-negative");
        }
        return base.IndexOf(item);
    }

    public new void Insert(int index, uint item)
    {
        if (item < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(item), "Item must be non-negative");
        }
        base.Insert(index, item);
    }

    public new bool Remove(uint item)
    {
        if (item < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(item), "Item must be non-negative");
        }
        return base.Remove(item);
    }

    public new void RemoveAt(int index)
    {
        base.Remove((uint)index);
    }
}
