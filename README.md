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

- [x] Constructed Models for Users, Organizations, Posts, Zines, Tags, and various Join objects
- [x] Migrated into MySQL database
- [x] Built Controller and Views for Account and Organizations

## Working Summary April 7, 2020

- [x] Finish basic CRUD controllers and views for Posts, Zines, Tags
  - [x] create, delete, edit, and see details for each
  - [x] Add/Remove a zine from a post
- [x] Add image properties and ability to add a cover image to a Zine
- [x] Work on styling
  - [x] made a responsive grid of zine covers

## What's next?

- [x] After basic CRUD is implemented, refine the relationships of many-to-many (maybe?)
  - [x] We still need to be able to add users to an organization
- [ ] **Images:**
  - [ ] need to refine 'edit' form for zines - all fields match the ;create', and the create/edit in Posts and Organizations (and maybe users??)
  - [ ] need a default image if no image is added

:---------------------

- [ ] Website design: complete styling
  - [ ] Ensure convention across forms, buttons, menus
    - set all headers the same.
    - set all to grayscale?
  - Room for creativity, implement W3 schools tutorials
    - [ ] Nice splash page and formatting
    - [ ] Explore other frameworks
    - [ ] Zine with posts based on - https://www.w3schools.com/howto/tryhow_css_parallax_demo.htm, https://issuu.com/sweetpaulmagazine/docs/spm_su19_digital?issuu_product=anonymous-homepage, (maybe we include first 2000 characters of a post?)
    - [ ] Posts based on Medium? - https://gen.medium.com/the-adult-in-the-room-is-you-256b450fd954
- [ ] Authentication and roles: deep dive
  - [ ] Owners and co-creators of zines, organizations, etc
  - [ ] Only the creator of an organization or post should be able to delete it
- [x] **Seed the database for display purposes**
- [ ] Uploading pictures to the database
- [ ] Work on how to format a finished Zine - css, html, constraints...
  - [ ] work with pictures and articles
  - [ ] Further exploration: embedding content
    - [ ] Tweets
    - [ ] Videos
- [ ] Search bar & Tag functionality
