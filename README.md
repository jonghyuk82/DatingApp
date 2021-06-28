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

# Adding Bootstrap for Angular

- ng add ngx-bootstrap
  - if you have any issues with @schematics/angular/utility/config then try following:
    - 'npm uninstall @schematics/angular'
    - 'npm install @schematics/angular@9.1.0'
    - 'ng add ngx-bootstrap'
