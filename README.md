<br>
<p align="center">
  <u><big>|| <b>HFSApi</b> ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
     <a href="https://github.com/mmanchee/HFSapi">
        <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRg8aIzTS1I4DgL0ebgoa0vOWW16cXBqY4JBw&usqp=CAU">
    </a>
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/dschaaf89">
            <strong>Daniel Schaaf</strong>
        </a>
        <a href="https://github.com/mmanchee">
            <strong>Mike Manchee</strong>
        </a>
        <a href="https://github.com/jbnilles">
            <strong>Joseph Niles</strong>
        </a>
        <a href="https://github.com/jeffdinsmore">
            <strong>Jeffery Dinsmore</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/mmanchee/HFSapi/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/mmanchee/HFSapi.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/mmanchee/HFSapi/stargazers">
            <img src="https://img.shields.io/github/stars/mmanchee/HFSapi.svg?color=yellow&style=plastic">
        </a>
        ¨
        <a href="https://github.com/mmanchee/HFSapi/issues">
            <img src="https://img.shields.io/github/issues/mmanchee/HFSapi?style=plastic">
        </a>
        ¨
        <a href="https://github.com/mmanchee/HFSapi/blob/master/LICENSE.txt">
            <img src="https://img.shields.io/github/license/mmanchee/HFSapi?color=orange&style=plastic">
        </a>
        ¨
    </p>
</p>
<p align="center">
  <small>Initiated 10/20/2020.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/mmanchee/HFSapi"><big>Project Docs</big></a> ·
    <a href="https://github.com/mmanchee/HFSapi/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/mmanchee/HFSapi/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
An API that functions as a statistical database for a Historical Fantasy Football League.It has data of about 6 seasons of American Football from the years 1999 - 2004. It utilizes RESTful principles, enables Cors, version control, and has integrated authentication to keep the API Read-Only for all users except administrators. It also utilizes Pagination The user is able to see the in-use version of the API when using Postman.

### 🦠 Known Bugs

* There are no known bugs at this time.

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 ](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [HFSapi Repository here](https://github.com/mmanchee/HFSapi).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/mmanchee/HFSapi.git`
  5) Run the command `cd HFSapi` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

 #### Download

  1) Navigate to the [HFSapi Repository here](https://github.com/mmanchee/HFSapi).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the HFSapi/HFSapi directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=hfsapi;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to HFSapi/HFSapi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/HFSapi/HFSapi`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to HFSapi/HFSapi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/HFSApi/HFSapi`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Historical Football Stats api with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger/index.html`

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authenticate`
* Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "test",
    "Password": "test"
}
```
* The token will be generated in the response. Copy and paste it as the Token parameter in the Authorization tab.

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

#### Example Query
```
https://localhost:5000/api/games/
```

To use default, _don't include_ `limit` and `start` or set them equal to zero.

### Endpoints
Base URL: `https://localhost:5000`


![picture](images/swaggerEndpoints.jpg)


#### HTTP Request Structure
```
GAMES
GET /api/Games
GET /api/Games/{id}
GET /api/Games/search
GET /api/Games/GetGame

PLAYERS
GET /api/players
GET /api/Players{id}
GET /api/Players/search

USERS
POST /Users/authenticate
Get/Users


```

#### Example Query
```
https://localhost:5000/api/Games/2
```

#### Sample JSON Response
```
{
    "data": {
        "gameId": 99,
        "season": 1999,
        "week": 8,
        "playerId": 4,
        "team": "NOR",
        "passYards": 0,
        "recYards": 32,
        "rushYards": 2,
        "interceptions": 0,
        "fumbles": 0,
        "receptions": 2,
        "passTDs": 0,
        "rushTDs": 0,
        "recTDs": 0
    },
    "succeeded": true,
    "errors": null,
    "message": ""
}
```

..........................................................................................


..........................................................................................

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Daniel Schaaf](https://linkedin.com/in/danielschaaf) | [dschaaf89](https://github.com/dschaaf89) |  [Daniel.schaaf@outlook.com](mailto:Daniel.schaaf@outlook.com) |
| [Mike Manchee](https://www.linkedin.com/in/mikemanchee/) | [mmanchee](https://github.com/mmanchee) |  [mikemanchee@gmail.com](mailto:mikemanchee@gmail.com) |
|[Joseph Niles]()|[jbnilles](https://github.com/jbnilles)| [jbnilles24@gmail.com](mailto:jbnilles24@gmail.com)
|[Jeffery Dinsmore]()|[jeffdinsmore](hhttps://github.com/jeffdinsmore)| [hello@jeffdinsmore.com](mailto:hello@jeffdinsmore.com)

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2020 Daniel Schaaf and William Donovan-Seid. All Rights Reserved.
```
MIT License

Copyright (c) 2020 **_Daniel Schaaf, Mike Manchee, Joseph Niles and Jeffery Dinsmore_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://lh3.googleusercontent.com/proxy/6QlFHq-RHi9-Jd7pjdpwFdWMTYy5y26LesKZG-TO7rD3ZCh2BESLUzktpd27TAXSiGd19f8B3AxMn5Nbos1g6QCHAQOTrvVsAVnqS7RKSCQLV6s)
> "...The Internet is becoming the town square for the global village of tomorrow..."
> - Bill Gates

------------------------------

<center><a href="#">Return to Top</a></center>
