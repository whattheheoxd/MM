Magic Mirror

The code structure of our program is set up like a tree, with the files App.xaml and App.xaml.cs acting
as our root. From here, all other files are working independently as leaf nodes and one can navigate in 
between pages and classes by using the global object this.Frame. The folders we have: Assets, CalendarFolder, 
Helpers, Music, etc. were added to provide background resources to all other classes to use to make their 
development more convenient. This is also where the APIs we chose to use are located.


To setup and build this code on Microsoft Visual Studios 2017, clone the git and be sure that all of the 
necessary NuGet packages are included/installed. Also, it is crucial to set the Target Version of the project
to the Windows 10 Fall creators Update. After doing so, make sure the project is set to x64 and compiles on 
the Local Machine (the project can be set to Debug or Release) and then you can run the program.
