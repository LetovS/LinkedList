using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Codeblog.Model
{
    /// <summary>
    /// Ячейка списка.
    /// </summary>
    
    public class Item<T>
    {
        
        private T data = default(T);
        /// <summary>
        /// Данные в ячейке списка.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }
        /// <summary>
        /// Следующая ячейка списка.
        /// </summary>
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
