using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsEx
{
    class SpecialStack<T>
    {
        private T[] arr;
        private int count;

        public SpecialStack(int size)
        {
            arr = new T[size];
            count = 0;
        }

        public void Push(T elment)
        {
            if (count < arr.Length)
            {
                arr[count] = elment;
                count++;
            }
        }

        public T Pop()
        {
            if (count > 0 )
            {
                return arr[--count];
            }
            else
                return default(T);
        }

        public T Top()
        {
            if (count > 0)
            {
                return arr[count - 1];
            }
            else
                return default(T);
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += Environment.NewLine + arr[i];
            }
            return str;
        }


        public T Remove(SpecialStack<T> st1)
        {
            T result,tmp;
            SpecialStack<T> tmp_stack = new SpecialStack<T>(10);
            while (st1.count>1)
            {
                tmp = st1.Pop();
                tmp_stack.Push(tmp);
                /*
                tmp_stack.count++;
                st1.count--;
                */
            }
            // אחרון בתור
            result = st1.Pop();

            while(tmp_stack.count >0)
            {
                tmp = tmp_stack.Pop();
                st1.Push(tmp);
            }
            return result;
        }
    }
}
