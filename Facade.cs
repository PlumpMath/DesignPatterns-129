<?php

/******************************************************************************/
/*  WHAT IT DOES: -runs all complex processes under a wrapper                 */
/*  HOW IT DOES IT: -the facade class calls  the methods from all the         */
/*                  the complex classes in one method                         */
/******************************************************************************/

/**
* Class Processor
*/
class Processor
{
  public void RunProcess()
  {
    // Complex computer CPU process data
  }
}

/**
* Class VideoCard
*/
class VideoCard
{
  public void RenderGraphics()
  {
    // Complex video card algorithm
  }
}

/**
* Class Ram
*/
class Ram
{
  public void StartMemory()
  {
    // Complex Ram stuff
  }
}

/**
* Class ComputerFacade
*/
class ComputerFacade
{
  private Processor _processor;
  private VideoCard _videocard;
  private Ram _ram;

  public ComputerFacade()
  {
    _processor = new Processor();
    _videocard = new VideoCard();
    _ram = new Ram();
  }

  public function StartComputer()
  {
    _processor.RunProcess();
    _videocard.RenderGraphics();
    _ram.StartMemory();
  }
}

// How it works
var facade = new ComputerFacade();
facade.StartComputer();
