namespace Generics;

public class stack<T>
{
   
        public List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            T item = items.Last();
            items.RemoveAt(items.Count - 1);
            return item;
        }
    

    
}