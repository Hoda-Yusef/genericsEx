using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hoda Khier + Yusef Aborokn 44/5

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

        public void Push(T elment)//מתודה המקבלת ערך כלשהו, ומכניסה אותו לסוף התור
        {
            if (count < arr.Length)
            {
                arr[count] = elment;
                count++;
            }
        }

        public T Pop()//מתודה שכאשר היא מופעלת, מוציאה את האיבר מראש התור
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

        public bool IsEmpty()//מתודה המחזירה אמת או שקר אם התור ריק או לא
        {
            return (count == 0);
        }

        public override string ToString()//שיטה שמחזירה מחרוזת 
        {
            string str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += Environment.NewLine + arr[i];
            }
            return str;
        }


        public T Remove(SpecialStack<T> st1)//מתודה שכאשר היא מופעלת, מוציאה את האיבר מראש התור ומחזירה אותו. אם אין איבר בראש התור
        {
            T result,tmp;
            SpecialStack<T> tmp_stack = new SpecialStack<T>(10);
            while (st1.count>1)
            {
                tmp = st1.Pop();
                tmp_stack.Push(tmp);
                
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
