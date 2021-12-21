using System;

namespace consoleapp
{
    public class List<Type>
    {
        private class ListItem
        {
            public Type Data;
            public ListItem NextItem;
        }

        private ListItem firstItem;
        private int length;

        public int Length 
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }

        } 

        public void Add(Type data)
        {            
            ListItem listItem = new ListItem { Data = data };

            if (firstItem == null)
            {
                firstItem = listItem;
                length = 1;
                return;
            }

            ListItem prevItem = firstItem;

            while (prevItem.NextItem != null)
            {
                prevItem = prevItem.NextItem;
            }
            
            prevItem.NextItem = listItem;
            length += 1;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            ListItem deleteItem = firstItem;
            
            for (int i = 0; i < index - 1; i++)
            {
                deleteItem = deleteItem.NextItem;
            }
           
            deleteItem.NextItem = deleteItem.NextItem.NextItem;

            length--;
        }
        
        private void ValidateIndex(int index)
        {
            if (firstItem == null)
                throw new Exception("Список пуст :/");

            if (index >= length || index < 0)
                throw new Exception($"Нет элемента для индекса {index}");
        }

        private Type GetItem(int index)
        {
            ValidateIndex(index);

            ListItem item = firstItem;
            
            for (int i = 0; i < index; i++)
            {
                item = item.NextItem;
            }

            return item.Data;
        }
         
        public Type this[int index]
        {
            get
            {
                return GetItem(index);
            }
        } 
    }
}
