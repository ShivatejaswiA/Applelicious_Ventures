# Applelicious-Ventures
Data Source=tcp:applelicious-venture-dbserver.database.windows.net,1433;Initial Catalog=Applelicious-Ventures-db;User Id=Dhariya@applelicious-venture-dbserver;Password=Vicky@321

Update-Database -Connection "Server=tcp:applelicious-venture-dbserver.database.windows.net,1433;Initial Catalog=Applelicious-Ventures-db;Persist Security Info=False;User ID=Dhariya@applelicious-venture-dbserver;Password=Vicky@321;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  

Remove-Migration  
Add-Migration InitialCreate
Update-Database  

If migration success, Migrations folder at least has two files
one is with the name we add migration, such as InitialCreate
another is with the name Snapsho