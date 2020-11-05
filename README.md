# _Historic Fantasy Sports API_

#### _Week 7 Team Week C# API Project for Epicodus, November 2nd, 2020_

#### By _**Mike Manchee, Daniel Schaaf, Joseph Nilles, and Jeff Dinsmore**_

## Description

This Project is a Historical Fantasy Sports API. The Project has full CRUD functionality as well as Token Authentication (database security), and Swagger (API documentation). The API with also be searchable and have a random parks feature.

<!-- 

*** Further Exploration 

 -->
### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
|  1. ...  | ... | ... |


## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HFS API<!-- TITLE HERE -->

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HFS API<!-- TITLE HERE -->

### Database Setup
* Go to appsettings.json and change the password if needed.

* Setup with SQL migrations
  * In the terminal, navigate to the project folder
  * Type "dotnet ef migrations add Initial" and wait for migration file to be built
  * Type "dotnet ef database update" and wait for build confirmation

### API Second Application
* this dotnet run works with http://localhost:5000; http://localhost:5001
### Authentication Token
* Open Postman
* Open a new Tab, set to POST and type "http://localhost:5000/users/authenticate"
* Click the Body tab, select raw, and type the below.
```
{
  "Username": "test",
  "Password": "test"
}
```
* Click Send and copy the token
* Open a new tab, click the Authorization tab, Select 'Bearer Token' from the drop down, and paste the token into Token.
* You are now able to access this API from Postman.

### Swagger
* Type "dotnet watch run"
* Paste URL in browser "http://localhost:5000/swagger/"
* After getting your token, click on the Authorize button
![Authorize](USParksAPI/img/Authorize.jpg)
* Paste in your token and close
* Explore API


## Known Bugs

No Known Bugs

## Technologies Used
Project Specifics
* C# API

Main Programs
* MySQL
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
  * [Entity](https://docs.microsoft.com/en-us/ef/core/)
  * [Razor](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1)
  * [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* CSS
  * [Bootstrap](https://getbootstrap.com/docs/4.5/getting-started/introduction/)
  * [Font Awesome](https://www.w3schools.com/icons/fontawesome_icons_intro.asp)
  * [Postman](https://www.postman.com/)


### Other Links
![GitHub](USParksAPI/img/Github.png)
[Mike's GitHub](https://github.com/mmanchee)<br />
[LinkedIn](https://www.linkedin.com/in/mikemanchee/)<br /> 

### License

Copyright (c) 2020 **_{Mike Manchee, Daniel Schaaf, Joseph Nilles, and Jeff Dinsmore}_**
Licensed under MIT

Co-authored-by: Joseph Nilles <jbnilles24@gmail.com>
Co-authored-by: Jeff Dinsmore <hello@jeffdinsmore.com>
Co-authored-by: Daniel Schaaf <daniel.schaaf@outlook.com>