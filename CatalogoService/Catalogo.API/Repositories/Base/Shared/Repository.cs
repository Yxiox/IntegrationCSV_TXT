using System.Data;
using MySql.Data.MySqlClient;

/*
File Auto Generated. This file is only generate once.

DO NOT MODIFY THE FILE NAME AND ITS LOCATION
YOU CAN MODIFY THE CLASS METHODS IMPLEMENTATIONS

This class is the base class for all repositories.
When generating the files, this file will be searched for by its name and/or path,
If not found, it will be recreated and you may lose any modifications you have made.
*/

namespace Catalogo.API.Repositories.Base.Shared;

public class Repository : IRepository
{
    private IDbConnection _connection;
    private IDbTransaction _transaction;

    protected IDbConnection Open()
    {
        _connection = new MySqlConnection("server=localhost;user id=root;pwd=root;database=catalogo") ;
        return _connection;
    }

    protected void Close()
    {
        _connection.Close();
    }

    public IDbTransaction BeginTransaction()
    {
        Open();
        _connection.Open();
        _transaction = _connection.BeginTransaction();
        return _transaction;
    }

    public void Commit()
    {
        _transaction.Commit();
        Close();
    }

    public void Rollback()
    {
        _transaction.Rollback();
        Close();
    }
}
