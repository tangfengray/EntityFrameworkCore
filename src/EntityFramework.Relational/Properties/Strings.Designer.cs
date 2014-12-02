// <auto-generated />
namespace Microsoft.Data.Entity.Relational
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
	using JetBrains.Annotations;

    public static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Relational.Strings", typeof(Strings).GetTypeInfo().Assembly);
        
        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        public static string InvalidEnumValue([CanBeNull] object argumentName, [CanBeNull] object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// The schema qualified name '{name}' is invalid. Schema qualified names must be of the form [&lt;schema_name&gt;.]&lt;object_name&gt;.
        /// </summary>
        public static string InvalidSchemaQualifiedName([CanBeNull] object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidSchemaQualifiedName", "name"), name);
        }

        /// <summary>
        /// Can not create a ModificationFunction for an entity in state '{entityState}'.
        /// </summary>
        public static string ModificationFunctionInvalidEntityState([CanBeNull] object entityState)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModificationFunctionInvalidEntityState", "entityState"), entityState);
        }

        /// <summary>
        /// Update failed. Expected {expectedRows} row(s) but {actualRows} row(s) returned.
        /// </summary>
        public static string UpdateConcurrencyException([CanBeNull] object expectedRows, [CanBeNull] object actualRows)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UpdateConcurrencyException", "expectedRows", "actualRows"), expectedRows, actualRows);
        }

        /// <summary>
        /// Multiple relational data store configurations found. A context can only be configured to use a single data store.
        /// </summary>
        public static string MultipleDataStoresConfigured
        {
            get { return GetString("MultipleDataStoresConfigured"); }
        }

        /// <summary>
        /// No relational data stores are configured. Configure a data store using OnConfiguring or by creating an ImmutableDbContextOptions with a data store configured and passing it to the context.
        /// </summary>
        public static string NoDataStoreConfigured
        {
            get { return GetString("NoDataStoreConfigured"); }
        }

        /// <summary>
        /// Both an existing DbConnection and a connection string have been configured. When an existing DbConnection is used the connection string must be set on that connection.
        /// </summary>
        public static string ConnectionAndConnectionString
        {
            get { return GetString("ConnectionAndConnectionString"); }
        }

        /// <summary>
        /// A relational store has been configured without specifying either the DbConnection or connection string to use.
        /// </summary>
        public static string NoConnectionOrConnectionString
        {
            get { return GetString("NoConnectionOrConnectionString"); }
        }

        /// <summary>
        /// The property '{propertyName}' cannot be mapped because it is of type '{propertyType}' which is currently not supported.
        /// </summary>
        public static string UnsupportedType([CanBeNull] object propertyName, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnsupportedType", "propertyName", "propertyType"), propertyName, propertyType);
        }

        /// <summary>
        /// Relational-specific methods can only be used when the context is using a relational data store.
        /// </summary>
        public static string RelationalNotInUse
        {
            get { return GetString("RelationalNotInUse"); }
        }

        /// <summary>
        /// An error occurred while updating the entries. See the inner exception for details.
        /// </summary>
        public static string UpdateStoreException
        {
            get { return GetString("UpdateStoreException"); }
        }
        
        /// <summary>
        /// The connection is already in a transaction and cannot participate in another transaction.
        /// </summary>
        public static string TransactionAlreadyStarted
        {
            get { return GetString("TransactionAlreadyStarted"); }
        }

        /// <summary>
        /// The specified transaction is not associated with the current connection. Only transactions associated with the current connection may be used.
        /// </summary>
        public static string TransactionAssociatedWithDifferentConnection
        {
            get { return GetString("TransactionAssociatedWithDifferentConnection"); }
        }

        /// <summary>
        /// A query containing the Skip operator must include at least one OrderBy operation.
        /// </summary>
        public static string SkipNeedsOrderBy
        {
            get { return GetString("SkipNeedsOrderBy"); }
        }

        /// <summary>
        /// The SQL Server sequence '{sequenceName}' was already specified with a different definition.
        /// </summary>
        public static string SequenceDefinitionMismatch([CanBeNull] object sequenceName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SequenceDefinitionMismatch", "sequenceName"), sequenceName);
        }

        /// <summary>
        /// Creating database '{databaseName}'.
        /// </summary>
        public static string RelationalLoggerCreatingDatabase([CanBeNull] object databaseName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerCreatingDatabase", "databaseName"), databaseName);
        }

        /// <summary>
        /// Opening connection '{connectionString}'.
        /// </summary>
        public static string RelationalLoggerOpeningConnection([CanBeNull] object connectionString)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerOpeningConnection", "connectionString"), connectionString);
        }

        /// <summary>
        /// Closing connection '{connectionString}'.
        /// </summary>
        public static string RelationalLoggerClosingConnection([CanBeNull] object connectionString)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerClosingConnection", "connectionString"), connectionString);
        }

        /// <summary>
        /// Beginning transaction with isolation level '{isolationLevel}'.
        /// </summary>
        public static string RelationalLoggerBeginningTransaction([CanBeNull] object isolationLevel)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerBeginningTransaction", "isolationLevel"), isolationLevel);
        }

        /// <summary>
        /// Committing transaction.
        /// </summary>
        public static string RelationalLoggerCommittingTransaction
        {
            get { return GetString("RelationalLoggerCommittingTransaction"); }
        }

        /// <summary>
        /// Rolling back transaction.
        /// </summary>
        public static string RelationalLoggerRollingbackTransaction
        {
            get { return GetString("RelationalLoggerRollingbackTransaction"); }
        }

        /// <summary>
        /// Invalid type for sequence. Valid types are 'Int64' (the default), 'Int32', 'Int16', and 'Byte'.
        /// </summary>
        public static string BadSequenceType
        {
            get { return GetString("BadSequenceType"); }
        }

        /// <summary>
        /// Unable to deserialize sequence from model metadata. See inner exception for details.
        /// </summary>
        public static string BadSequenceString
        {
            get { return GetString("BadSequenceString"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
