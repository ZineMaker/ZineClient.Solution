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
