<?php

interface IUserBuilderInterface
{
  void SetUserName(string name);
  void SetUserAge(int age);
}

class User
{
  private string _name;
  private int _age;

  public void SetName(string name)
  {
    _name = name;
  }

  public string GetName()
  {
    return _name;
  }

  public void SetAge(age)
  {
    _age = age;
  }
  public int GetAge()
  {
    return _age;
  }
}

class UserBuilder : IUserBuilderInterface
{
    private User _user;

    public UserBuilder()
    {
      _user = new User();
    }

    public void SetUserName(string name)
    {
      _user->SetName(name);
    }

    public void SetUserAge(int age)
    {
      _user->SetAge(age);
    }

    public string GetUser()
    {
      return _user;
    }
}

var builder = new UserBuilder();
builder.SetUserName("John Cena");
builder.SetUserAge(22);
