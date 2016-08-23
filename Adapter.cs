<?php

/******************************************************************************/
/*  WHAT IT DOES: -makes two separate interfaces compatible                   */
/*  HOW IT DOES IT: -creates another class that implements the interface that */
/*                  the adapter will be used for                              */
/*                  -the implemented method calls the adapted method          */
/******************************************************************************/

/**
* Interface for SQL
*/
interface ISQL
{
  string DoSqlQuery();
}

/**
* Interface for NoSQL
*/
interface INoSQL
{
  string DoNoSqlQuery();
}

/**
* Class Mysql
*/
class Mysql : ISQL
{
  public string DoSqlQuery()
  {
    Console.WriteLine("Run sql query");
  }
}

/**
* Class Casandra
*/
class Casandra : INoSQL
{
  public string DoNoSqlQuery()
  {
    Console.WriteLine("Run nosql query");
  }
}

/**
* Class Adapter
*/
class Adapter : NoSQL
{
  private ISQL _sqlinterface;

  public function __construct(ISQL Sqlinterface)
  {
    _sqlinterface = Sqlinterface;
  }

  public function DoNoSqlQuery()
  {
    _sqlinterface.DoSqlQuery();
  }
}


// How it works
var sql = new Mysql();
var adapter = new Adapter(sql);
adapter.DoNoSqlQuery();
