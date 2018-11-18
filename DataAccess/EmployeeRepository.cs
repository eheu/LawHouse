using System;
using System.Collections.Generic;
using System.Data;
using Abstraction.Employees;
using Abstraction.Shared;
using System.Data.SqlClient;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlTransaction _transaction;

        /// <summary>
        ///     Create a new instance of <see cref="EmployeeRepository" />.
        /// </summary>
        /// <param name="transaction">Active transaction</param>
        /// <exception cref="ArgumentNullException">transaction</exception>
        public EmployeeRepository(SqlTransaction transaction)
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
        public void Create(Employee entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");


            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"INSERT INTO Employee (firstName, lastName, roleID)
                                    VALUES(@firstName, @lastName, @roleID);SELECT CAST(SCOPE_IDENTITY() AS INT);";
                                    
                cmd.AddParameter("firstName", entity.FirstName);
                cmd.AddParameter("lastName", entity.LastName);
                cmd.AddParameter("roleID", entity.RoleID);

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
                cmd.CommandText = @"DELETE FROM Employee
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
        public void Delete(Employee entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"DELETE FROM Employee
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
        public Employee Get(int ID)
        {
            if (ID == 0) throw new ArgumentOutOfRangeException("ID", ID, "Must be 1 or larger.");

            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, firstName, lastName, roleID
                                    FROM Employee
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", ID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var entity = new Employee();
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
        public void Update(Employee entity)
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"UPDATE Employee SET
                                        firstName = @firstName, 
                                        lastName = @lastName, 
                                        roleID = @roleID
                                    WHERE ID = @ID";
                cmd.AddParameter("ID", entity.ID);
                cmd.AddParameter("firstName", entity.FirstName);
                cmd.AddParameter("lastName", entity.LastName);
                cmd.AddParameter("roleID", entity.RoleID);

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
        public List<Employee> FindAll()
        {
            var cmd = _transaction.Connection.CreateCommand();
            try
            {
                cmd.Transaction = _transaction;
                cmd.CommandText = @"SELECT ID, firstName, lastName, roleID
                                    FROM Employee";
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
        private static void Map(IDataRecord record, Employee dto)
        {
            dto.ID = (int)record[0];
            dto.FirstName = (string)record[1];
            dto.LastName = (string)record[2];
            dto.RoleID = (int)record[3];

        }

        /// <summary>
        ///     Traverses over the entire recordset and converts the rows to items
        /// </summary>
        /// <param name="cmd">Command to invoke on</param>
        /// <returns>Collection</returns>
        private static List<Employee> MapCollection(SqlCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var items = new List<Employee>();
                while (reader.Read())
                {
                    var item = new Employee();
                    Map(reader, item);
                    items.Add(item);
                }
                return items;
            }
        }
    }
}