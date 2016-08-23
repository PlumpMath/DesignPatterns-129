<?php

/******************************************************************************/
/*  WHAT IT DOES: -returns class based on what to you want to use             */
/*  HOW IT DOES IT: -there is a Factory class that has a switch which returns */
/*                  an instance of a class based on imput                     */
/******************************************************************************/

/**
* Interface for Product
*/
interface Product
{
  void Create();
}

/**
* Interface for Factory
*/
interface Factory
{
  void getProduct($input);
}

/**
* Class NormalProduct
*/
class NormalProduct implements Product
{
  public function create()
  {
    echo "Created normal Product !\n";
  }
}

/**
* Class VirtualProduct
*/
class VirtualProduct implements Product
{
  public function create()
  {
    echo "Created virtual Product !\n";
  }
}

/**
* Class ProductFactory
*/
class ProductFactory implements Factory
{
  public function getProduct($input)
  {
    if ($input === "normal")
    {
      return new NormalProduct();
    }
    else
    {
      return new VirtualProduct();
    }
  }
}

// How it works
$factory = new ProductFactory();
$factory->getProduct('virtual')->create();
