interface EventObserver
{
  void Notify();
}

interface EventSubject
{
  void AddObserver();
  void RemoveObserver();
  void NotifyObservers();
}

class MouseClick : EventObserver
{
  public void Notify()
  {
    // MouseClick logic
  }
}

class MouseScroll : EventObserver
{
  public void Notify()
  {
    // ButtonPress logic
  }
}

class MouseEvents : EventSubject
{
  private List _list;

  public MouseEvents()
  {
    _list = new List<EventObserver>();
  }

  public void AddObserver(EventObserver Observer)
  {
    _list.Add(Observer);
  }

  public void RemoveObserver(EventObserver Observer)
  {
    _list.Remove(Observer);
  }

  public void NotifyObservers()
  {
    //foreach on _list and call Notify() method
  }
}
