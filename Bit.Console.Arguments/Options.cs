using System;
using System.Collections.Generic;

namespace Bit.Console.Arguments
{
    public class Options : ICollection<Option>
    {
        public void Add(Option item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(Option item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(Option[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public int Count
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool Remove(Option item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<Option> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Option
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public Action<string> Action { get; set; }
        public string Description { get; set; }
    }
}
