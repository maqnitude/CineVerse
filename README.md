# Overview
**CineVerse** is a social network service for movies. The main motivation behind this application is that each specific country or region has a different, unique pop-culture, which implies that the entertainment preferences are different for each country or region. especially movies and TV series. Unlike [IMDb](https://www.imdb.com/) or [TMDB](https://www.themoviedb.org/), whose audience are usually international, CineVerse would instead focus on an audience from a specific country, i.e., our home country Vietnam.

This repo is a _concept application_ built using WinForms (.NET 8). As for the movies data, we used the [TMDB API](https://developer.themoviedb.org/docs/getting-started) to collect 100 movies, along with cast and crew data for each movie. We also used the Entity Framework Core ORM and PostgreSQL database for the backend.

The collected data can be found at this [link]() (nothing yet), place `data` inside the `Data` directory and run
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
to seed the local database.

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

And more...

## Technical details
- N-tier architecture
  - Application layer (`Core`)
  - Business logic layer (`Services`)
  - Data access layer (`Data`)
- Design patterns
  - Singleton (e.g., each of the services are implemented as a singleton)
  - Publisher/subscriber (our `EventManger` singleton manages all of the custom events and their handlers in the application)
  - Unit of work and repositories (these will ensure the data consistency when updating the database)
