# Patisserie Inventory Website - A database of matching flavours and related food items.
#### By _**Marcus Lorenzo**_
---


| **_Overview_:** |
|---|

### Please see gif below for work flow.
- .NET Core MVC, Entity Framework Core, Razor Pages.
- UI is a work in progress, a "cupcake and bubblegum" theme.
- Many-to-Many relationships in SQL database
- Entries list on webpage and can be CRUD individually

![- Patiesserie Database - Google Chrome 2022-07-01 22-59-03_Trim](https://user-images.githubusercontent.com/100096239/176988855-f882f82d-a8db-45ac-b40a-7838d3aa6387.gif)

#### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![image](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![image](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)  ![image](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)

* including: ASP.NET 5 MVC, VSCode
---


| **_Description_:** |
|---|

- User must log in to access data.
- Navbar informs user of log-in status.
- User can **create, read, update, and delete** `Flavours` and `Treats` to the database freely.
- User **cannot** delete relationship between instances once established (not MVP, however, will be a feature worked on in the near future).

**Notes**
- `dotnet new mvc` was used as a boilerplate and has extra code that conflicts if removed. It allowed me to focus on the MVP at the cost of excess code.
- Not able to change top-level directory name to `Patisserie.Solution`.
- Although there is small UI animation, the page is not responsive for anything other than a standard monitor/browser size.

---

| **_Setup & Installation_:** |
|---|

|   via CLI   |
|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) 
| Open Git Bash or Terminal and type: `cd desktop` 
| Next, clone `[https://github.com/marcusanthonylorenzo/](https://github.com/marcusanthonylorenzo/SweetAndSavoury.Solution)` 
| Once completed, open this new directory in your text editor
| In the root directory, create a file called `appsettings.json`.
| Inside this file write:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=marcus_lorenzo;uid=root;pwd=epicodus;"
  }
}
```

| ...continued |
|---|
| Next, go to your terminal and run `dotnet restore`, followed by `dotnet watch run`.
| Access the site via the `LocalHost` link provided in the terminal.
| **Save and you are ready to go!**

 
<!-- |  MySQL Setup  |
|---|
| In your MySQL Workbench, click Connect to Database, Stored Connection:  Local instance 3306
**Must match the `Port=3306;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| In **Schemas Navigator** in the Navigator bar on the left, right-click and select "Create Schema".
| The name of the new Schema **must match the `database=marcus_lorenzo;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| Once loaded, go to your new Schema tree in the Navigator bar on the left, click down to Tables, right click "Create Table".
| Your details should look like this:

[Image of applied tables here] -->

#### Running Tests:
- To view tests via MSTest, in your CLI type `dotnet test`.

#### Known Bugs:
* cannot delete related objects once established.

---

---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
