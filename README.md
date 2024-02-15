This REST API for managing cats in a cat shelter has not been finished because the original programmer was allergic to cats and got sick.

Your tasks:
- Download this repository and start it up. You should see SwaggerUI with the API definition
- The API uses the "repository pattern". Are you familiar with this pattern? Why aren't we accesing the storage directly from the API controllers?
- Implement `CatRepository` methods so they do what they're supposed to do
- Right now, `CatRepository` only supports the in-memory cat store. The shelter might need to switch to a proper database later on. Are there any design changes that can be made to `CatRepository` or the project in general to make switching to a different provided easier?
- The shelter only wants the endpoints to work when the header `password` has the value `cats` in it. Implement this.
- Is this auth method secure? What other alternatives could be used?