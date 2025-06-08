# Overview
**CineVerse** is a concept application for a social network service for movies, inspired by Letterboxd.

**NOTE**: This project is only for learning purposes, therefore, it is not perfect.

This project was developed using WinForms (.NET 8). We used the [TMDB API](https://developer.themoviedb.org/docs/getting-started) to collect 100 movies, along with cast and crew data for each movie. We also used the Entity Framework (EF) Core ORM and PostgreSQL database for the backend.

## Screenshots
| ![image](https://github.com/user-attachments/assets/2a44b393-ffa0-4eee-ac3a-1e478a0fb370) | ![image](https://github.com/user-attachments/assets/d35bcccf-2e17-4893-818f-e9fd8b7264e6) | ![image](https://github.com/user-attachments/assets/69f5de98-2c01-4eab-b40c-9d5316e3117e) |
| - | - | - |
| ![image](https://github.com/user-attachments/assets/6fddb095-6a29-4efa-91cb-8fa538cb417e) | ![image](https://github.com/user-attachments/assets/5227ff1b-2421-4bf6-aa23-1c9a7ae98e8e) | ![image](https://github.com/user-attachments/assets/689fda42-af98-4670-9b99-8b6c8d51fa14) |

## Features
- Users
  - Authentication (sign in, sign up, reset password via verification code sent through email)
  - Profile customization (change info, display favorite movies, etc.)
  - Follow or unfollow other users
- Movies
  - Browse (search, filter, sort, and view details)
  - Like, rate, review
  - Add to watchlist, custom lists
- Discussions
  - Create post
  - Reply to post and and other comments
  - Upvote or downvote a post or comment

## Technical details
- N-tier architecture
  - Application layer (`Core`)
  - Business logic layer (`Services`)
  - Data access layer (`Data`)
- Design patterns
  - Singleton (e.g., each of the services are implemented as a singleton)
  - Publisher/subscriber (our `EventManger` singleton manages all of the custom events and their handlers in the application)
  - Unit of work and repositories

## Run this project

### Project setup

Clone this project to your local machine:
```
git clone https://github.com/maqnitude/CineVerse.git
```
And open the solution in Visual Studio.

You will also need to setup your local database. In Visual Studio, add an application configuration file (`App.config`) to the project. Here's an example:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section name="emailSettings" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
  </configSections>
  <connectionStrings>
    <add name="DefaultConnection" connectionString="<your database connection string>"/>
  </connectionStrings>
  <emailSettings>
    <add key="Email" value="<email used to sending the verification code>"/>
    <add key="AppPassword" value="<your app password for the email address>"/>
  </emailSettings>
</configuration>
```

### Seed database

The collected data can be found at this [link](https://drive.google.com/drive/folders/19ptk6u8Fkh3JoDMG8RSo96aOujAK-5Jj?usp=sharing), place the folder `data` inside the folder `Data` in the project and run
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Make sure all the all the necessary packages (Entity Framework Core, etc.) are installed. Finally, build and run the project.
