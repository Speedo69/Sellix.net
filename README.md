![Travis (.com)](https://img.shields.io/travis/com/Speedo69/Sellix.net?style=for-the-badge)
![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/Speedo69/Sellix.net?style=flat-square)
[![Nuget](https://img.shields.io/nuget/dt/sellix.net?style=flat-square)](https://www.nuget.org/packages/Sellix.Net/)

# Sellix.net
Sellix.IO API Wrapper written with C# & :heartpulse:

# How to Use
  Include Sellix.Net,
```C#
 using Sellix.Net;
```
  Make a new Sellix client.
  ```C#
  var Sellix = new Sellix(your_token, HttpClient)
  ```
  Enjoy!
  ```C#   
   Sellix.Orders.GetOrders();
  ```
  For documentation please refer to https://developers.sellix.io/
