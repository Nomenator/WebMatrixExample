# WebMatrixExample

Got the basis for this project from this article at [codeguru](https://www.codeguru.com/csharp/.net/net_asp/mvc/using-simplemembership-in-asp.net-mvc-4.htm) 

This is a simple web app that only has the functionality for users to log in. This demonstrates how to use the Webmatrix.Websecurity library to maintain user accounts.

You might need to run the nuget command `Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r` in order to run it properly, if you get the error 

```
Could not find a part of the path '...\WebMatrixExample\bin\roslyn\csc.exe'.
```

Adjust the database connection string in web.config as needed.
