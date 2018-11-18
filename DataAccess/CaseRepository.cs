using System;
using System.Collections.Generic;
using System.Data;
using Abstraction.Cases;
using Abstraction.Shared;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CaseRepository : ICaseRepository
    {
        private readonly SqlTransaction _transaction;

        /// <summary>
        ///     Create a new instance of <see cref="CaseRepository" />.
        /// </summary>
        /// <param name="transaction">Active transaction</param>
        /// <exception cref="ArgumentNullException">transaction</exception>
        public CaseRepository(SqlTransaction transaction)
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
        public void Create(Case entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");


            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"INSERT INTO Case (title, description, status, estimatedHours, startDate, endDate, clientID, employeeID)
                                    VALUES(@title, @description, @status, @estimatedHours, @startDate, @endDate, @clientID, @employeeID);SELECT CAST(SCOPE_IDENTITY() AS INT);";
                                    
                cmd.AddParameter("title", entity.Title);
                cmd.AddParameter("description", entity.Description);
                cmd.AddParameter("status", entity.Status);
                cmd.AddParameter("estimatedHours", entity.EstimatedHours);
                cmd.AddParameter("startDate", entity.StartDate);
                cmd.AddParameter("endDate", entity.EndDate);
                cmd.AddParameter("clientID", entity.ClientID);
                cmd.AddParameter("employeeID", entity.EmployeeID);

                var ID = (int)cmd.ExecuteScalar();
                entity.ID = ID;
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
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
                cmd.CommandText = @"DELETE FROM Case
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
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
        public void Delete(Case entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"DELETE FROM Case
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
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
        public Case Get(int ID)
        {
            if (ID == 0) throw new ArgumentOutOfRangeException("ID", ID, "Must be 1 or larger.");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, title, description, status, estimatedHours, startDate, endDate, clientID, employeeID
                                    FROM Case
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var entity = new Case();
                        Map(reader, entity);
                        return entity;
                    }
                    return null;
                }
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
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
        public void Update(Case entity)
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"UPDATE Case SET
                                        title = @title, 
                                        description = @description, 
                                        status = @status, 
                                        estimatedHours = @estimatedHours, 
                                        startDate = @startDate, 
                                        endDate = @endDate, 
                                        clientID = @clientID, 
                                        employeeID = @employeeID
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);
                cmd.AddParameter("title", entity.Title);
                cmd.AddParameter("description", entity.Description);
                cmd.AddParameter("status", entity.Status);
                cmd.AddParameter("estimatedHours", entity.EstimatedHours);
                cmd.AddParameter("startDate", entity.StartDate);
                cmd.AddParameter("endDate", entity.EndDate);
                cmd.AddParameter("clientID", entity.ClientID);
                cmd.AddParameter("employeeID", entity.EmployeeID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
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
        public List<Case> FindAll()
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, title, description, status, estimatedHours, startDate, endDate, clientID, employeeID
                                    FROM Case";
                
                return MapCollection(cmd);
            }
            catch (Exception exception)
            {
                throw cmd.CreateDataException(exception);
            }
            finally
            {
                cmd.Dispose();
            }
        }

        // requires that ALL columns are selected and that they
        // are in the correct order (more performance to use the int indexer)
        private static void Map(IDataRecord record, Case dto)
        {
            dto.ID = (int)record[0];
            dto.Title = (string)record[1];
            dto.Description = (string)record[2];
            dto.Status = (bool)record[3];
            dto.EstimatedHours = record[4] is DBNull ? -1 : (int)record[4];
            dto.StartDate = (DateTime)record[5];
            dto.EndDate = (DateTime)record[6];
            dto.ClientID = (int)record[7];
            dto.EmployeeID = (int)record[8];

        }

        /// <summary>
        ///     Traverses over the entire recordset and converts the rows to items
        /// </summary>
        /// <param name="cmd">Command to invoke on</param>
        /// <returns>Collection</returns>
        private static List<Case> MapCollection(SqlCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var items = new List<Case>();
                while (reader.Read())
                {
                    var item = new Case();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }
    }
}