<?php

interface UserBuilderInterface
{
  function setUserName($name);
  function setUserAge($age);
}

class User
{
  private $name;
  private $age;

  public function setName($name)
  {
    $this->name = $name;
  }

  public function getName()
  {
    return $this->name;
  }

  public function setAge($age)
  {
    $this->age = $age;
  }
  public function getAge()
  {
    return $this->age;
  }
}

class UserBuilder implements UserBuilderInterface
{
    private $user;

    public function __construct()
    {
      $this->user = new User();
    }

    public function setUserName($name)
    {
      $this->user->setName($name);
    }

    public function setUserAge($age)
    {
      $this->user->setAge($age);
    }

    public function getUser()
    {
      return $this->user;
    }
}

$builder = new UserBuilder();
$builder->setUserName("John Cena");
$builder->setUserAge(22);

var_dump($builder->getUser());
