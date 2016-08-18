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
interface SQL
{
  function doSqlQuery();
}

/**
* Interface for NoSQL
*/
interface NoSQL
{
  function doNoSqlQuery();
}

/**
* Class Mysql
*/
class Mysql implements SQL
{
  public function doSqlQuery()
  {
    echo "Run sql query\n";
  }
}

/**
* Class Casandra
*/
class Casandra implements NoSQL
{
  public function doNoSqlQuery()
  {
    echo "Run nosql query\n";
  }
}

/**
* Class Adapter
*/
class Adapter implements NoSQL
{
  private $sqlinterface;

  public function __construct(SQL $sqlinterface)
  {
    $this->sqlinterface = $sqlinterface;
  }

  public function doNoSqlQuery()
  {
    $this->sqlinterface->doSqlQuery();
  }
}


// How it works
$sql = new Mysql();
$adapter = new Adapter($sql);
$adapter->doNoSqlQuery();
