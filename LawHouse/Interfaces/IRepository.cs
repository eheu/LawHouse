using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    ///     Generic repository interface.
    /// </summary>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        ///     Create a new entity.
        /// </summary>
        void Create(T entity);

        /// <summary>
        ///     Load an existing entity.
        /// </summary>
        T Get(int id);

        /// <summary>
        ///     Load all existing entities.
        /// </summary>
        List<T> GetAll();

        /// <summary>
        ///     Update existing entity.
        /// </summary>
        void Update(T entity);

        /// <summary>
        ///     Delete an entity.
        /// </summary>
        void Delete(int ID);


    }
}