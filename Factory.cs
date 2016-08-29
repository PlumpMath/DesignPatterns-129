<?php

/******************************************************************************/
/*  WHAT IT DOES: -returns class based on what to you want to use             */
/*  HOW IT DOES IT: -there is a Factory class that has a switch which returns */
/*                  an instance of a class based on imput                     */
/******************************************************************************/

/**
* Interface for Product
*/
interface IProduct
{
  void Create();
}

/**
* Interface for Factory
*/
interface IFactory
{
  void GetProduct(string input);
}

/**
* Class NormalProduct
*/
class NormalProduct : IProduct
{
  public void Create()
  {
    Console.WriteLine("Created normal Product !\n");
  }
}

/**
* Class VirtualProduct
*/
class VirtualProduct : IProduct
{
  public void Create()
  {
    Console.WriteLine("Created virtual Product !\n");
  }
}

/**
* Class ProductFactory
*/
class ProductFactory : IFactory
{
  public IProduct GetProduct(string input)
  {
    if (input == "normal")
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
var factory = new ProductFactory();
factory.GetProduct('virtual').Create();
