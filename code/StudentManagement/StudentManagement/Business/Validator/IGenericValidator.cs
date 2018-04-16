namespace StudentManagement.Business.Validator
{
    /// <summary>
    /// Validates an entity, throws ArgumentException if entity is invalid.
    /// </summary>
    /// <typeparam name="T">type of entity to be validated</typeparam>
    public interface IGenericValidator<in T>
    {
        void Validate(T entity);
    }
}