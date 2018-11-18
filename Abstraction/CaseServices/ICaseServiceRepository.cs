using System;
using System.Data;

namespace Abstraction.CaseServices
{
    /// <summary>
    ///     Repository definition for <c>CaseService</c>.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         This definition do not include any query methods as you should typically only include them
    ///         once they are actually needed. I do recommend that you name them after where they are used to
    ///         make it easier to maintain and remove old queries when the application age.
    ///     </para>
    ///     <para>
    ///         You could for instance name a method <code>GetUsersForIndexPage</code>.
    ///     </para>
    /// </remarks>
    public interface ICaseServiceRepository
    {
        /// <summary>
        ///     Create a new entity.
        /// </summary>
        /// <param name="entity">Entity to insert into the table</param>
        /// <exception cref="DataException">Will include the insert statement and all <c>IDbCommand</c> arguments</exception>
        /// <remarks>
        ///     <para>
        ///         Will throw an exception if the entity already exists.
        ///     </para>
        /// </remarks>
        /// <exception cref="DataException">DB operation failed (exception will include command details)</exception>
        /// <exception cref="ArgumentNullException">entity</exception>
        void Create(CaseService entity);

        /// <summary>
        ///     Delete an entity.
        /// </summary>
        /// <param name="id">primary key</param>
        /// <exception cref="ArgumentOutOfRangeException">Id is not within the expected range.</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        void Delete(int id);

        /// <summary>
        ///     Delete an entity.
        /// </summary>
        /// <param name="entity">entity</param>
        /// <remarks>
        ///     <para>
        ///         Will use the primary in the specified entity.
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentNullException">entity</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        void Delete(CaseService entity);

        /// <summary>
        ///     Load an existing entity.
        /// </summary>
        /// <param name="id">primary key</param>
        /// <returns>Entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">Id is not within the expected range.</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        CaseService Get(int id);

        /// <summary>
        ///     Update existing entity.
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <remarks>
        ///     <para>
        ///         Will not try to create the entity if it do not exist.
        ///     </para>
        /// </remarks>
        /// <exception cref="DataException">DB operation failed (exception will include command details)</exception>
        void Update(CaseService entity);
    }
}