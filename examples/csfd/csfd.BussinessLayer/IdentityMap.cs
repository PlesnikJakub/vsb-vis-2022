namespace csfd.BussinessLayer
{
    public class IdentityMap<T> where T: IEntity
    {
        private Dictionary<int, T> map = new Dictionary<int, T>();

        public T Get(int id)
        {
            if(map.ContainsKey(id))
            {
                return map[id];
            }
            return default(T);
        }

        public void Add(T entity)
        {
            map.Add(entity.Id, entity);
        }
    }
}
