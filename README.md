# Catchup-Platform Project

This project is a C# application built to manage favorite sources, allowing users to create, update, delete, and query their favorite sources. The project follows the Clean Architecture pattern and implements CQRS (Command Query Responsibility Segregation) to separate the handling of commands and queries.

## Table of Contents

1. [Project Description](#project-description)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Project Structure](#project-structure)
5. [Usage](#usage)


---

## 1. Project Description

The **Catchup-Platform** allows users to store their favorite sources of news by interacting with a system that manages these sources. Users can perform CRUD (Create, Read, Update, Delete) operations on the sources. The application is built using Clean Architecture and follows the CQRS pattern to separate reads and writes, ensuring maintainable and scalable code.

---

## 2. Features

- **Create Favorite Source**: Allows users to add new sources to their favorites list.
- **Update Favorite Source**: Enables users to update their existing favorite sources.
- **Delete Favorite Source**: Lets users remove a source from their favorites.
- **Query Favorite Sources**: Users can search for their favorite sources by ID or by the combination of API key and source ID.

---

## 3. Technologies Used

- **C# (.NET 8.0)**
- **CQRS** (Command Query Responsibility Segregation)
- **Clean Architecture**: Organized into layers (Domain, Application, Infrastructure)
- **Git**: For version control


---

## 4. Project Structure

The project follows Clean Architecture principles, dividing code into clear layers:


```vbnet
Catchup-Platform
│
├─── News
│    ├── Application
│    │   └── Internal
│    │       ├── FavoriteSourceCommandService.cs
│    │       └── FavoriteSourceQueryService.cs
│    ├── Domain
│    │   ├── Model
│    │   |   ├── Aggregates
│    │   |   │   └── FavoriteSource.cs
│    │   |   ├── Commands
│    │   |   |   ├── CreateFavoriteSourceCommand.cs
|    |   |   |   ├── DeleteFavoriteSourceCommand.cs
|    |   |   |   └── UpdateFavoriteSourceCommand.cs
│    │   |   ├── Entities
│    │   |   ├── Queries
│    │   |   |   ├── GetFavoriteSourceByIdQuery.cs
|    |   |   |   └── GetFavoriteSourceByNewsApiKeyAndSourceIdQuery.cs
│    │   |   └── Valueobjects
│    │   ├── Repositories
│    |   └── Services
│    │       ├── IFavoriteSourceCommandService.cs
│    │       └── IFavoriteSourceQueryService.cs
│    ├── Infrastructure
│    └── Interfaces
└─── Shared

```

---

## 5. Usage

### Adding a Favorite Source
To add a favorite source, call the `CreateFavoriteSource` method through the `FavoriteSourceCommandService`. You will need to provide the following data:

- **Id**: A unique identifier for the source.
- **NewsApiKey**: The API key for the news source.
- **SourceId**: The unique identifier for the source.

### Querying a Favorite Source
To retrieve a favorite source, you can use either:

- `GetFavoriteSourceByIdQuery`: Retrieve a source by its unique ID.
- `GetFavoriteSourceByNewsApiKeyAndSourceIdQuery`: Retrieve a source by its News API key and Source ID.

### Updating a Favorite Source
To update an existing favorite source, use the `UpdateFavoriteSource` method in the `FavoriteSourceCommandService`, passing the new data.

### Deleting a Favorite Source
To delete a favorite source, call the `DeleteFavoriteSource` method in the `FavoriteSourceCommandService`, passing the ID of the source to be deleted.

