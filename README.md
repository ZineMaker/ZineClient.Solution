# ZineClient.Solution

## Minimum Viable Product (MVP)

- User accounts/authentication
- SQL Database structure
  - Users
  - Publications - the Zine brand
    - Users that are part of it (many-to-many)
    - All zine issues (many-to-one)
  - Zine issues - the individual volume of the zine
    - belongs to a single zine publication (many-to-one)
    - has a collection of posts (many-to-one)
  - Posts - entries/articles/photos
    - created from a single user (many-to-one)
    - can be in any zines where the user has write-access (many-to-many)
- A nice user interface

## Working Summary April 6, 2020

- Constructed Models for Users, Organizations, Posts, Zines, Tags, and various Join objects
- Migrated into MySQL database
- Built Controller and Views for Account and Organizations

## What's next?

- Finish basic CRUD controllers and views for Posts, Zines, Tags
  - create, delete, edit, and see details for each
- After basic CRUD is implemented, refine the relationships of many-to-many (maybe?)
- Website design: complete styling
  - Ensure convention across forms, buttons, menus
  - Room for creativity
    - Nice splash page and formatting
    - Explore other frameworks
- Authentication and roles: deep dive
  - Owners and co-creators of zines, organizations, etc
- Seed the database for display purposes
- Uploading pictures to the database
- Work on how to format a finished Zine - css, html, constraints...
  - work with pictures and articles
  - Further exploration: embedding content
    - Tweets
    - Videos
- Search bar & Tag functionality
