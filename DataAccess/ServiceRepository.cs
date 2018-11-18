using System;
using System.Collections.Generic;
using System.Data;
using Abstraction.Services;
using Abstraction.Shared;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SqlTransaction _transaction;

        /// <summary>
        ///     Create a new instance of <see cref="ServiceRepository" />.
        /// </summary>
        /// <param name="transaction">Active transaction</param>
        /// <exception cref="ArgumentNullException">transaction</exception>
        public ServiceRepository(SqlTransaction transaction)
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
        public void Create(Service entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");


            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"INSERT INTO Service (name, price, isHourly)
                                    VALUES(@name, @price, @isHourly);SELECT CAST(SCOPE_IDENTITY() AS INT);";
                                    
                cmd.AddParameter("name", entity.Name);
                cmd.AddParameter("price", entity.Price);
                cmd.AddParameter("isHourly", entity.IsHourly);

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
                cmd.CommandText = @"DELETE FROM Service
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
        public void Delete(Service entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"DELETE FROM Service
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
        public Service Get(int ID)
        {
            if (ID == 0) throw new ArgumentOutOfRangeException("ID", ID, "Must be 1 or larger.");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, name, price, isHourly
                                    FROM Service
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var entity = new Service();
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
        public void Update(Service entity)
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"UPDATE Service SET
                                        name = @name, 
                                        price = @price, 
                                        isHourly = @isHourly
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);
                cmd.AddParameter("name", entity.Name);
                cmd.AddParameter("price", entity.Price);
                cmd.AddParameter("isHourly", entity.IsHourly);

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
        public List<Service> FindAll()
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, name, price, isHourly
                                    FROM Service";
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
        private static void Map(IDataRecord record, Service dto)
        {
            dto.ID = (int)record[0];
            dto.Name = (string)record[1];
            dto.Price = (decimal)record[2];
            dto.IsHourly = (bool)record[3];

        }

        /// <summary>
        ///     Traverses over the entire recordset and converts the rows to items
        /// </summary>
        /// <param name="cmd">Command to invoke on</param>
        /// <returns>Collection</returns>
        private static List<Service> MapCollection(SqlCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var items = new List<Service>();
                while (reader.Read())
                {
                    var item = new Service();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }
    }
}