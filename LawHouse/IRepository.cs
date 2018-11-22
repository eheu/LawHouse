using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLogic
{
    /// <summary>
    ///     Repository definition for Case.
    /// </summary>
    public interface IRepository<T> where T : Entity
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
        void Update(Entity entity);

        /// <summary>
        ///     Delete an entity.
        /// </summary>
        void Delete(int id);

        /// <summary>
        ///     Delete an entity.
        /// </summary>
        void Delete(Case entity);
    }
}