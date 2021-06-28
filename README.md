# DatingApp

# Create EF migration folder and Initializations

- Enter follow command on the terminal:
  - dotnet ef migrations add InitialCreate -o Data/Migrations

# Adding Bootstrap for Angular

- ng add ngx-bootstrap
  - if you have any issues with @schematics/angular/utility/config then try follow:
    - npm uninstall @schematics/angular
    - npm install @schematics/angular@9.1.0
    - ng add ngx-bootstrap
