// <auto-generated />
namespace Microsoft.Data.Entity.Migrations
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
	using JetBrains.Annotations;

    public static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Migrations.Strings", typeof(Strings).GetTypeInfo().Assembly);
        
        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        public static string InvalidEnumValue([CanBeNull] object argumentName, [CanBeNull] object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// The current migration SQL generator '{sqlGeneratorType}' is unable to generate SQL for operations of type '{operationType}'.
        /// </summary>
        public static string UnknownOperation([CanBeNull] object sqlGeneratorType, [CanBeNull] object operationType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnknownOperation", "sqlGeneratorType", "operationType"), sqlGeneratorType, operationType);
        }

        /// <summary>
        /// The target migration '{targetMigrationName}' was not found.
        /// </summary>
        public static string TargetMigrationNotFound([CanBeNull] object targetMigrationName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TargetMigrationNotFound", "targetMigrationName"), targetMigrationName);
        }

        /// <summary>
        /// The history repository includes a migration with the identifier '{migrationId}' but the migration assembly does not contain the corresponding migration class.
        /// </summary>
        public static string LocalMigrationNotFound([CanBeNull] object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LocalMigrationNotFound", "migrationId"), migrationId);
        }

        /// <summary>
        /// '{migrationId}' is not a valid migration identifier.
        /// </summary>
        public static string InvalidMigrationId([CanBeNull] object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidMigrationId", "migrationId"), migrationId);
        }

        /// <summary>
        /// '{migrationType}' does not implement IMigrationMetadata.
        /// </summary>
        public static string MissingMigrationMetadata([CanBeNull] object migrationType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MissingMigrationMetadata", "migrationType"), migrationType);
        }

        /// <summary>
        /// Creating migration history table.
        /// </summary>
        public static string MigratorLoggerCreatingHistoryTable
        {
            get { return GetString("MigratorLoggerCreatingHistoryTable"); }
        }

        /// <summary>
        /// Dropping migration history table.
        /// </summary>
        public static string MigratorLoggerDroppingHistoryTable
        {
            get { return GetString("MigratorLoggerDroppingHistoryTable"); }
        }

        /// <summary>
        /// Applying migration '{migrationId}'.
        /// </summary>
        public static string MigratorLoggerApplyingMigration([CanBeNull] object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigratorLoggerApplyingMigration", "migrationId"), migrationId);
        }

        /// <summary>
        /// Reverting migration '{migrationId}'.
        /// </summary>
        public static string MigratorLoggerRevertingMigration([CanBeNull] object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigratorLoggerRevertingMigration", "migrationId"), migrationId);
        }

        /// <summary>
        /// The database is up to date.
        /// </summary>
        public static string MigratorLoggerUpToDate
        {
            get { return GetString("MigratorLoggerUpToDate"); }
        }

        /// <summary>
        /// Migrations-specific methods can only be used when the context is using a migrations-enabled data store.
        /// </summary>
        public static string MigrationsNotInUse
        {
            get { return GetString("MigrationsNotInUse"); }
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
