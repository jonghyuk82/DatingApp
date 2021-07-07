# DatingApp

# Running API and Angular in vscode

- for API:
  - go to API folder and type 'donet run'
- for Angular:
  - go to client folder and type 'ng serve'

# Create EF migration folder and Initializations

- Enter following command on the terminal:
  - 'dotnet ef migrations add InitialCreate -o Data/Migrations'
- Adding another columns or tables in the DB:
  - adding table or colum in the entities and run following command:
    - stop runnging API and go to API folder type 'dotnet ef migrations add _migrations' name_'
    - and then run command as 'dotnet ef database update' to update actual DB
- Dropping DB and create fresh on with the latest migrations:
  - Stopped API and go to API folder
  - 'dotnet ef database drop'
  - 'dotnet ef databse update'

# Adding Bootstrap for Angular

- ng add ngx-bootstrap
  - if you have any issues with @schematics/angular/utility/config then try following:
    - 'npm uninstall @schematics/angular'
    - 'npm install @schematics/angular@9.1.0'
    - 'ng add ngx-bootstrap'

# Create Angular component using CLI

- go to client/src/app
- type 'ng g -h' for help or 'ng g c nav'
  - it creates component with test files.
- With out test files, type follwing command:

  - 'ng g c _component name_ --skip-tests'

- Adding account service on \_services folder
  - go to client/src/app/\_services
  - type 'ng g s account --skip-test'

# Turn off the strict mode

- open the tsconfig.json file
- change it as following:
  - "strict": false,
  - "strictInjectionParameters": false,
  - "strictInputAccessModifiers": false,
  - "strictTemplates": false

# Install toast / route guard / theme

- go to client folder and 'npm install ngx-toastr'
- Applying route guard
  - create folder named as \_guards and go to the folder.
  - type 'ng g guard auth --skip-tests.
  - select 'CanActivate'
- go to client folder and type 'npm install bootswatch'
  - refer the link: https://bootswatch.com/
