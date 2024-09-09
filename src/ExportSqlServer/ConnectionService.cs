// <copyright file="ConnectionService.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Finder;
public class ConnectionService
{
    public ConnectionService(IOptions<ApplicationOptions> options)
    {
        ApplicationOptions = options.Value;
    }

    private ApplicationOptions ApplicationOptions { get; }

    public SqlConnection CreateConnection()
    {
        return new SqlConnection(ApplicationOptions.ConnectionString);
    }

    public int CommandTimeout => ApplicationOptions.CommandTimeout;
}
