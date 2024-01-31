using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    interface ICRUD<T>
    {
        void Create(T item);
        void Create(T item, int index);

        T Read(int index);

        void Update(T item);

        void Delete(T item);
        void Delete(int index);
    }
}
