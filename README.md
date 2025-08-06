# Permission System

A simple console application for managing user permissions.

## How to Run

1. Open terminal in project folder
2. Run: `dotnet run`

## Login Credentials

### Default Users:
- **Manager:** username: `manager` password: `manager2025`
- **Admin:** username: `admin` password: `admin2025`  
- **Supervisor:** username: `supervise` password: `supervise2025`
- **Guest:** Any other username/password

### Sample Egyptian Users:
- **Manager:** `ahmed.hassan` / `pass123`
- **Admin:** `yasmin.mahmoud` / `admin123`
- **Supervisor:** `amr.youssef` / `super123`
- **User:** `sara.abdel` / `user123`
- **Guest:** `rania.tarek` / `guest123`

## Permissions

- **Manager:** Read, Insert, Update, Delete
- **Admin:** Read, Insert, Update
- **Supervisor:** Read, Insert
- **User/Guest:** Read only

## Features

- Beautiful welcome screen
- User authentication
- Role-based permissions
- Egyptian user data
- Simple menu system