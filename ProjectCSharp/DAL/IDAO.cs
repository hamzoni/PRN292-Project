using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.DAL
{
    interface IDAO<T>
    {
        List<T> list();
        bool insert(T x);
        void update(T x);
        void delete(object x);
    }
}
