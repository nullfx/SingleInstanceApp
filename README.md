# Single instance app example

This is a sample C# .net windows forms app which employs a mutex and win32 to prevent multiple instances of itself from running and brings the original instance to the foreground when subsequent instances run.

![](images/single-instance-app.png)

The relevant files are [Program.cs](src/SingleInstanceApp/Program.cs) and [Form1.cs](src/SingleInstanceApp/Form1.cs) files.

More on this sample can be found [here](http://sanity-free.org/csharp_dotnet_single_instance_application.html)
