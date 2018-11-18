using System;
using System.Collections.Generic;
using System.Data;
using Abstraction.Roles;
using Abstraction.Shared;
using System.Data.SqlClient;

namespace DataAccess
{
    public class RoleRepository : IRoleRepository
    {
        private readonly SqlTransaction _transaction;

        /// <summary>
        ///     Create a new instance of <see cref="RoleRepository" />.
        /// </summary>
        /// <param name="transaction">Active transaction</param>
        /// <exception cref="ArgumentNullException">transaction</exception>
        public RoleRepository(SqlTransaction transaction)
        {
            if (transaction == null) throw new ArgumentNullException("transaction");
            _transaction = transaction;
        }

        /// <summary>
        ///     Create a new entity.
        /// </summary>
        /// <param name="entity">Entity to create a database row from.</param>
        /// <exception cref="DataException">Will include the insert statement and all <c>SqlCommand</c> arguments.</exception>
        /// <remarks>
        ///     <para>
        ///         Will throw an exception if the entity already exists.
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentNullException">entity</exception>
        public void Create(Role entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");


            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"INSERT INTO Role (name)
                                    VALUES(@name);SELECT CAST(SCOPE_IDENTITY() AS INT);";
                                    
                cmd.AddParameter("name", entity.Name);

                var ID = (int)cmd.ExecuteScalar();
                entity.ID = ID;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        ///     Delete an entity
        /// </summary>
        /// <param name="ID">primary key</param>
        /// <exception cref="ArgumentOutOfRangeException">Id is less than 1.</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        public void Delete(int ID)
        {
            if (ID == 0) throw new ArgumentOutOfRangeException("ID", ID, "Must be 1 or larger.");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"DELETE FROM Role
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        ///     Delete
        /// </summary>
        /// <param name="entity">entity</param>
        /// <remarks>
        ///     <para>
        ///         Will use the primary key in the specified entity.
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentNullException">entity</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        public void Delete(Role entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"DELETE FROM Role
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        ///     Load an existing entity
        /// </summary>
        /// <param name="ID">primary key</param>
        /// <returns>Entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">Id is less than 1.</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        public Role Get(int ID)
        {
            if (ID == 0) throw new ArgumentOutOfRangeException("ID", ID, "Must be 1 or larger.");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, name
                                    FROM Role
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var entity = new Role();
                        Map(reader, entity);
                        return entity;
                    }
                    return null;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        ///     Update existing entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <remarks>
        ///     <para>
        ///         Will not try to create the entity if it do not exist.
        ///     </para>
        /// </remarks>
        /// <exception cref="DataException">Db operation failed</exception>
        public void Update(Role entity)
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"UPDATE Role SET
                                        name = @name
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);
                cmd.AddParameter("name", entity.Name);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }


        /// <summary>
        ///     Find all rows.
        /// </summary>
        /// <returns>Collection of entities (empty list if none is found).</returns>
        /// <exception cref="ArgumentOutOfRangeException">Id is less than 1.</exception>
        /// <exception cref="DataException">Db operation failed</exception>
        public List<Role> FindAll()
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, name
                                    FROM Role";
                return MapCollection(cmd);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        // requires that ALL columns are selected and that they
        // are in the correct order (more performance to use the int indexer)
        private static void Map(IDataRecord record, Role dto)
        {
            dto.ID = (int)record[0];
            dto.Name = (string)record[1];

        }

        /// <summary>
        ///     Traverses over the entire recordset and converts the rows to items
        /// </summary>
        /// <param name="cmd">Command to invoke on</param>
        /// <returns>Collection</returns>
        private static List<Role> MapCollection(SqlCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var items = new List<Role>();
                while (reader.Read())
                {
                    var item = new Role();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }
    }
}