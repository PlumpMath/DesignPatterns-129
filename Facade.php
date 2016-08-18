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
  public function runProcess()
  {
    // Complex computer CPU process data
  }
}

/**
* Class VideoCard
*/
class VideoCard
{
  public function renderGraphics()
  {
    // Complex video card algorithm
  }
}

/**
* Class Ram
*/
class Ram
{
  public function startMemory()
  {
    // Complex Ram stuff
  }
}

/**
* Class ComputerFacade
*/
class ComputerFacade
{
  private $processor;
  private $videocard;
  private $ram;

  public function __construct()
  {
    $this->processor = new Processor();
    $this->videocard = new VideoCard();
    $this->ram = new Ram();
  }

  public function startComputer()
  {
    $this->processor->runProcess();
    $this->videocard->renderGraphics();
    $this->ram->startMemory();
  }
}

// How it works
$facade = new ComputerFacade();
$facade->startComputer();
