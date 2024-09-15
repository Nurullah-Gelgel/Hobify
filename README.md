# Hobify - Social Media Platform for Hobby Enthusiasts

## Overview
Hobify is a social media platform that allows users to explore, share, and engage with hobbies they are passionate about. Users can create accounts, post content related to their hobbies, and interact with other hobbyists through comments and likes. The backend of the platform is built using .NET 8 with a clean Onion Architecture, ensuring scalability, maintainability, and testability.

## Features
- **User Authentication & Authorization**: Register and login functionality with role-based access control (admin and regular users).
- **Hobby Feed**: Users can view a feed of hobby-related posts from the community.
- **User Profiles**: Users can manage their profile, add hobbies, and view other users' profiles.
- **Admin Panel**: Admin users have access to manage users, posts, and other admin tasks.
- **Flexible & Modular Architecture**: Built with Onion Architecture for clear separation of concerns and ease of future development.
  
## Tech Stack
- **.NET 8**: Core framework for building the API and handling backend logic.
- **Entity Framework Core**: ORM for managing the database and migrations.
- **SQL Server**: Database system for storing user, post, and other platform data.
- **Authentication & Authorization**: Token-based authentication (JWT) implemented with ASP.NET Core Identity.
  
## Backend Structure
The backend follows the Onion Architecture design pattern, divided into the following layers:

1. **Core (Domain)**: Contains business entities and interfaces.
2. **Application**: Holds service contracts and logic related to application use cases.
3. **Infrastructure**: Deals with database access, authentication, and external services.
4. **Presentation**: API layer that exposes endpoints to the frontend (using controllers).

## API Endpoints
Here are some of the main endpoints available:

- **Authentication**:
  - `POST /api/auth/register`: Register a new user.
  - `POST /api/auth/login`: Login to the platform.
  
- **Hobbies**:
  - `GET /api/hobbies`: Get a list of all hobbies.
  - `POST /api/hobbies`: Create a new hobby post.
  
- **User Profiles**:
  - `GET /api/users/{id}`: Get a user's profile by ID.
  - `PUT /api/users/{id}`: Update a user's profile.

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or any other C# IDE.

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/username/hobify-backend.git
   cd hobify-backend
