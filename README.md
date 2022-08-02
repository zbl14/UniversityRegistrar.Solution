# Univserity Registrar

#### By _**Zhibin Liang**_, _**Liam Campbell**_

#### 

---
## Technologies Used

* _C#_
* _HTML/CSS_
* _ASP.Net Core MVC_
* _Entity Framework_
* _MySQL_

---
## Description



---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>

* Requires _MySQL_ for the database
* Install _Microsoft .NET SDK_
* Clone the repo
    ```
    $ git clone
    ```
</details>

<details>
<summary><strong>To Run</strong></summary>

* Navigate to  
   <pre>UniversityRegistrar.Solution
   ├── <strong>UniversityRegistrar</strong>
   └── UniversityRegistrar.Tests</pre>
* Create ```appsettings.json``` in the directory of _UniversityRegistrar_, and add following to the file with your MySQL username and password
    ```
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=university_registrar;uid=[username];pwd=[password];"
    }
    }
    ```
* Import the database in the root of UniversityRegistrar.Solution
* Run following commands
    ```
    $ dotnet restore
    ```
    ```
    $ dotnet build
    ```
    ```
    $ dotnet run
    ```
</details>

<details>
<summary><strong>For Testing</strong></summary>

* Navigate to  
    <pre>UniversityRegistrar.Solution
    ├── UniversityRegistrar
    └── <strong>UniversityRegistrar.Tests</strong></pre>
* Run following commands
    ```
    $ dotnet restore
    ```
    ```
    $ dotnet test
    ```

</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* 

## License
MIT

## Contact Information
Zhibin Liang <ifthereisoneday@gmail.com>

Copyright &copy; 2022 Zhibin Liang