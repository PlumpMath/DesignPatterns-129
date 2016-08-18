<?php

/******************************************************************************/
/*  WHAT IT DOES: -creates many to many relationship                          */
/*  HOW IT DOES IT: -the Visitee interface depends on the Visitor interface   */
/*                  -the Visitor interface has methods that depent            */
/*                   on each Visitee                                          */
/******************************************************************************/

/**
* Interface for Visitee
*/
interface Visitee
{
  function accept(Visitor $visitor);
}

/**
* Interface for Visitor
*/
interface Visitor
{
  function visitLeftNode(LeftNode $leftNode);
  function visitRightNode(RightNode $rightNode);
}

/**
* Class LeftNode
*/
class LeftNode implements Visitee
{
  public function tranverseLeftNode($string)
  {
    echo $string;
  }

  public function accept(Visitor $visitor)
  {
      $visitor->visitLeftNode($this);
  }
}

/**
* Class RightNode
*/
class RightNode implements Visitee
{
  public function tranverseRightNode($string)
  {
    echo $string;
  }

  public function accept(Visitor $visitor)
  {
      $visitor->visitRightNode($this);
  }
}

/**
* Class SimpleNodeVisitor
*/
class SimpleNodeVisitor implements Visitor
{
  public function visitLeftNode(LeftNode $leftNode)
  {
    $leftNode->tranverseLeftNode("We are transversing the leftNode using SimpleNodeVisitor\n");
  }

  public function visitRightNode(RightNode $leftNode)
  {
    $leftNode->tranverseRightNode("We are transversing the rightNode using SimpleNodeVisitor\n");
  }
}

/**
* Class ComplexNodeVisitor
*/
class ComplexNodeVisitor implements Visitor
{
  public function visitLeftNode(LeftNode $leftNode)
  {
    $leftNode->tranverseLeftNode("We are transversing the leftNode using ComplexNodeVisitor\n");
  }

  public function visitRightNode(RightNode $leftNode)
  {
    $leftNode->tranverseRightNode("We are transversing the rightNode using ComplexNodeVisitor\n");
  }
}

// How it works
$leftNode = new LeftNode();
$rightNode = new RightNode();

$simpleNodeVisitor = new simpleNodeVisitor();
$complexNodeVisitor = new complexNodeVisitor();

$simpleNodeVisitor->visitLeftNode($leftNode);
$simpleNodeVisitor->visitRightNode($rightNode);

$complexNodeVisitor->visitLeftNode($leftNode);
$complexNodeVisitor->visitRightNode($rightNode);
