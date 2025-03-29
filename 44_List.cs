using System;
using System.Collections.Generic;

//44.List 与array不一样，List是可变长短的数据结构
//45.List of object
class ListObjectPlayer
{
  public String username;
  // 无static关键字意味着此方法跟Math一样，是类方法，无需new对象，直接调用；
  public ListObjectPlayer(String username)
  {
    this.username = username;
  }
  public override String ToString()
  {
    return username;
  }
}