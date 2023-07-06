# Web Api Entity Framework

## Préparation
- Récupération du fichier Northwind.db
- Création des dossier Models, Controllers, Services, Properties
- Création du fichier Northwind.cs dans le dossier Models
- Ajout du fichier Northwind.db dans le dossier Properties
- Ajout des packages :
  - Microsoft.AspNetCore.OpenApi 
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.VisualStudio.Web.CodeGeneration.Design 
  - Swashbuckle.AspNetCore

## Migration
- Modifier le fichier Northwind.cs pour ajouter le nom de la migration (Northwind_Migration)
- Lancer la commande suivante :
  ```sh
  dotnet ef migrations add Northwind_Migration
  ```