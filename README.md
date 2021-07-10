# _Animal Shelter API_

 * _Animal Shelter API_
 * _Date Created: July 4th 2021_
  * _Date Edited: July 10th 2021_

#### By _**Garrett Brown**_

## Description
An API that keeps track of cats and dogs within an animal shelter. Admin has full CRUD functionality (create, read, update, delete) and can search by parameters or by id. Animals are assigned an id, which catalogues their name, species, sex, and age (in years).

***

## Setup/Installation Requirements

_Table of Contents_
* Required Programs
* Installation of Program
* Startup

<details>
    <summary>Expand for Instructions</summary>

### Required Programs
1. An internet browser.
2. Visual Code Studio (or another code editor).
3. .NET
4. MySQL
5. MySQLWorkbench


### Installation of Program
* _Open the terminal on your local machine and navigate to "Desktop."_
* _Clone "AnimalShelterAPI.Solution" with the following git command `git clone https://github.com/GBProductions/AnimalShelterAPI.Solution.git`
* _Navigate to the top level of the repository with the command `cd AnimalShelterAPI.Solution`_ 
* _Navigate into "AnimalShleter" with git command `cd AnimalShelter`_

### AppSettings

#### Instructions: `appsettings.json` Creation

1. Create a file in the root directory called `appsettings.json`. 
2. Add `appsettings.json` to `.gitignore`.
3. Insert the following code into `appsettings.json`:
    
``` 
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

4. Replace `YOUR-PASSWORD` with password you selected when installing MySQLWorkbench.
5. Replace database name with the name of your database (if necessary).
6. Replace port name with the port of your choice (if necessary).
7. In the root directory, run `dotnet ef databse update` 
8. In the root directory, run `dotnet ef databse restore`

This will recreate the database on your computer, using MySQLWorkbench. You can proceed to Startup.


### Startup
* Navigate to root directory in project.
* Restore project with git command `dotnet restore`
* Build project with git command `dotnet build`
* To run program, run git command `dotnet run`
* In browser, navigate to http://localhost:5000 

</details>

## API Exploration
### Swagger
To explore AnimalShelterAPI with Swagger - Swashbuckle, go to your program directory and launch the program with `dotnet run`. Once the program is running, open a browser window and go to `http://localhost:5001/swagger`, and you will be able to navigate and have full CRUD functionality.

### Endpoints

Basic URL: `https://localhost5001`

HTTP Request Structure (add after Basic URL)

```
| Route                      | Usage                 |   
|----------------------------|-----------------------|
| GET /api/Animals           | Return all animals    | 
| POST /api/Animals          | Create new animal     |
| GET /api/Animals/{id}      | Return animal by id   |
| PUT /api/Animals/{id}      | Edit animal by id     |
| DELETE /api/Animals/{id}   | Delete animal by id   |
```
### Path Parameters
Explanation of parameters for Animals:

```
| Parameter | Required? | Type   | Description                                |
|-----------|-----------|--------|--------------------------------------------|
| Name      | yes       | string | Returns by name of animal.                 |
| Species   | yes       | string | Returns animal by species identification.  |
| Sex       | yes       | string | Returns animal by sex.                     |
| Age       | yes       | int    | Returns matches by age of animal in years. |
```

### Searching via Parameters
In order to search for animals matching a parameter, use this format:

```
GET /api/Animals?{parameter}={search-term}
```

#### Example:
```
http://localhost:5001/api/Animals?sex=male
```

In order to search for a specific animal matching multiple parameters, add a `&` between searches:

#### Example:
```
http://localhost:5001/api/Animals?sex=male&species=dog
```

*** 

## Known Bugs

_There are currently no known bugs._

## Support and contact details

_For assistance, please contact Garrett Brown <garrettpaulbrown@gmail.com>_

## Technologies Used

* _Github, VS Code_
* _MarkDown_
* _Entity Framework_
* _C#_
* _.NET Core 5.0.1_
* _Swagger - Swashbuckle_


### License

*Available under MIT Licensing*

Copyright (c) 2021 **_Garrett Brown_**

