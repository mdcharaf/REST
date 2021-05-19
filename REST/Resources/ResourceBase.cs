namespace REST.Resources
{
    public abstract class ResourceBase<T>
    {
        protected ResourceBase(T model)
        {
            Model = model;
        }
        
        protected T Model { get; }
    }
}