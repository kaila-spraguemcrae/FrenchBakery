<br>
<h1 align = "center">
  <b> Pierre's French Bakery of Sweet and Savory Treats </b>
</h1>

<p align = "center">
  This is a website for a French Bakery which allows users create an account and view, create, edit and delete treats and flavors according to their user role. 
</p>
<p align = "center"> Created January 15, 2021 </p>

<p align = "center">
  By Kaila Sprague McRae
</p>

--------------------

## 📖  Description

This is a website for Pierre's French Bakery which allows users to create an account. This application allows registered users to be assigned to different user roles. The "Admin" role allows for full access to the web application.  

This is the Independent Project for Epicodus week 12 as part of the "Authentication with Identity" coursework. 

<br>
<h3 align = "center">Regular authenticated user:</h3>
<p align = "center">
  <img src="https://media.giphy.com/media/yk0RvSBrvzCLrEdwg6/giphy.gif">
</p>

Stretch Goals:
- allow users to add Treats to an Order
- Create View for Authorization Error Handling 
- Display Login Error, such as inccorect password or username

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3.0
- .NET Core v2.2.0
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core

-------------------

## Specifications

<details>
<summary>User Stories</summary>

| Story# | User Story | Complete |
| :------------- | :------------- | :------------- |
| 01 |  A user should be able to log in and log out. | true|
| 02 | Only logged in users should have create, update and delete functionality. All users should be able to have read functionality. | true |
| 03 | A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it. | true |
| 04 | Have separate roles for admins and logged-in users. Only admins should be able to add, update and delete. | true |
| 05 | Add an order form that only logged-in users can access. A logged-in user should be able to create, read, update and delete their own order. | false |

</details>

-------------------

## 🐛 Known Bugs



| Date | Error | Handled | Solution |
| :------------- | :------------- | :------------- | :------------- |
| 01.15.2021 | `User.Identity.IsAuthenticated` always returns `false` | true | add `app.UseAuthentication();` to Startup.cs |

-------------------

## 🔧 Setup & Requirements

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### ⚙️ Clone or Download

#### To Download:

Go to my GitHub repository here, [https://guthub.com/kaila.spraguemcrae/FrenchBakery](https://guthub.com/kaila.spraguemcrae/FrenchBakery), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/kaila-spraguemcrae/FrenchBakery`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

### 🧰 Database Setup Options

#### AppSettings:

- After you have the project on your computer you will need to create a file in the root directory of the project called "appsettings.json". 
- Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=kaila_spraguemcrae_french_bakery;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```
*Please note you will need to replace `YOUR-PASSWORD-HERE` with the password you created for your MySQL server.
*You may also need to update `uid`, `port`, or `database` name depending on your configurations.

#### Import Database using Entity Framework Core:

 - In the command line run ` cd Desktop/FrenchBakery.Solution/FrenchBakery` to navigate to the "FrechBakery" folder. 
 - Next, run `dotnet ef database update` to generate the database. You can confirm the database was created by checking MySQL workbench.

*to make changed to the database you can run `dotnet ef migrations add <MigrationName>`

#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'FrenchBakery.Solution/FrenchBakery' folder (`cd FrenchBakery`) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

#### Setting up User Roles and granting "Admin" permissions

<h4>Creating a new Admin user role:</h4>
<p>
  <img src= "https://media.giphy.com/media/tzDIALhp0BzeFpVL3V/giphy.gif"> 
</p>


1. From the splash page navigate to "Register" and fill out the form.
2. Click "Log in" and fill out the form.
3. Click "Manager User Roles" and then click "Create Role" and name the new role *"Admin"*.
4. Next to add your account to the "Admin" role, click "Edit" and then click "Add or Remove Users".
5. Check the checkbox next to your user email and then click "Update"
6. To have to the role update your permission Logout and then Log back into your account. You should now see "Manage User Roles" and "ADMIN" in the navbar. 

*To have full access to the web application you will need to add the User Role "Admin" to your account.

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:kaila.sprague@icloud.com).

---------------------------

## 📘 License

MIT License

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

Copyright (c) 2020 Kaila Sprague McRae