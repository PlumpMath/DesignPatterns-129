/******************************************************************************/
/*  WHAT IT DOES: -adds more functionality to a class method                  */
/*  HOW IT DOES IT: -a decorator interface extends the class interface and    */
/*                  uses the same method to call the class method             */
/******************************************************************************/

/**
* Interface IUser.
*
* Used for User class to get a user name.
*/
interface IUser
{
  string GetName();
}

/**
* Interface UserDecorator.
*
* Used for the User Decorator to add more
* Functionality to the User GetName method.
*/
interface UserDecorator : IUser{}

/**
* Class User.
*
* Contains user information.
*/
class User : IUser
{
  /**
  * Returns the user name
  *
  * Return string.
  */
  public string GetName()
  {
    return "Andrew"
  }
}

/**
* Class UserInfo.
*
* Used as decorator for the User class.
*/
class UserInfo : UserDecorator
{
  /**
  * User object.
  */
  private User _user;

  /**
  * UserInfo constructor.
  */
  public UserInfo(User user)
  {
    _user = user;
  }

  /**
  * Decorates the GetName method from User class.
  *
  * Return string.
  */
  public string GetName()
  {
    return "Hello, my name is " + _user.GetName();
  }
}
