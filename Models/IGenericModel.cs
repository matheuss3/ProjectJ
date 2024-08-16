namespace ProjectJ.Models
{
    public interface IGenericModel<T>
    {
        public List<T> get();
        public T post();
        public T update();
        public bool delete();


    }
}
