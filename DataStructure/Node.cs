namespace DataStructure
{
    /// <summary>
    /// Узел списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}