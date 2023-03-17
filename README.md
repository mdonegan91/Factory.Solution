# 🏭 Dr. Sillystringz's Factory 🏭

#### By Molly Donegan

#### _An MVC web application to keep track of machine repairs._

## 🪛 Technologies Used 🪛

* _C#_
* _.NET_
* _MVC_
* _SQL Workbench_
* _Entity Framework_

## 🔩 Description 🔩

A factory manager can use the website to do the following:

* Manage engineers, and the machines they are licensed to fix

* Add lists of engineers and lists of machines

* Specify which engineers are licensed to repair which machines

## 🔧 How To Run This Project 🔧

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Within the production directory "Factory", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=epicodus;"
  }
}
```

5. Create the database using the migrations in the Factory project. Open your shell (e.g., Terminal or GitBash) to the production directory "Factory", and run `dotnet ef database update`. 
6. Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, visit: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## ⚙️ Known Bugs ⚙️

* _NA_

_Please reach out with any questions or concerns [mollyrdonegan@gmail.com](mollyrdonegan@gmail.com)_

## 🧰 License 🧰

_[MIT](https://github.com/mdonegan91/Factory.Solution/blob/main/LICENSE)_

Copyright (c) _2023_ _Molly Donegan_