# _Doctor's Office_

#### By Eliot Gronstal, Kai Clausen, Molly Donegan

#### _An MVC web application to keep track of machine repairs._

## Technologies Used

* _C#_
* _.NET_
* _MVC_
* _SQL Workbench_
* _Entity Framework_

## Description

A factory manager can use the website to do the following:

* Manage engineers, and the machines they are licensed to fix

* Add lists of engineers and lists of machines

* Specify which engineers are licensed to repair which machines

## Setup/Installation Requirements

* _Clone this repo._
* _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Factory"._
* _In the command line, run the command ``dotnet run`` to compile and execute the application._
* _Optionally, you can run ``dotnet build`` to compile this app without running it._
* _This program was built using `Microsoft .NET SDK 6.0`, and may not be compatible with other versions._
* _If you want to run the project in production mode with a watcher, you can use a command line flag to specify that you want to run the "production" profile. ``dotnet watch run --launch-profile "production"``_
*  _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, visit: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## SQL Workbench Configuration
* _Create an `appsetting.json` file in the "Factory" directory of the project._
* _Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL._ 
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _If you'd like to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore first._

## Known Bugs

* _NA_

* _Please reach out with any questions or concerns to [mollyrdonegan@gmail.com](mollyrdonegan@gmail.com)_

## License

_[MIT](https://github.com/mdonegan91/Factory.Solution/blob/main/LICENSE)_

Copyright (c) _2023_ _Molly Donegan_