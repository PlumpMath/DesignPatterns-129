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
interface IVisitee
{
  void Accept(IVisitor visitor);
}

/**
* Interface for Visitor
*/
interface IVisitor
{
  void VisitLeftNode(LeftNode leftNode);
  void VisitRightNode(RightNode rightNode);
}

/**
* Class LeftNode
*/
class LeftNode : IVisitee
{
  public void TranverseLeftNode(string str)
  {
    Console.WriteLine(str);
  }

  public void Accept(Visitor visitor)
  {
      visitor.VisitLeftNode(this);
  }
}

/**
* Class RightNode
*/
class RightNode : IVisitee
{
  public void TranverseRightNode(string str)
  {
    Console.WriteLine(str)
  }

  public void Accept(Visitor visitor)
  {
      visitor.VisitRightNode(this);
  }
}

/**
* Class SimpleNodeVisitor
*/
class SimpleNodeVisitor : IVisitor
{
  public void VisitLeftNode(LeftNode leftNode)
  {
    leftNode.TranverseLeftNode("We are transversing the leftNode using SimpleNodeVisitor\n");
  }

  public void visitRightNode(RightNode leftNode)
  {
    leftNode.TranverseRightNode("We are transversing the rightNode using SimpleNodeVisitor\n");
  }
}

/**
* Class ComplexNodeVisitor
*/
class ComplexNodeVisitor : IVisitor
{
  public void VisitLeftNode(LeftNode leftNode)
  {
    leftNode.TranverseLeftNode("We are transversing the leftNode using ComplexNodeVisitor\n");
  }

  public void VisitRightNode(RightNode leftNode)
  {
    leftNode.TranverseRightNode("We are transversing the rightNode using ComplexNodeVisitor\n");
  }
}

// How it works
var leftNode = new LeftNode();
var rightNode = new RightNode();

var simpleNodeVisitor = new simpleNodeVisitor();
var complexNodeVisitor = new complexNodeVisitor();

simpleNodeVisitor.VisitLeftNode(leftNode);
simpleNodeVisitor.VisitRightNode(rightNode);

complexNodeVisitor.VisitLeftNode(leftNode);
complexNodeVisitor.VisitRightNode(rightNode);
