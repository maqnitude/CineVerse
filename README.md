# Overview
**CineVerse** is a concept application for a social network service for movies, inspired by Letterboxd.

This project was developed using WinForms (.NET 8) as part of a course on C# and the .NET framework. We used the [TMDB API](https://developer.themoviedb.org/docs/getting-started) to collect 100 movies, along with cast and crew data for each movie. We also used the Entity Framework Core ORM and PostgreSQL database for the backend.

The collected data can be found at this [link](https://drive.google.com/drive/folders/19ptk6u8Fkh3JoDMG8RSo96aOujAK-5Jj?usp=sharing), place `data` inside the `Data` directory and run
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
to seed the local database.

## Features
_TODO: Insert some screenshots and make this section a table instead_
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
  - Unit of work and repositories (these will ensure the data consistency when updating the database)
