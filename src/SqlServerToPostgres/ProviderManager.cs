// <copyright file="ProviderManager.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Data.Common;

namespace SqlServerToPostgres;

public enum ProviderType
{
    SqlServer,
    Postgres,
    Npgsql
}

public static class ProviderManager
{
    public static void Register()
    {
        DbProviderFactories.RegisterFactory(ProviderType.Npgsql.ToString(), Npgsql.NpgsqlFactory.Instance);
        DbProviderFactories.RegisterFactory(ProviderType.Postgres.ToString(), Npgsql.NpgsqlFactory.Instance);
        DbProviderFactories.RegisterFactory(ProviderType.SqlServer.ToString(), Microsoft.Data.SqlClient.SqlClientFactory.Instance);
    }

    public static DbProviderFactory GetProvider(ProviderType providerType)
    {
        return DbProviderFactories.GetFactory(providerType.ToString());
    }

    public static DbProviderFactory GetProvider(string providerType)
    {
        ArgumentNullException.ThrowIfNull(providerType);
        return DbProviderFactories.GetFactory(providerType);
    }
}
